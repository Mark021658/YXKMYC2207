using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YT.Suofeiya.Order.Dto;

namespace YT.Suofeiya.Order
{
    public class MyDataMappingService : SuofeiyaAppServiceBase, IDataMappingService
    {
        void IDataMappingService.CreateMapping(DataMappingDto dto)
        {
            throw new NotImplementedException();
        }

        void IDataMappingService.CreateTaskField(TaskFieldDto dto)
        {
            throw new NotImplementedException();
        }

        List<TaskFieldDto> IDataMappingService.GetAllField()
        {
            return null;
        }

        List<DataMappingDto> IDataMappingService.GetAllMapping()
        {
            throw new NotImplementedException();
        }

        List<TaskFieldDto> IDataMappingService.GetFieldList(int type)
        {
            throw new NotImplementedException();
        }

        void IDataMappingService.UpdateMapping(DataMappingDto dto)
        {
            throw new NotImplementedException();
        }

        void IDataMappingService.UpdateTaskField(TaskFieldDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
