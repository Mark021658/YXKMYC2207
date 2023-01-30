using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using YT.Suofeiya.Core.Tool;
using YT.Suofeiya.Tool.Dto;

namespace YT.Suofeiya.Tool
{
    public interface IToolAppService 
    {
        Task<ToolStatisticsDto> GetToolStatistics();
        void Update(int AcquisitionNo, int ToolNo, string ToolName, int presettingCount);
        void Clear(int id, string name, string remarks, bool isClear = false);

        List<ToolDto> GetTools(int plcNo);

        List<ToolChangeDto> GetToolChangeRecord(DateTime startTime, DateTime endTime);

        List<ToolDto> GetAll();

        void createTool(ToolDto dto);

        void updateTool(ToolDto dto);

        List<ToolsRecordDto> GetAllTool(DateTime dt);
    }
}
