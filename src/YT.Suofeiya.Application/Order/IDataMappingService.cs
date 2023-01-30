using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YT.Suofeiya.Order.Dto;

namespace YT.Suofeiya.Order
{
    public interface IDataMappingService
    {
        List<TaskFieldDto> GetAllField();

        void CreateTaskField(TaskFieldDto dto);

        void UpdateTaskField(TaskFieldDto dto);

        List<TaskFieldDto> GetFieldList(int type);

        List<DataMappingDto> GetAllMapping();

        void CreateMapping(DataMappingDto dto);

        void UpdateMapping(DataMappingDto dto);
    }
}
