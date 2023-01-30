using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YT.Suofeiya.Alarm.Dto;

namespace YT.Suofeiya.Alarm
{
    public interface IAlarmAppService
    {
        //PagedResultDto<AlarmDto> GetCurPage(int pageIndex, int pageSize);
        List<AlarmHistoryDto> GetAll(DateTime dtToday);
        List<AlarmHistoryDto> GetQuery(int procedureNo);

        List<AlarmDto> GetAll();

        void createAlarm(AlarmDto dto);

        void updateAlarm(AlarmDto dto);
    }
}
