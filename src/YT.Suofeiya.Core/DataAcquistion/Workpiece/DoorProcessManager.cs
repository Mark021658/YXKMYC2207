using Abp.Dependency;
using Abp.Domain.Repositories;
using Abp.Events.Bus;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YT.Suofeiya.Core.Order;
using YT.Suofeiya.Core.Status;
using YT.Suofeiya.Core.StatusManager;
using YT.Suofeiya.DataAcquistion.Workpiece;

namespace YT.Suofeiya.Core.Workpiece
{
    public class DoorProcessManager : CheckStatusBase, ISingletonDependency,ICheckStatus
    {
        private readonly IRepository<StatusRecordEntity> _infoRepository;
        private readonly IRepository<OrderEntity> _orderRepository;


        public IEventBus EventBus { get; }

        public DoorProcessManager(
            IRepository<StatusRecordEntity> doorProcessRepository,
            IRepository<OrderEntity> orderRepository,
            IEventBus eventBus)
        {
            _infoRepository = doorProcessRepository;
            _orderRepository = orderRepository;
            EventBus = eventBus;
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


        private async Task<StatusRecordEntity> CreateDefaultRecordAsync(int pointNo, EnumRecordType recordType, string doorId=null)
        {
            StatusRecordEntity doorProcessRecord =  new StatusRecordEntity()
            {
                AcquisitionPointNo = pointNo,
                RecordType = recordType,
                DoorId = doorId,
                StartTime = DateTime.Now,
                IsAlarm = false,
                IsFinish = false,
                Duration = 0,
            };


            var tmp = await _infoRepository.InsertAsync(doorProcessRecord);

            // 记录id
            if (_dictRecords.ContainsKey(recordType))
            {
                _dictRecords[recordType] = tmp;
            }
            else
            {
                _dictRecords.Add(recordType, tmp);
            }

            return doorProcessRecord;
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
                    doorId = curStateInfo.ProcessDoorInternalNo;
                    break;

                // 出料
                case EnumRecordType.Discharge:
                    doorId = curStateInfo.OutDoorInternalNo;
                    break;
            }

            if (state == SIGN_STATE.RisingEdge) // 上升沿  开始进料
            {
                await CreateDefaultRecordAsync(curStateInfo.AcquisitionPointNo, recordType, doorId);
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
                        if(recordType == EnumRecordType.Discharge)
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
                    await CreateDefaultRecordAsync(curStateInfo.AcquisitionPointNo, recordType, doorId);
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

        public async Task UpdateAsync(StatusEntity preStateInfo, StatusEntity curStateInfo)
        {
            // 进料
            SIGN_STATE enterState = CheckState(curStateInfo.StateHasEntered, preStateInfo.StateHasEntered);
            await CheckStateAsync(enterState, EnumRecordType.Feed, curStateInfo);
            // 更改加工进度
            if(enterState == SIGN_STATE.RisingEdge)
            {

            }

            // 加工
            SIGN_STATE processState = CheckState(curStateInfo.StateProcessing, preStateInfo.StateProcessing);
            await CheckStateAsync(processState, EnumRecordType.Process, curStateInfo);

            // 出料
            SIGN_STATE dischargeState = CheckState(curStateInfo.StateHasGoneOut, preStateInfo.StateHasGoneOut);
            await CheckStateAsync(dischargeState, EnumRecordType.Discharge, curStateInfo);
            // 统计数量
            if(dischargeState == SIGN_STATE.DescentEdge)
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

            // 上电时间
            SIGN_STATE powerState = CheckState(curStateInfo.StateIsPower, preStateInfo.StateIsPower);
            await CheckStateAsync(powerState, EnumRecordType.Power, curStateInfo);

            // 停机  开机总时长 - 运行时长
        }

        Task<bool> ICheckStatus.UpdateAsync(StatusEntity preStateInfo, StatusEntity curStateInfo)
        {
            throw new NotImplementedException();
        }
    }
}
