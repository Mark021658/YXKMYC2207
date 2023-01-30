using Abp.Dependency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT.Suofeiya.DataAcquistion.PLC
{
    public interface IAdsHelper : ISingletonDependency
    {
        void Init(string netID, List<string> variableNames);

        T Read<T>(string variableName);

        void Write<T>(string variableName, T value);
        bool GetConnectedStatic();
        void TestConnectedStatic(string variableName);

    }
}
