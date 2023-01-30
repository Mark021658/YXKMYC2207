using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using YT.Suofeiya.Core.PLC;
using YT.Suofeiya.Core.Procedure;
using YT.Suofeiya.DataAcquistion.Procedure.Dto;

namespace YT.Suofeiya.Order.Dto
{
    public class TaskMapProfile : Profile
    {
        public TaskMapProfile()
        {
            CreateMap<MaterialDto, MaterialEntity>();
            CreateMap<MaterialEntity, MaterialDto>();
            CreateMap<TaskDto, TaskInfoEntity>();
            CreateMap<TaskInfoEntity, TaskDto>();
            CreateMap<TrayDto, TrayEntity>();
            CreateMap<TrayEntity, TrayDto>();
            CreateMap<DoorEntity, DoorDto>();
            CreateMap<TaskFieldEntity, TaskFieldDto>();
            CreateMap<DataMappingEntity, DataMappingDto>();
            CreateMap<TaskFieldDto, TaskFieldEntity>();
            CreateMap<DataMappingDto, DataMappingEntity>();

        }

    }
}
