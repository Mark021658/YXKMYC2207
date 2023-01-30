using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace YT.Suofeiya.Core.Alarm
{
    public class AlarmStore
    {
        private readonly IRepository<AlarmStatusEntity> _alarmRepository;
        private readonly IRepository<AlarmRecordEntity> _recordRepository;

        public AlarmStore(IRepository<AlarmStatusEntity> alarmRepository,
                                IRepository<AlarmRecordEntity> recordRepository)
        {
            _alarmRepository = alarmRepository;
            _recordRepository = recordRepository;
        }

        public void UpdateAlarm()
        {

        }

        public void InsertAlarmRecord()
        {

        }

        public async Task<List<AlarmRecordEntity>> GetAllAlarmRecordsAsync(DateTime date)
        {
            return await _recordRepository.GetAllListAsync();
        }
    }
}
