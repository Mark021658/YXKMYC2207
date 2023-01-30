using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YT.Suofeiya.Core.Alarm;
using YT.Suofeiya.Core.Status;
using YT.Suofeiya.Core.Tool;
using YT.Suofeiya.DataAcquistion.Energy;
using YT.Suofeiya.DataAcquistion.Status.Dto;

namespace YT.Suofeiya.Status
{
    public interface IStatusAppService : IApplicationService
    {
        Dictionary<int, StatusEntity> GetCurStatus();

        Dictionary<int, List<AlarmStatusEntity>> GetCurAlarm();

        Dictionary<int, List<ToolsStatusEntity>> GetCurTool();

        ElectricEnergyEntity GetEnergyStatus();

        List<StatusRecordDto> GetStatusRecords(DateTime startTime, DateTime endTime);

        bool GetMESstatus();
        void Clear();
    }
}


