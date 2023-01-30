using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YT.Suofeiya.Alarm;
using YT.Suofeiya.Core.Alarm;
using YT.Suofeiya.Core.PLC;
using YT.Suofeiya.Core.Procedure;
using YT.Suofeiya.Core.Status;
using YT.Suofeiya.Core.Tool;
using YT.Suofeiya.DataAcquistion.Procedure.Dto;
using YT.Suofeiya.DataAcquistion.Status.Dto;
using YT.Suofeiya.Tool.Dto;

namespace YT.Suofeiya.DataAcquistion
{
    class DataAcquistionMapProfile : Profile
    {
        public DataAcquistionMapProfile()
        {
            CreateMap<AcquisitionPointEntity, AcquisitionPointDto>();
            CreateMap<AcquisitionDataEntity, AcquisitionDataDto>();
            CreateMap<AcquisitionDeviceEntity, AcquisitionDeviceDto>();
            CreateMap<StatusRecordEntity, StatusRecordDto>();
            CreateMap<ToolChangeEntity, ToolChangeDto>();
            CreateMap<ProcedureEntity, ProcedureDto>();
            CreateMap<AlarmStatusEntity, AlarmDto>();
            CreateMap<ToolsStatusEntity, ToolDto>();
            CreateMap<ToolsRecordEntity, ToolsRecordDto>();
        }
    }
}
