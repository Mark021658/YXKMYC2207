using Abp.Dependency;
using Abp.Domain.Repositories;
using Abp.Modbus;
using Abp.Quartz;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YT.Suofeiya.Core.PLC;
using YT.Suofeiya.Core.Tool;

namespace YT.QuartzTask.Job
{
    [DisallowConcurrentExecution]
    public class ToolDistanceJob : JobBase, ITransientDependency
    {

        private readonly ITcpModbus _plcModbus;
        private readonly IRepository<AcquisitionPointEntity> _AcquisitionPointRepository;
        private readonly IRepository<ToolsStatusEntity> _ToolRepository;

        public ToolDistanceJob(
            ITcpModbus plcModbus,
            IRepository<AcquisitionPointEntity> AcquisitionPointRepository,
            IRepository<ToolsStatusEntity> toolRepository)
        {
            _plcModbus = plcModbus;
            _AcquisitionPointRepository = AcquisitionPointRepository;
            _ToolRepository = toolRepository;
        }
        public override Task Execute(IJobExecutionContext context)
        {
            try
            {
                List<AcquisitionPointEntity> pointList = _AcquisitionPointRepository.GetAllList();
                List<ToolsStatusEntity> tools = _ToolRepository.GetAllList();

                foreach (ToolsStatusEntity tool in tools)
                {
                    AcquisitionPointEntity point = pointList.FirstOrDefault(e => e.AcquisitionPointNo == tool.AcquisitionPointNo);
                    if (tool.DistanceX_Addr != null && tool.DistanceX_Addr > 0) 
                    {
                        ushort[] xData = _plcModbus.ReadHoldingRegistersAsync(point.AcquisitionDeviceNo, (ushort)tool.DistanceX_Addr, 2);
                        int xDistance = getIntValue(xData);
                        tool.DistanceX = xDistance;
                    }

                    if (tool.DistanceY_Addr != null && tool.DistanceY_Addr > 0)
                    {
                        ushort[] yData = _plcModbus.ReadHoldingRegistersAsync(point.AcquisitionDeviceNo, (ushort)tool.DistanceY_Addr, 2);
                        int yDistance = getIntValue(yData);
                        tool.DistanceY = yDistance;
                    }

                    if (tool.DistanceZ_Addr != null && tool.DistanceZ_Addr > 0)
                    {
                        ushort[] zData = _plcModbus.ReadHoldingRegistersAsync(point.AcquisitionDeviceNo, (ushort)tool.DistanceZ_Addr, 2);
                        int zDistance = getIntValue(zData);
                        tool.DistanceZ = zDistance;
                    }
                    tool.UpdateTime = DateTime.Now;
                    _ToolRepository.Update(tool);

                }

            }
            catch (Exception ex)
            {
                Logger.Error("get tooldistance error=" + ex.Message);
            }
            return Task.CompletedTask;
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
