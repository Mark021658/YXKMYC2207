using System;
using System.Collections.Generic;
using System.Text;

namespace YT.Suofeiya.Order.Dto
{
    public class OrderStatisticsDto
    {
        /// <summary>
        /// 总数量
        /// </summary>
        public int TotalNum { get; set; }

        /// <summary>
        /// 已完工数量
        /// </summary>
        public int CompeletedNum { get; set; }

        /// <summary>
        /// 完成率
        /// </summary>
        public double CompletionRate { get; set; }

        /// <summary>
        /// 不合格数量
        /// </summary>
        public int UnqualifiedNum { get; set; }

        /// <summary>
        /// 不合格率
        /// </summary>
        public double UnqualifiedRate { get; set; }

        public double Rhythm { get; set; }

        public double RemainingTime { get; set; }
    }
}
