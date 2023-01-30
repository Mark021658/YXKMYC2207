using Abp.Dependency;
using System.Collections.Generic;

namespace YT.WangLi.DataAcquistion.PLC
{
    public interface IAdsHelper : ISingletonDependency
    {
        //void Init(string netID, List<string> variableNames);

        T Read<T>(int AdsIndex, string variableName);

        void Write<T>(int AdsIndex, string variableName, T value);
        bool GetConnectedStatic();
        //void TestConnectedStatic(string variableName);

    }
}
