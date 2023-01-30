using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YT.Suofeiya.DataAcquistion.Procedure.Dto;
using YT.Suofeiya.Order.Dto;

namespace YT.Suofeiya.Order
{
    public interface IDoorManager
    {
        List<DoorDto> GetAllDoor();

        List<DoorDto> GetAllDoor(DateTime dt);

        List<ProcedureDto> GetProcedureList(int doorId);

        DoorDto GetDoorInfo(int doorId);

        TaskDto GetTaskInfo(int doorId);
    }
}
