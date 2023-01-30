using Abp.Dependency;
using Abp.Domain.Repositories;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YT.Suofeiya.DataAcquistion.PLC;

namespace YT.Suofeiya.Order
{
    public class TrayManager: ISingletonDependency
    {
        private readonly IRepository<TrayPointEntity> _trayPointRepository;
        private readonly IRepository<TrayEntity> _trayRepository;
        private readonly IRepository<TrayMaterialShip > _trayTaskShipRepository;

        // 每个点存放的托盘号
        private Dictionary<int, int> _dictTrayPoint = new Dictionary<int, int>();
     
        public TrayManager(IRepository<TrayPointEntity> trayPointRepository,
            IRepository<TrayEntity> trayRepository,
            IRepository<TrayMaterialShip > trayTaskShipRepository)
        {
            _trayPointRepository = trayPointRepository;
            _trayRepository = trayRepository;
            _trayTaskShipRepository = trayTaskShipRepository;
        }

        /// <summary>
        /// 扫码获取托盘信息。
        /// </summary>
        /// <param name="pointNo">站点</param>
        /// <param name="TrayNo">托盘号</param>
        /// <param name="doorIdList">门id</param>
        /// <returns></returns>
        public async Task AddInTrayAsync(int pointNo, TrayEntity tray, List<TrayMaterialShip> ships)
        {
            await _trayRepository.DeleteAsync(q => q.PalletCode == tray.PalletCode);

            await _trayTaskShipRepository.DeleteAsync(q => q.PalletCode == tray.PalletCode);

            await _trayRepository.InsertOrUpdateAsync(tray);

            await TrayBindingMaterialsAsync(ships);

            // 绑定站点与托盘信息
            var trayPoint = await _trayPointRepository.FirstOrDefaultAsync(q=>q.PointNo == pointNo);
            trayPoint.PalletCode = tray.PalletCode;
            _trayPointRepository.Update(trayPoint);
        }

        public async Task AddOutTrayAsync(int pointNo, TrayEntity tray)
        {
            await _trayRepository.DeleteAsync(q => q.PalletCode == tray.PalletCode);

            await _trayTaskShipRepository.DeleteAsync(q => q.PalletCode == tray.PalletCode);

            await _trayRepository.InsertOrUpdateAsync(tray);

            // 绑定站点与托盘信息
            var trayPoint = await _trayPointRepository.FirstOrDefaultAsync(q => q.PointNo == pointNo);
            trayPoint.PalletCode = tray.PalletCode;
            _trayPointRepository.Update(trayPoint);
        }

        public async Task AddOutTrayTaskInfoAsync(int pointNo, string doorId)
        {
            var trayPoint = await _trayPointRepository.FirstOrDefaultAsync(q => q.PointNo == pointNo);

            var tray = await _trayRepository.FirstOrDefaultAsync(q => q.PalletCode == trayPoint.PalletCode);

            if(tray == null)
            {
                throw new UserFriendlyException("出料口托盘为扫码");
            }

            _trayTaskShipRepository.Insert(
                    new TrayMaterialShip ()
                    {
                        PalletCode = trayPoint.PalletCode,
                        MaterialCode = doorId,
                    }
                );
        }

        /// <summary>
        /// 托盘绑定物料
        /// </summary>
        /// <param name="trayNo"></param>
        /// <param name="trayMaterialShips"></param>
        /// <returns></returns>
        public async Task TrayBindingMaterialsAsync(List<TrayMaterialShip> trayMaterialShips)
        {
            // 校验订单数据

            // 绑定托盘与物料信息

            // 先校验
            foreach (var ship in trayMaterialShips)
            {
                _trayTaskShipRepository.Insert(
                    ship
                );
            }

            //return null;
        }
        /// <summary>
        /// 根据站点获取托盘
        /// </summary>
        /// <param name="pointNo"></param>
        /// <returns></returns>
        public async Task<TrayEntity> GetTrayAsync(int pointNo)
        {
            var trayPointEntity = await _trayPointRepository.FirstOrDefaultAsync(q => q.PointNo == pointNo);

            return await _trayRepository.FirstOrDefaultAsync(q=>q.PalletCode == trayPointEntity.PalletCode);
        }

        public async Task<List<TrayMaterialShip >> GetTrayTaskIdsAsync(int pointNo)
        {
            var trayPointEntity = await _trayPointRepository.FirstOrDefaultAsync(q => q.PointNo == pointNo);

            return _trayTaskShipRepository.GetAllList().Where(q => q.PalletCode == trayPointEntity.PalletCode).ToList();
        }

        /// <summary>
        /// 获取托盘点
        /// </summary>
        /// <param name="pointNo"></param>
        /// <returns></returns>
        public TrayPointEntity GetTrayPoint(int pointNo)
        {
            return _trayPointRepository.FirstOrDefault(q => q.PointNo == pointNo);
        }

        //根据设备号信息获取托盘点 
        public TrayPointEntity GetTrayPointByDeveiceNo(int DeveiceNo)
        {
            return _trayPointRepository.FirstOrDefault(q => q.DeviceNo == DeveiceNo);
        }

        /// <summary>
        /// 获取设置当前上料点
        /// </summary>
        /// <param name="pointNo"></param>
        /// <returns></returns>

        public TrayPointEntity GetFeedPoint(int pointNo)
        {
            var points = _trayPointRepository.GetAllList();

            // 遍历两遍 第一遍
            // 获取当前正在使用的托盘点
            foreach (var point in points.Where(p=>p.PointNo == 100 || p.PointNo == 101) )
            {
                if (point.IsUsed)
                {
                    return point;
                }
            }

            // 获取可以使用的托盘点
            foreach (var point in points.Where(p => p.PointNo == 100 || p.PointNo == 101))
            {
                if (point.IsEnable)
                {
                    
                    point.IsUsed = true;

                    return point;
                }
            }

            // 如果没有可使用的， 返回60#上料口
            //var Defultpoint = points.FirstOrDefault(p => p.PointNo == 100 );
            return null;
        }
        /// <summary>
        /// 获取当前上料点
        /// </summary>
        /// <param name="pointNo"></param>
        /// <returns></returns>

        public int GetFeedPoint()
        {
            var points = _trayPointRepository.GetAllList();

            // 遍历两遍 第一遍
            // 获取当前正在使用的托盘点
            foreach (var point in points.Where(p => p.PointNo == 100 || p.PointNo == 101))
            {
                if (point.IsUsed)
                {
                    return point.PointNo;
                }
            }

            // 如果没有可使用的， 返回60#上料口
            //var Defultpoint = points.FirstOrDefault(p => p.PointNo == 100 );
            return 0;
        }

        public List<TrayPointEntity> GetAllTrayInPoints()
        {
            return _trayPointRepository.GetAll().Where(q=>q.PointType ==0).ToList();
        }

        public TrayPointEntity GetTrayOutPoint()
        {
            return _trayPointRepository.FirstOrDefault(q => q.PointType == 1);
        }
    }
}
