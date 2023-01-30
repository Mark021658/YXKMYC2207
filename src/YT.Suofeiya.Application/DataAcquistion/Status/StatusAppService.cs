using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using AutoMapper;
//using AutoMapper;
//using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using YT.Suofeiya.Core.Alarm;
using YT.Suofeiya.Core.PLC;
using YT.Suofeiya.Core.Status;
using YT.Suofeiya.Core.StatusManager;
using YT.Suofeiya.Core.Tool;
using YT.Suofeiya.DataAcquistion.Energy;
using YT.Suofeiya.DataAcquistion.Status.Dto;
using YT.Suofeiya.Line;
using YT.Suofeiya.Order;

namespace YT.Suofeiya.Status
{
    public class StatusAppService : SuofeiyaAppServiceBase, IStatusAppService
    {
        private readonly IRepository<AcquisitionDataEntity> _registersRepository;

        private readonly StatusManager _statusManger;

        private readonly IMapper _autoMapper;
        private readonly IRepository<ToolsStatusEntity> _toolRepository;
        private readonly ElectricEnergyManager _EnergyManager;
        private readonly LineParamManager _lineParamManager;
        private readonly IRepository<StatusRecordEntity> _statusRecordRepository;

        public StatusAppService(IRepository<AcquisitionDataEntity> registersRepository, 
            StatusManager statusManger,
            IRepository<ToolsStatusEntity> toolRepository,
            IMapper autoMapper,
            ElectricEnergyManager EnergyManager,
            IRepository<StatusRecordEntity> statusRecordRepository,
            LineParamManager lineParamManager)
        {
            _registersRepository = registersRepository;
            _statusManger = statusManger;
            _autoMapper = autoMapper;
            _toolRepository = toolRepository;
            _EnergyManager = EnergyManager;
            _lineParamManager = lineParamManager;
            _statusRecordRepository = statusRecordRepository;
        }

        public Dictionary<int, StatusEntity> GetCurStatus()
        {
            //_autoMapper.Map<List<AlarmDto>>(_infoRepository.GetAll().
            return _statusManger.GetCurStatus();
        }

        public Dictionary<int, List<AlarmStatusEntity>> GetCurAlarm()
        {
            return _statusManger.GetCurAlarm();
        }

        public Dictionary<int, List<ToolsStatusEntity>> GetCurTool()
        {
            Dictionary<int, List<ToolsStatusEntity>> _dicTool = new Dictionary<int, List<ToolsStatusEntity>>();
            List<ToolsStatusEntity> toolInfos = _toolRepository.GetAllList();
            foreach (ToolsStatusEntity toolEntity in toolInfos)
            {
                if (_dicTool.ContainsKey(toolEntity.AcquisitionPointNo))
                {
                    _dicTool[toolEntity.AcquisitionPointNo].Add(toolEntity);
                }
                else
                {
                    List<ToolsStatusEntity> dictTmp = new List<ToolsStatusEntity>
                    {
                        toolEntity
                    };
                    _dicTool.Add(toolEntity.AcquisitionPointNo, dictTmp);
                }

            }
            return _dicTool;
            //return _statusManger.GetCurTool();
        }

        public void Clear()
        {
            _statusManger.Clear();
        }


        public ElectricEnergyEntity GetEnergyStatus()
        {
            return _EnergyManager.GetCurrentStatic(); 
        }
        public bool GetMESstatus()
        {
            // LineEntity LineParm = _lineParamManager.GetLineParam();
            // var responseData = _webServiceClient.SEND_CMD17_LIFE_BEAT(requestData17);
            return false;
        }

        public List<StatusRecordDto> GetStatusRecords(DateTime startTime, DateTime endTime) 
        {
            startTime = Convert.ToDateTime(startTime.ToString("yyyy-MM-dd"));
            endTime = Convert.ToDateTime(endTime.ToString("yyyy-MM-dd"));

            List<StatusRecordEntity> records = new List<StatusRecordEntity>();

            records = _statusRecordRepository.GetAll().Where(q => q.UpdateDate > startTime && q.UpdateDate < endTime).OrderBy(q => q.AcquisitionPointNo).ToList();

            return ObjectMapper.Map<List<StatusRecordDto>>(records);
        }
    }
}
