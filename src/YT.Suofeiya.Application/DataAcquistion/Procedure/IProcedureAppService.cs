using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YT.Suofeiya.Core.PLC;
using YT.Suofeiya.Core.Procedure;
using YT.Suofeiya.DataAcquistion.Procedure.Dto;

namespace YT.Suofeiya.Procedure
{
    public interface IProcedureAppService
    {
        List<ProcedureDto> GetAll();
        List<AcquisitionPointDto> GetPointName();

        List<AcquisitionDeviceDto> GetPointDeviceList();

        List<AcquisitionDataDto> GetPointDataList();

        void createPoint(AcquisitionPointDto dto);

        void updatePoint(AcquisitionPointDto dto);

        void createPointData(AcquisitionDataDto dto);

        void updatePointData(AcquisitionDataDto dto);

        void createPoitDevice(AcquisitionDeviceDto dto);

        void updatePointDevice(AcquisitionDeviceDto dto);
    }
}
