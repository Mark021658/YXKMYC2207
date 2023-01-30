using Abp.Domain.Repositories;
using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YT.Suofeiya.Core.PLC;
using YT.Suofeiya.Core.Procedure;
using YT.Suofeiya.DataAcquistion.Procedure.Dto;
using YT.Suofeiya.Order.Dto;

namespace YT.Suofeiya.Procedure
{
    public class ProcedureAppService : SuofeiyaAppServiceBase, IProcedureAppService
    {
        private readonly IRepository<ProcedureEntity> _nameRepository;
        private readonly IRepository<AcquisitionPointEntity> _pointRepository;
        private readonly IRepository<AcquisitionDeviceEntity> _pointDeviceRepository;
        private readonly IRepository<AcquisitionDataEntity> _pointDataRepository;
        private readonly IRepository<RawResponseDataEntity> _rawResponseDataRepository;

        public ProcedureAppService(IRepository<ProcedureEntity> nameRepository,
            IRepository<AcquisitionDeviceEntity> pointDeviceRepository,
            IRepository<AcquisitionDataEntity> pointDataRepository,
            IRepository<RawResponseDataEntity> rawResponseDataRepository,
            IRepository<AcquisitionPointEntity> pointRepository)
        {
            _nameRepository = nameRepository;
            _pointRepository = pointRepository;
            _pointDeviceRepository = pointDeviceRepository;
            _pointDataRepository = pointDataRepository;
            _rawResponseDataRepository = rawResponseDataRepository;
            Logger = NullLogger.Instance;
        }

        public List<ProcedureDto> GetAll()
        {
            var list = _nameRepository.GetAll().ToList();
            return ObjectMapper.Map<List<ProcedureDto>>(list);
        }

        //所有工序名称
        public List<ProcedureEntity> GetProcedureName()
        {
            return _nameRepository.GetAll().OrderBy(a=>a.ProcedureNo).ToList();
        }

        //所有采集点
        public List<AcquisitionPointDto> GetPointName()
        {
            List<AcquisitionPointEntity> list = _pointRepository.GetAll().OrderBy(a => a.AcquisitionPointNo).ToList();
            return ObjectMapper.Map<List<AcquisitionPointDto>>(list);

            //throw new NotImplementedException();
        }

        public List<AcquisitionDeviceDto> GetPointDeviceList()
        {
            List<AcquisitionDeviceEntity> list = _pointDeviceRepository.GetAll().ToList();
            return ObjectMapper.Map<List<AcquisitionDeviceDto>>(list);
        }

        public List<AcquisitionDataDto> GetPointDataList()
        {
            List<AcquisitionDataEntity> list = _pointDataRepository.GetAll().OrderBy(a => a.AcquisitionPointNo).ToList();
            return ObjectMapper.Map<List<AcquisitionDataDto>>(list);

        }

        // 维护采集点
        public void createPoint(AcquisitionPointDto dto)
        {
            AcquisitionPointEntity point = new AcquisitionPointEntity
            {
                AcquisitionPointNo = dto.AcquisitionPointNo,
                AcquisitionDeviceNo = dto.AcquisitionDeviceNo,
                PointName = dto.PointName,
                PointDesc = dto.PointDesc,
                AcquisitionIndex = dto.AcquisitionIndex,
                ProcedureType = dto.ProcedureType
            };
            _pointRepository.Insert(point);
        }


        public void updatePoint(AcquisitionPointDto dto)
        {
            AcquisitionPointEntity point = _pointRepository.FirstOrDefault(e => e.Id == dto.Id);
            point.AcquisitionPointNo = dto.AcquisitionPointNo;
            point.PointName = dto.PointName;
            point.PointDesc = dto.PointDesc;
            point.AcquisitionIndex = dto.AcquisitionIndex;
            point.ProcedureType = dto.ProcedureType;
            point.AcquisitionDeviceNo = dto.AcquisitionDeviceNo;
            _pointRepository.Update(point);
        }

        public void createPointData(AcquisitionDataDto dto)
        {
            AcquisitionDataEntity data = new AcquisitionDataEntity { 
                AcquisitionPointNo = dto.AcquisitionPointNo,
                StartAddr = dto.StartAddr,
                Words = dto.Words,
                DataType = dto.DataType
            };
            _pointDataRepository.Insert(data);
        }

        public void updatePointData(AcquisitionDataDto dto)
        {
            AcquisitionDataEntity data = _pointDataRepository.FirstOrDefault(e=>e.Id == dto.Id);
            data.AcquisitionPointNo = dto.AcquisitionPointNo;
            data.StartAddr = dto.StartAddr;
            data.Words = dto.Words;
            data.DataType = dto.DataType;
            _pointDataRepository.Update(data);
        }

        public void createPoitDevice(AcquisitionDeviceDto dto)
        {
            AcquisitionDeviceEntity device = new AcquisitionDeviceEntity
            {
                CommunicationMode = dto.CommunicationMode,
                AcquisitionDeviceIndex = dto.AcquisitionDeviceIndex,
                AcquisitionDeviceNo = dto.AcquisitionDeviceNo,
                Name = dto.Name,
                IP = dto.IP,
                Port = dto.Port,
                Desc = dto.Desc
            };
            _pointDeviceRepository.Insert(device);
        }

        public void updatePointDevice(AcquisitionDeviceDto dto)
        {
            AcquisitionDeviceEntity device = _pointDeviceRepository.FirstOrDefault(e=> e.Id == dto.Id);
            device.CommunicationMode = dto.CommunicationMode;
            device.AcquisitionDeviceIndex = dto.AcquisitionDeviceIndex;
            device.AcquisitionDeviceNo = dto.AcquisitionDeviceNo;
            device.Name = dto.Name;
            device.IP = dto.IP;
            device.Port = dto.Port;
            device.Desc = dto.Desc;

            _pointDeviceRepository.Update(device);
        }

    }
}
