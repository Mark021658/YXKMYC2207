using Abp.Dependency;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YT.Suofeiya.Core.Status;

namespace YT.Suofeiya.Core.StatusManager
{
    public interface ICheckStatus : ISingletonDependency
    {
        Task<bool> UpdateAsync(StatusEntity preStateInfo, StatusEntity curStateInfo);
    }
}
