using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YT.Suofeiya.Order.Dto;

namespace YT.Suofeiya.Order
{
    public class DataMappingService : SuofeiyaAppServiceBase, IDataMappingService
    {
        private readonly IRepository<DataMappingEntity> _dataMappingRepo;
        private readonly IRepository<TaskFieldEntity> _taskFieldRepo;

        public DataMappingService(IRepository<DataMappingEntity> dataMappingRepo, IRepository<TaskFieldEntity> taskFieldRepo)
        {
            _dataMappingRepo = dataMappingRepo;
            _taskFieldRepo = taskFieldRepo;
        }

        void IDataMappingService.CreateMapping(DataMappingDto dto)
        {
            DataMappingEntity entity = ObjectMapper.Map<DataMappingEntity>(dto);

            _dataMappingRepo.InsertAsync(entity);
        }

        void IDataMappingService.CreateTaskField(TaskFieldDto dto)
        {
            TaskFieldEntity entity = ObjectMapper.Map<TaskFieldEntity>(dto);
            _taskFieldRepo.InsertAsync(entity);
        }

        List<TaskFieldDto> IDataMappingService.GetAllField()
        {
            var list = _taskFieldRepo.GetAllList();
            return ObjectMapper.Map<List<TaskFieldDto>>(list);
        }

        List<DataMappingDto> IDataMappingService.GetAllMapping()
        {
            var list = _dataMappingRepo.GetAllList();
            return ObjectMapper.Map<List<DataMappingDto>>(list);
        }

        List<TaskFieldDto> IDataMappingService.GetFieldList(int type)
        {
            List<TaskFieldEntity> list = _taskFieldRepo.GetAll().Where(e => e.Type == type).ToList();
            return ObjectMapper.Map<List<TaskFieldDto>>(list);
        }

        void IDataMappingService.UpdateMapping(DataMappingDto dto)
        {
            DataMappingEntity entity = new DataMappingEntity
            {
                Id = dto.Id,
                SourceField = dto.SourceField,
                SourceValue = dto.SourceValue,
                SourceDesc = dto.SourceDesc,
                DestField = dto.DestField,
                DestValue = dto.DestValue,
                DestDesc = dto.DestDesc
            };

            _dataMappingRepo.UpdateAsync(entity);
        }

        void IDataMappingService.UpdateTaskField(TaskFieldDto dto)
        {
            TaskFieldEntity entity = new TaskFieldEntity
            {
                Id = dto.Id,
                Name = dto.Name,
                Code = dto.Code,
                Type = dto.Type
            };
            _taskFieldRepo.UpdateAsync(entity);
        }
    }
}
