using Abp.Dependency;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YT.Suofeiya.Core.PLC;

namespace YT.Suofeiya.DataAcquistion.PLC
{
    public class AcquistionDeviceStore : ITransientDependency
    {
        private readonly IRepository<AcquisitionDeviceEntity> _devRepository;

        public AcquistionDeviceStore(IRepository<AcquisitionDeviceEntity> devRepository)
        {
            _devRepository = devRepository;
        }

        /// <summary>
        /// 获取所有扫描平台通讯参数
        /// </summary>
        /// <returns></returns>
        public List<AcquisitionDeviceEntity> GetScanTcp()
        {
            return _devRepository.GetAllList().Where(q => q.CommunicationMode == EnumCommunicationMode.TCP).ToList();
        }

        /// <summary>
        /// 获取所有手持式扫码枪通讯参数
        /// </summary>
        /// <returns></returns>
        public List<AcquisitionDeviceEntity> GetScanSerial()
        {
            return _devRepository.GetAllList().Where(q => q.CommunicationMode == EnumCommunicationMode.SerialPort).ToList();
        }

        /// <summary>
        /// 获取倍福通讯参数
        /// </summary>
        /// <returns></returns>
        public AcquisitionDeviceEntity GetBeifu()
        {
            return _devRepository.FirstOrDefault(q=>q.CommunicationMode== EnumCommunicationMode.Beifu);
        }

        /// <summary>
        /// 获取电表通讯参数
        /// </summary>
        /// <returns></returns>
        public AcquisitionDeviceEntity GetEnergy()
        {
            return _devRepository.FirstOrDefault(q => q.CommunicationMode == EnumCommunicationMode.ModbusTcp);
        }

        /// <summary>
        /// 获取Mes通讯参数
        /// </summary>
        /// <returns></returns>
        public AcquisitionDeviceEntity GetMes()
        {
            return _devRepository.FirstOrDefault(q => q.CommunicationMode == EnumCommunicationMode.Mes);
        }


        public void SetConnectStatus()
        {
            //AcquistionDeviceNo
        }
    }
}
