using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using AutoMapper;
using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YT.Suofeiya.Alarm.Dto;
using YT.Suofeiya.Core.Alarm;
using YT.Suofeiya.Core.PLC;

namespace YT.Suofeiya.Alarm
{
    public class AlarmAppService : SuofeiyaAppServiceBase, IAlarmAppService
    {
        private readonly IRepository<AlarmStatusEntity> _infoRepository;
        private readonly IRepository<AlarmRecordEntity> _recordRepository;
        private readonly IRepository<AcquisitionPointEntity> _pointRepository;
        private readonly IMapper _autoMapper;

        public AlarmAppService(IRepository<AlarmStatusEntity> infoRepository, 
            IRepository<AlarmRecordEntity> recordRepository,
            IRepository<AcquisitionPointEntity> pointRepository,
            IMapper mapper)
        {
            _infoRepository = infoRepository;
            _autoMapper = mapper;
            _recordRepository = recordRepository;
            _pointRepository = pointRepository;
            Logger = NullLogger.Instance;
        }

        public PagedResultDto<AlarmDto> GetCurPage(int pageIndex, int pageSize)
        {
            int totalCount = _infoRepository.Count();

            double pageCount = Math.Ceiling((double)totalCount / (double)pageSize);

            int totalPage = (int)pageCount;

            if (pageIndex >= totalPage)
            {
                pageIndex = totalPage;
            }

            List<AlarmDto> list = _autoMapper.Map<List<AlarmDto>>(_infoRepository.GetAll().OrderBy(t => t.Id)
                .Skip((pageIndex) * pageSize).Take(pageSize).ToList());

            return new PagedResultDto<AlarmDto>(totalCount, list);
        }

        public List<AlarmHistoryDto> GetAll(DateTime dtToday)
        {
            dtToday = Convert.ToDateTime(dtToday.ToString("yyyy-MM-dd"));
            DateTime dtNexDay = dtToday.AddDays(1);//明天

            var points =_pointRepository.GetAll().OrderBy(a => a.AcquisitionPointNo).ToList();


            var data = _recordRepository.GetAll().Join(_infoRepository.GetAll(), e => e.AlarmID, o => o.Id, (e, o) => new { o.AcquisitionPointNo, o.FaultNo, FaultName = o.Name, e.BeginTime, e.EndTime, e.Duration }).Where(c => c.BeginTime > dtToday && c.BeginTime < dtNexDay).ToList();

            List<AlarmHistoryDto> dtos = new List<AlarmHistoryDto>();
            foreach (var item in data)
            {
                string name = "";

                //int AcquisitionPointNo = item.AcquisitionPointNo;
                //name = points.FirstOrDefault(x => x.AcquisitionPointNo == AcquisitionPointNo).PointName;
                foreach (var point in points) 
                {
                    if (point.AcquisitionPointNo == item.AcquisitionPointNo) {
                        name = point.PointName;
                    }
                }
                AlarmHistoryDto dto = new AlarmHistoryDto()
                {
                    AcquisitionPointNo = item.AcquisitionPointNo,
                    PointName = name,
                    FaultNo = item.FaultNo,
                    FaultName = item.FaultName,
                    BeginTime = item.BeginTime,
                    EndTime = item.EndTime,
                    Duration = item.Duration,
                };

                dtos.Add(dto);
            }
            return dtos;
        }

        public List<AlarmHistoryDto> GetQuery(int pointeNo)
        {
            var data = _recordRepository.GetAll().Join(_infoRepository.GetAll(), e => e.AlarmID, o => o.Id, (e, o) => new { o.AcquisitionPointNo, o.FaultNo, FaultName=o.Name, e.BeginTime, e.EndTime, e.Duration }).Where(q => q.AcquisitionPointNo == pointeNo).OrderByDescending(a => a.BeginTime).ToList();
            //var data = _recordRepository.GetAll().Join(_infoRepository.GetAll(), e => e.AlarmID, o => o.Id, (e, o) => new { ProcedureNo = e.ProcedureNo, CreateTime = e.CreateTime, FaultCode = e.FaultCode, SubNo = e.SubNo, FaultNo = e.FaultNo, FaultName = o.Name }).Where(q => q. == pointeNo).OrderByDescending(a => a.).ToList();

            List<AlarmHistoryDto> dtos = new List<AlarmHistoryDto>();
            foreach (var item in data)
            {
                AlarmHistoryDto dto = new AlarmHistoryDto()
                {
                    AcquisitionPointNo = item.AcquisitionPointNo,
                    FaultNo = item.FaultNo,
                    FaultName = item.FaultName,
                    BeginTime = item.BeginTime,
                    EndTime= item.EndTime,
                    Duration = item.Duration,
                };              

                dtos.Add(dto);
            }
            return dtos;
        }

        public List<AlarmDto> GetAll()
        {
            List<AlarmStatusEntity> list = _infoRepository.GetAll().ToList();
            return ObjectMapper.Map<List<AlarmDto>>(list);
        }


        public void createAlarm(AlarmDto dto)
        {
            AlarmStatusEntity entity = new AlarmStatusEntity
            {
                AcquisitionPointNo = dto.AcquisitionPointNo,
                FaultNo = dto.FaultNo,
                AlarmType = dto.AlarmType,
                Name = dto.Name
            };
            _infoRepository.Insert(entity);
        }

        public void updateAlarm(AlarmDto dto)
        {
            AlarmStatusEntity entity = _infoRepository.FirstOrDefault(e=>e.Id == dto.Id);
            entity.AcquisitionPointNo = dto.AcquisitionPointNo;
            entity.FaultNo = dto.FaultNo;
            entity.AlarmType = dto.AlarmType;
            entity.Name = dto.Name;
            _infoRepository.Update(entity);
        }
    }
}
