using Abp.Domain.Repositories;
using Abp.Events.Bus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YT.Suofeiya.Core.PLC;
using YT.Suofeiya.Core.StatusManager;
using YT.Suofeiya.DataAcquistion.Workpiece;
using YT.Suofeiya.Line;

namespace YT.Suofeiya.Core.Status
{
    public class DevStatusManager : CheckStatusBase, ICheckStatus
    {
        public IEventBus EventBus { get; set; }
        private readonly IRepository<StatusRecordEntity> _infoRepository;
        private readonly LineParamManager _lineparm;

        public DevStatusManager(
            IRepository<StatusRecordEntity> doorProcessRepository,
            LineParamManager lineparm,
            IEventBus eventBus)
        {
            _infoRepository = doorProcessRepository;
            EventBus = eventBus;
            _lineparm = lineparm;
        }


        private string ConvertTimeSpanToString(TimeSpan ts)
        {
            string strTime = null;

            strTime += ts.Hours.ToString().PadLeft(2, '0') + ":";
            strTime += ts.Minutes.ToString().PadLeft(2, '0') + ":";
            strTime += ts.Seconds.ToString().PadLeft(2, '0');

            return strTime;
        }


        private Dictionary<EnumRecordType, StatusRecordEntity> _dictRecords = new Dictionary<EnumRecordType, StatusRecordEntity>();


        private async Task<StatusRecordEntity> CreateDefaultRecordAsync(StatusEntity curStateInfo, EnumRecordType recordType, string doorId = null)
        {
            StatusRecordEntity record = _infoRepository.FirstOrDefault(q => q.AcquisitionPointNo == curStateInfo.AcquisitionPointNo
                    && q.UpdateDate == curStateInfo.UpdateTime.Date);
            if (record == null)
            {
                record = new StatusRecordEntity();
            }
            record.DoorId = doorId;
            record.AcquisitionPointNo = curStateInfo.AcquisitionPointNo;
            record.UpdateDate = curStateInfo.UpdateTime.Date;
            record.UpdateTime = curStateInfo.UpdateTime;
            record.EndTime = curStateInfo.EndTime;
            record.StartTime = curStateInfo.StartTime;
            record.Duration = curStateInfo.ProcessingTime;
            record.StandByTime = curStateInfo.StandByTime;
            record.DownTime = curStateInfo.HaltTime;
            record.OfflineTime = curStateInfo.OfflineTime;
            record.Quantity = curStateInfo.Quantity;

            var tmp = await _infoRepository.InsertOrUpdateAsync(record);

            // 记录id
            if (_dictRecords.ContainsKey(recordType))
            {
                _dictRecords[recordType] = tmp;
            }
            else
            {
                _dictRecords.Add(recordType, tmp);
            }

            return record;
        }

        public async Task CheckStateAsync(SIGN_STATE state, EnumRecordType recordType, StatusEntity curStateInfo)
        {
            string doorId = null;
            switch (recordType)
            {
                // 进料
                case EnumRecordType.Feed:
                    doorId = curStateInfo.InDoorInternalNo;
                    break;

                // 加工
                case EnumRecordType.Process:
                    doorId = curStateInfo.ProcessDoorInternalNo.ToString();
                    break;

                // 出料
                case EnumRecordType.Discharge:
                    doorId = curStateInfo.OutDoorInternalNo;
                    break;
            }

            if (state == SIGN_STATE.RisingEdge) // 上升沿  开始进料
            {
                await CreateDefaultRecordAsync(curStateInfo, recordType, doorId);
            }
            else if (state == SIGN_STATE.High) // 高  计时，超过指定时间
            {
                if (_dictRecords.ContainsKey(recordType))
                {
                    var record = _dictRecords[recordType];

                    if (record != null)
                    {
                        record.Duration = (DateTime.Now - record.StartTime).TotalSeconds;

                        // 如果出料超时，堵停
                        if (recordType == EnumRecordType.Discharge)
                        {
                            // 时间待定，设为全局变量
                            if (record.Duration > 60 && !record.IsAlarm)
                            {
                                record.IsAlarm = true;
                            }
                        }

                    }
                    else
                    {
                        // 内部报错
                        //throw Exception("");
                    }
                }
                else
                {
                    // 重新创建一个
                    await CreateDefaultRecordAsync(curStateInfo, recordType, doorId);
                }

            }
            else if (state == SIGN_STATE.DescentEdge) // 下降沿 进料结束
            {
                if (_dictRecords.ContainsKey(recordType))
                {
                    var record = _dictRecords[recordType];

                    if (record != null)
                    {
                        record.Duration = (DateTime.Now - record.StartTime).TotalSeconds;
                        record.EndTime = DateTime.Now;
                        record.IsFinish = true;

                        // 更新各指标总时长
                    }
                    _dictRecords.Remove(recordType);
                }
            }
            else if (state == SIGN_STATE.Low)
            {
                if (_dictRecords.ContainsKey(recordType))
                {
                    _dictRecords.Remove(recordType);
                }
            }
        }

        public async Task<bool> UpdateAsync(StatusEntity preStateInfo, StatusEntity curStateInfo)
        {
            // 上电时间
            SIGN_STATE powerState = CheckState(curStateInfo.StateIsPower, preStateInfo.StateIsPower);
            await CheckStateAsync(powerState, EnumRecordType.Power, curStateInfo);

            // 如果未上电，则不继续执行下去
            if(powerState == SIGN_STATE.Low)
            {
                return false;
            }

            // 进料
            SIGN_STATE enterState = CheckState(curStateInfo.StateHasEntered, preStateInfo.StateHasEntered);
            await CheckStateAsync(enterState, EnumRecordType.Feed, curStateInfo);
            // 更改加工进度
            

            // 加工
            SIGN_STATE processState = CheckState(curStateInfo.StateProcessing, preStateInfo.StateProcessing);
            await CheckStateAsync(processState, EnumRecordType.Process, curStateInfo);

            // 出料
            SIGN_STATE dischargeState = CheckState(curStateInfo.StateHasGoneOut, preStateInfo.StateHasGoneOut);
            await CheckStateAsync(dischargeState, EnumRecordType.Discharge, curStateInfo);
            // 统计数量
            if (dischargeState == SIGN_STATE.DescentEdge)
            {
                curStateInfo.Quantity += 1;
            }

            // 调试
            SIGN_STATE debugState = CheckState(curStateInfo.StateDebug, preStateInfo.StateDebug);
            await CheckStateAsync(debugState, EnumRecordType.Debug, curStateInfo);

            // 维修
            SIGN_STATE repairState = CheckState(curStateInfo.StateRepair, preStateInfo.StateRepair);
            await CheckStateAsync(repairState, EnumRecordType.Repair, curStateInfo);

            // 运行
            SIGN_STATE runState = CheckState(curStateInfo.StateIsConnect, preStateInfo.StateIsConnect);
            await CheckStateAsync(runState, EnumRecordType.Run, curStateInfo);


            // 停机  开机总时长 - 运行时长
            return true;
        }

    }
}
