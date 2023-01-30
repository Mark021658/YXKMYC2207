using Abp.Dependency;
using Abp.Domain.Repositories;
using Abp.Modbus;
using Abp.UI;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YT.Suofeiya.Core.PLC;
using YT.Suofeiya.Core.Status;
using YT.Suofeiya.Core.StatusManager;

namespace YT.Suofeiya.Core.Tool
{
    public class ToolManager : SuofeiyaAppServiceBase, ICheckStatus
    {
        private readonly IRepository<ToolsStatusEntity> _toolRepository;
        private readonly IRepository<ToolChangeEntity> _toolChangeRepository;
        private readonly Dictionary<int, List<ToolsStatusEntity>> _dicTool = new Dictionary<int, List<ToolsStatusEntity>>();
        private readonly ITcpModbus _plcModbus;
        private readonly IRepository<AcquisitionPointEntity> _AcquisitionPointRepository;
        private readonly IRepository<ToolsRecordEntity> _ToolRecordRepository;
        List<AcquisitionPointEntity> pointList;
        public ToolManager(IRepository<ToolsStatusEntity> toolRepository,
            ITcpModbus plcModbus,
            IRepository<AcquisitionPointEntity> AcquisitionPointRepository,
            IRepository<ToolsRecordEntity> ToolRecordRepository,
            IRepository<ToolChangeEntity> toolChangeRepository)
        {
            _toolRepository = toolRepository;
            _toolChangeRepository = toolChangeRepository;
            _plcModbus = plcModbus;
            _ToolRecordRepository = ToolRecordRepository;
            _AcquisitionPointRepository = AcquisitionPointRepository;
            Initialize();

            pointList = _AcquisitionPointRepository.GetAllList();
        }

        public void Initialize()
        {
            List<ToolsStatusEntity> toolInfos = _toolRepository.GetAllList();
            foreach (ToolsStatusEntity toolEntity in toolInfos)
            {
                if (_dicTool.ContainsKey(toolEntity.AcquisitionPointNo))
                {
                    _dicTool[toolEntity.AcquisitionPointNo].Add(toolEntity);
                }
                else
                {
                    List<ToolsStatusEntity> dictTmp = new List<ToolsStatusEntity>
                    {
                        toolEntity
                    };
                    _dicTool.Add(toolEntity.AcquisitionPointNo, dictTmp);
                }

            }
        }

        private void UpdateToolUsedCounts(int pointNo, int toolNo, int counts)
        {
            var info = _dicTool[pointNo][toolNo];

            info.UsedCount = counts;
            //info.IsAlarm = info.UsedCount > info.PresettingCount ? true : false;
            info.UpdateTime = DateTime.Now;

        }

        public void Update(int pointNo, int toolNo, string toolName, int presettingCount)
        {
            var info = _dicTool[pointNo][toolNo];
            info.ToolName = toolName;
            info.PresettingCount = presettingCount;
            // info.IsAlarm = info.UsedCount > info.PresettingCount ? true : false;
            info.UpdateTime = DateTime.Now;
            //_infoRepository.Update(info);
        }


        public void Clear(int pointNo, int toolNo)
        {
            //写数据库
            var info = _dicTool[pointNo][toolNo];
            info.UsedCount = 0;
            info.IsAlarm = false;
            info.TotalUsedTime = 0;
            info.UpdateTime = DateTime.Now;
            //_infoRepository.Update(info);
        }

        public Task<bool> UpdateAsync(StatusEntity preStateInfo, StatusEntity curStateInfo)
        {
            int pointNo = curStateInfo.AcquisitionPointNo;

            if (_dicTool.ContainsKey(pointNo))
            {
                foreach (var curTool in _dicTool[pointNo])
                {
                    //var curTool = await _toolRepository.FirstOrDefaultAsync(item.Id);
                    bool curValue = false;
                    if (curStateInfo.ToolsUsed != null)
                    {
                        curValue = curStateInfo.ToolsUsed[curTool.ToolNo];
                        if (curValue != curTool.IsUsed)
                        {
                            //触发使用
                            if (curValue)
                            {
                                curTool.TrigLastTime = DateTime.Now;
                                curTool.UsedCount += 1;


                            }
                            else
                            {
                                curTool.TotalUsedTime += ((TimeSpan)(DateTime.Now - curTool.TrigLastTime)).TotalSeconds;
                                
                                this.RecordDistance(curStateInfo, curTool);
                            }
                        }
                    }

                    if(curTool.WornPartType == 0)
                    {
                        if (curTool.PresettingCount < curTool.UsedCount)
                        {
                            curTool.IsAlarm = true;
                        }
                        else
                        {
                            curTool.IsAlarm = false;
                        }
                    }
                    else
                    {
                        if(curTool.ChangeTime == null)
                        {
                            curTool.ChangeTime = DateTime.Now;
                        }
                        else
                        {
                            if(((TimeSpan)(curTool.UpdateTime - curTool.ChangeTime)).TotalDays > curTool.PresettingCount)
                            {
                                curTool.IsAlarm = true;
                            }
                            else
                            {
                                curTool.IsAlarm = false;
                            }
                        }
                    }

                    curTool.IsUsed = curValue;
                    curTool.UpdateTime = DateTime.Now;

                
                    _toolRepository.Update(curTool);
                }

            }


            return Task.FromResult(true);

        }

        /// <summary>
        /// 更新刀具设置
        /// </summary>
        /// <param name="pointNo">采集点</param>
        /// <param name="toolNo">刀具号</param>
        /// <param name="toolName">刀具名</param>
        /// <param name="presettingCount">预设</param>
        public Task UpdateToolSetting(int pointNo, int toolNo,string toolName, int presettingCount)
        {
            if (!_dicTool.ContainsKey(pointNo))
            {
                throw new UserFriendlyException($"UnknownWornPart {pointNo}-{toolNo}");
            }

            ToolsStatusEntity info = _dicTool[pointNo].FirstOrDefault(e => e.ToolNo == toolNo);
            
            if(info == null)
            {
                throw new UserFriendlyException($"UnknownWornPart {pointNo}-{toolNo}");
            }

            info.ToolName = toolName;
            info.PresettingCount = presettingCount;
            info.IsAlarm = info.UsedCount > info.PresettingCount;
            info.UpdateTime = DateTime.Now;
            //_toolRepository.Update(info);
            return Task.FromResult(0);
        }

        /// <summary>
        /// 更换刀具
        /// </summary>
        /// <param name="pointNo"></param>
        /// <param name="toolNo"></param>
        /// <returns></returns>
        public Task ChangeTool(int pointNo, int toolNo)
        {
            if (!_dicTool.ContainsKey(pointNo))
            {
                throw new UserFriendlyException($"UnknownWornPart {pointNo}-{toolNo}");
            }

            ToolsStatusEntity info = _dicTool[pointNo].FirstOrDefault(e => e.ToolNo == toolNo);

            if (info == null)
            {
                throw new UserFriendlyException($"UnknownWornPart {pointNo}-{toolNo}");
            }

            info.UsedCount = 0;
            info.IsAlarm = false;
            info.TotalUsedTime = 0;
            info.UpdateTime = DateTime.Now;

            return Task.FromResult(0);
        }

        public Dictionary<int, List<ToolsStatusEntity>> GetCurStatus()
        {
            return _dicTool;
        }

        private async void RecordDistance(StatusEntity curStateInfo, ToolsStatusEntity tool)
        {
            await Task.Run(() => {
                try
                { 
                    ToolsRecordEntity record = new ToolsRecordEntity { 
                        AcquisitionPointNo = tool.AcquisitionPointNo,
                        ToolNo = tool.ToolNo,
                        ToolName = tool.ToolName,
                        UpdateTime = DateTime.Now,
                        DoorId = curStateInfo.ProcessDoorInternalNo
                    };

                    AcquisitionPointEntity point = pointList.FirstOrDefault(e => e.AcquisitionPointNo == tool.AcquisitionPointNo);
                    if (tool.DistanceX_Addr != null && tool.DistanceX_Addr > 0)
                    {
                        ushort[] xData = _plcModbus.ReadHoldingRegistersAsync(point.AcquisitionDeviceNo, (ushort)tool.DistanceX_Addr, 2);
                        int xDistance = getIntValue(xData);
                        record.DistanceX = xDistance;
                    }

                    if (tool.DistanceY_Addr != null && tool.DistanceY_Addr > 0)
                    {
                        ushort[] yData = _plcModbus.ReadHoldingRegistersAsync(point.AcquisitionDeviceNo, (ushort)tool.DistanceY_Addr, 2);
                        int yDistance = getIntValue(yData);
                        record.DistanceY = yDistance;
                    }

                    if (tool.DistanceZ_Addr != null && tool.DistanceZ_Addr > 0)
                    {
                        ushort[] zData = _plcModbus.ReadHoldingRegistersAsync(point.AcquisitionDeviceNo, (ushort)tool.DistanceZ_Addr, 2);
                        int zDistance = getIntValue(zData);
                        record.DistanceZ = zDistance;
                    }
                    _ToolRecordRepository.InsertOrUpdate(record);
                }
                catch (Exception ex)
                {
                    
                }
            });
        }

        
        private int getIntValue(ushort[] data)
        {
            byte[] ba = BitConverter.GetBytes(data[0]);
            byte[] bb = BitConverter.GetBytes(data[1]);
            byte[] bn = new byte[4];
            bn[0] = ba[0];
            bn[1] = ba[1];
            bn[2] = bb[0];
            bn[3] = bb[1];
            int value = BitConverter.ToInt32(bn, 0);

            return value;
        }
    }
}
