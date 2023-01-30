using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using AutoMapper;
using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YT.Suofeiya.Core.PLC;
using YT.Suofeiya.Core.Procedure;
using YT.Suofeiya.Core.Tool;
using YT.Suofeiya.Tool.Dto;

namespace YT.Suofeiya.Tool
{
    public class ToolAppService : SuofeiyaAppServiceBase, IToolAppService
    {
        private readonly IRepository<ToolsStatusEntity> _infoRepository;
        private readonly IRepository<ProcedureEntity> _nameRepository;
        private readonly IRepository<AcquisitionDataEntity> _registersRepository;
        private readonly IRepository<ToolChangeEntity> _toolChangeRepository;
        private readonly IRepository<ToolsRecordEntity> _ToolRecordRepository;
        public ToolAppService(IRepository<ToolsStatusEntity> infoRepository, 
            IRepository<ProcedureEntity> nameRepository,
            IRepository<ToolChangeEntity> toolChangeRepository,
            IRepository<ToolsRecordEntity> ToolRecordRepository,
            IRepository<AcquisitionDataEntity> registersRepository)
        {
            _infoRepository = infoRepository;
            _nameRepository = nameRepository;
            _registersRepository = registersRepository;
            _toolChangeRepository = toolChangeRepository;
            _ToolRecordRepository = ToolRecordRepository;
            Logger = NullLogger.Instance;
        }


        private void UpdateToolUsedCounts(int procedureNo, int toolNo, int counts)
        {
            ToolsStatusEntity info = _infoRepository.FirstOrDefault(p => p.AcquisitionPointNo == procedureNo && p.ToolNo == toolNo);
            if (info == null)
            {
                ToolsStatusEntity toolsStatisticalInfo = new ToolsStatusEntity()
                {
                    AcquisitionPointNo = procedureNo,
                    ToolNo = toolNo,
                    ToolName = "未知",
                    UsedCount = counts,
                    PresettingCount = 0,
                    IsAlarm = false,
                    IsUsed = false
                };
                _infoRepository.Insert(toolsStatisticalInfo);
            }
            else
            {
                info.UsedCount = counts;
                //info.IsAlarm = info.UsedCount > info.PresettingCount ? true : false;
                info.UpdateTime = DateTime.Now;
                _infoRepository.Update(info);
            }
        }



        //界面调用
        public List<ToolDto> GetTools(int plcNo)
        {
            int totalCount = _infoRepository.Count();
            List<ToolsStatusEntity> toolslist = _infoRepository.GetAll().Where(q => q.AcquisitionPointNo == plcNo).ToList();
            //List<ToolDto> dtos = ObjectMapper.Map<List<ToolDto>>(list);
            List<ToolDto> dtos = new List<ToolDto>();
            foreach(var toolinfo in toolslist)
            {
                ToolDto tooldt = new ToolDto()
                {
                    Id = toolinfo.Id,
                    AcquisitionPointNo = toolinfo.AcquisitionPointNo,
                    ToolNo = toolinfo.ToolNo,
                    ToolName = toolinfo.ToolName,
                    WornPartType = toolinfo.WornPartType,
                    BeginTime = toolinfo.BeginTime,
                    EndTime = toolinfo.EndTime,
                    UpdateTime = toolinfo.UpdateTime,
                    TrigLastTime = toolinfo.TrigLastTime,
                    UsedCount = toolinfo.UsedCount,
                    TotalUsedTime = toolinfo.TotalUsedTime,
                    PresettingCount = toolinfo.PresettingCount,
                    ToolStatus = toolinfo.ToolStatus,
                    IsUsed = toolinfo.IsUsed,
                    IsAlarm = toolinfo.IsAlarm,
                    ChangeTime = toolinfo.ChangeTime,
                    DistanceX = toolinfo.DistanceX,
                    DistanceY = toolinfo.DistanceY,
                    DistanceZ = toolinfo.DistanceZ
                };
                dtos.Add(tooldt);
            }
            return dtos;

            //record.Count = record.Records.Count();
            //return record;
        }

        public void Update(int AcquisitionNo, int ToolNo, string ToolName, int presettingCount )
        {
            ToolsStatusEntity info = _infoRepository.FirstOrDefault(e => e.AcquisitionPointNo == AcquisitionNo && e.ToolNo==ToolNo);
            info.ToolName = ToolName;
            info.PresettingCount = presettingCount;
            //info.IsAlarm = info.UsedCount > info.PresettingCount ? true : false;
            info.UpdateTime = DateTime.Now;
            _infoRepository.Update(info);
        }

        public void Clear(int id, string name, string remarks, bool isClear = false)
        {
            //写数据库
            ToolsStatusEntity info = _infoRepository.FirstOrDefault(e => e.Id == id);

            ToolChangeEntity toolChangeEntity = new ToolChangeEntity()
            {
                AcquisitionPointNo = info.AcquisitionPointNo,
                ToolNo = info.ToolNo,
                ToolName = info.ToolName,
                ChangeTime = DateTime.Now,
                OperaterName = name,
                UsedTime = info.TotalUsedTime,
                Remarks = remarks
            };
            _toolChangeRepository.Insert(toolChangeEntity);

            if (isClear)
            {
                info.UsedCount = 0;
                info.TotalUsedTime = 0;
            }

            info.IsAlarm = false;
            info.ChangeTime = DateTime.Now;
            _infoRepository.Update(info);



        }

        public Task<ToolStatisticsDto> GetToolStatistics()
        {
            int totalNum = _infoRepository.GetAll().Count();
            int alarmNum = _infoRepository.GetAll().Where(c => c.IsAlarm == true).Count();

            return Task.FromResult(new ToolStatisticsDto()
            {
                TotalNum = totalNum,
                AlarmNum = alarmNum
            });
        }

        public List<IGrouping<int, ToolsStatusEntity>> AlarmToolProcedureList()
        {
            //List<int> listProcedure = new List<int>();
            List<IGrouping<int, ToolsStatusEntity>> list = _infoRepository.GetAll().Where(c => c.IsAlarm == true).GroupBy(p => p.AcquisitionPointNo).ToList();
            /*
            foreach (IGrouping<int, ToolsStatisticalInfo> info in list)
            {
                listProcedure.Add(info.Key);
            }
            */
            return list;
        }

        public List<ToolChangeDto> GetToolChangeRecord(DateTime startTime, DateTime endTime) 
        {
            List<ToolChangeEntity> list = _toolChangeRepository.GetAll().Where(c => c.ChangeTime > startTime && c.ChangeTime < endTime).ToList();
            return ObjectMapper.Map<List<ToolChangeDto>>(list);
        }

        public List<ToolDto> GetAll()
        {
            List<ToolsStatusEntity> list = _infoRepository.GetAll().ToList();
            return ObjectMapper.Map<List<ToolDto>>(list);
        }

        public void createTool(ToolDto dto)
        {
            ToolsStatusEntity entity = new ToolsStatusEntity
            {
                AcquisitionPointNo = dto.AcquisitionPointNo,
                ToolNo = dto.ToolNo,
                ToolName = dto.ToolName,
                WornPartType = dto.WornPartType,
                PresettingCount = dto.PresettingCount,
                DistanceX_Addr = dto.DistanceX_Addr,
                DistanceY_Addr = dto.DistanceY_Addr,
                DistanceZ_Addr = dto.DistanceZ_Addr
            };
            _infoRepository.Insert(entity);
        }

        public void updateTool(ToolDto dto)
        {
            ToolsStatusEntity entity = _infoRepository.FirstOrDefault(e=>e.Id == dto.Id);
            entity.AcquisitionPointNo = dto.AcquisitionPointNo;
            entity.ToolNo = dto.ToolNo;
            entity.ToolName = dto.ToolName;
            entity.WornPartType = dto.WornPartType;
            entity.PresettingCount = dto.PresettingCount;
            entity.DistanceX_Addr = dto.DistanceX_Addr;
            entity.DistanceY_Addr = dto.DistanceY_Addr;
            entity.DistanceZ_Addr = dto.DistanceZ_Addr;
            _infoRepository.Update(entity);
        }

        public List<ToolsRecordDto> GetAllTool(DateTime dt)
        {
            DateTime qStartTime = Convert.ToDateTime(dt.ToString("yyyy-MM-dd"));
            DateTime qEndTime = Convert.ToDateTime(dt.AddDays(1).ToString("yyyy-MM-dd"));
            List<ToolsRecordEntity> list = _ToolRecordRepository.GetAll().Where(e => e.UpdateTime >= qStartTime && e.UpdateTime < qEndTime).OrderBy(e => e.UpdateTime).ToList();
            return ObjectMapper.Map<List<ToolsRecordDto>>(list);
        }
    }
}
