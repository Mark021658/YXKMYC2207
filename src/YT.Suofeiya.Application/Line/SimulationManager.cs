using Abp.Dependency;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT.Suofeiya.Line
{
    public class SimulationManager : ISingletonDependency
    {
        private bool IsSimulation;
        private Dictionary<string, bool> dicSimulation;

        public SimulationManager() 
        {
            IsSimulation = false;
            dicSimulation=new Dictionary<string, bool>();
            dicSimulation.Add("进料1呼叫RGV", false);
            dicSimulation.Add("进料2呼叫RGV", false);
            dicSimulation.Add("托盘上线请求", false);
            dicSimulation.Add("请求工艺数据", false);
            dicSimulation.Add("提交绑定信息", false);
            dicSimulation.Add("异常提报", false);
            dicSimulation.Add("能源提报", false);
        }


        public void SetSimulation(bool IsMoni)
        {
            IsSimulation = IsMoni;
        }

        public bool GetSimulation()
        {
            return IsSimulation;
        }

        public void UpdateSimulationData(string DateName, bool DateValue)
        {
            dicSimulation[DateName] = DateValue;
        }

        public bool GetSimulationData(string DateName)
        {
            return dicSimulation[DateName];
        }
    }
}
