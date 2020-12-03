using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Entities.Dtos {
    public class FixdeIncomeDto {
        /// <summary>
        /// 收入记录编号
        /// </summary>
        public int IncomeId { get; set; }
        /// <summary>
        /// 任务名称
        /// </summary>
        public string TaskName { get; set; }
        /// <summary>
        /// 任务代码
        /// </summary>
        public string TaskCode { get; set; }
        /// <summary>
        /// 日常任务分类
        /// </summary>
        public int? CategoryDay { get; set; }
        /// <summary>
        /// 每日固定分类
        /// </summary>
        public int? CategoryFixed { get; set; }
        /// <summary>
        /// 收入显示文本
        /// </summary>
        public string BeansText { get; set; }
        /// <summary>
        /// 显示标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 收入收入时间
        /// </summary>
        public DateTime? CreateTime { get; set; }
    }
}
