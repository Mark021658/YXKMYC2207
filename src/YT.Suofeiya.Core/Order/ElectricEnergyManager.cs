using Abp.Dependency;
using Abp.Domain.Repositories;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YT.Suofeiya.DataAcquistion.Energy;
using YT.Suofeiya.DataAcquistion.PLC;

namespace YT.Suofeiya.Order
{
    public class ElectricEnergyManager : ISingletonDependency
    {
        private readonly IRepository<ElectricEnergyEntity> _ElectricEnergyRepository;
        //private readonly IRepository<TrayEntity> _trayRepository;
        //private readonly IRepository<TrayMaterialShip > _trayTaskShipRepository;
        //private readonly IAdsHelper _adsHelper;

        // 每个点存放的托盘号
        private ElectricEnergyEntity CurrentEnergy = new ElectricEnergyEntity();
     
        public ElectricEnergyManager(IRepository<ElectricEnergyEntity> ElectricEnergyRepository//,
            //IRepository<TrayEntity> trayRepository,
            //IRepository<TrayMaterialShip > trayTaskShipRepository,
            //IAdsHelper adsHelper 
            )
        {
            _ElectricEnergyRepository = ElectricEnergyRepository;
            //_trayRepository = trayRepository;
            //_trayTaskShipRepository = trayTaskShipRepository;
            //_adsHelper = adsHelper;
        }

        /// <summary>
        /// 扫码获取托盘信息。
        /// </summary>
        /// <param name="pointNo">站点</param>
        /// <param name="TrayNo">托盘号</param>
        /// <param name="doorIdList">门id</param>
        /// <returns></returns>
        public async Task AddElectricEnergyAsync( ElectricEnergyEntity ElectricEnergys)
        { 
            _ElectricEnergyRepository.Insert(ElectricEnergys);
            CurrentEnergy = ElectricEnergys;
        } 

        public List<ElectricEnergyEntity> GetAllEnergys()
        {
            return _ElectricEnergyRepository.GetAllList().Where(q => q.IsReport== false).ToList();//.Where(q=>q.PointType ==0).ToList();
        }

        public ElectricEnergyEntity GetCurrentStatic()
        {
            return CurrentEnergy;
        }

    }
}
