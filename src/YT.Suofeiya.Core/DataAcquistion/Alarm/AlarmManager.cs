using Abp.Dependency;
using Abp.Domain.Repositories;
using Abp.Events.Bus;
using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YT.Suofeiya.Core.PLC;
using YT.Suofeiya.Core.Status;
using YT.Suofeiya.Core.StatusManager;

namespace YT.Suofeiya.Core.Alarm
{
    /// <summary>
    /// 报警点管理
    /// </summary>
    public class AlarmManager : ICheckStatus, ISingletonDependency
    {
        public ILogger Logger { protected get; set; }
        public IEventBus EventBus { get; set; }

        private readonly IRepository<AlarmStatusEntity> _alarmRepository;
        private readonly IRepository<AlarmRecordEntity> _recordRepository;

        /// <summary>
        /// 本地缓存
        /// </summary>
        private readonly Dictionary<int, List<AlarmStatusEntity>> _dicAlarm = new Dictionary<int, List<AlarmStatusEntity>>();

        public AlarmManager(IRepository<AlarmStatusEntity> alarmRepository,
                                IRepository<AlarmRecordEntity> recordRepository,
                                IEventBus eventBus)
        {
            _alarmRepository = alarmRepository;
            _recordRepository = recordRepository;
            Logger = NullLogger.Instance;
            EventBus = eventBus;

            Init();
        }


        /// <summary>
        /// 初始化报警点
        /// </summary>
        public async void Init()
        {
            List<AlarmStatusEntity> alarmInfos = await _alarmRepository.GetAllListAsync();

            foreach (AlarmStatusEntity alarmEntity in alarmInfos)
            {
                if (_dicAlarm.ContainsKey(alarmEntity.AcquisitionPointNo))
                {
                    _dicAlarm[alarmEntity.AcquisitionPointNo].Add(alarmEntity);
                }
                else
                {
                    List<AlarmStatusEntity> dictTmp = new List<AlarmStatusEntity>
                    {
                        alarmEntity
                    };
                    _dicAlarm.Add(alarmEntity.AcquisitionPointNo, dictTmp);
                }

            }
        }

        public bool IsAlarm(StatusEntity curStateInfo)
        {
            bool result = false;
            int pointNo = curStateInfo.AcquisitionPointNo;

            if (_dicAlarm.ContainsKey(pointNo))
            {
                foreach (var item in _dicAlarm[pointNo])
                {
                    if (curStateInfo.Alarms[item.FaultNo])
                    {
                        return true;
                    }

                }
            }
            return result;
        }

        public Task<bool> UpdateAsync(StatusEntity preStateInfo, StatusEntity curStateInfo)
        {
            int pointNo = curStateInfo.AcquisitionPointNo;

            if (_dicAlarm.ContainsKey(pointNo))
            {
                foreach(var item in _dicAlarm[pointNo])
                {
                    item.UpdateTime = DateTime.Now;

                    if (curStateInfo.Alarms != null)
                    {
                        bool curValue = curStateInfo.Alarms[item.FaultNo];
                        if (curValue != item.IsAlarm)
                        {
                            //触发报警
                            if (curValue)
                            {
                                item.TrigLastTime = DateTime.Now;
                                item.AlarmNum += 1;
                                AlarmRecordEntity alarmRecordEntity = new AlarmRecordEntity()
                                {
                                    AlarmID = item.Id,
                                    BeginTime = DateTime.Now,
                                };

                                int recordID = _recordRepository.InsertOrUpdateAndGetId(alarmRecordEntity);
                                item.LastRecordID = recordID;
                            }
                            else//消除报警
                            {
                                AlarmRecordEntity alarmRecordEntity = _recordRepository.FirstOrDefault(item.LastRecordID);
                                if (alarmRecordEntity != null)
                                {
                                    alarmRecordEntity.EndTime = DateTime.Now;
                                    alarmRecordEntity.Duration = ((TimeSpan)(alarmRecordEntity.EndTime - alarmRecordEntity.BeginTime)).TotalSeconds;
                                    _recordRepository.Update(alarmRecordEntity);
                                }

                            }
                        }
                        item.IsAlarm = curValue;
                        _alarmRepository.Update(item);

                    }
                    
                }

            }

            return Task.FromResult(true);
        }

        public Dictionary<int, List<AlarmStatusEntity>> GetCurStatus()
        {
            return _dicAlarm;
        }

    }
}
