using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Entities.Dtos {
    public class TaskInfoDto {
        /// <summary>
        /// 任务编号
        /// </summary>
        public int TaskId { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        public string TaskName { get; set; }

        /// <summary>
        /// 任务代码
        /// </summary>
        public string TaskCode { get; set; }

        /// <summary>
        /// 任务简要描述（展示描述）
        /// </summary>
        public string ShowDesc { get; set; }

        /// <summary>
        /// 任务列表显示奖励文本
        /// </summary>
        public string BeansText { get; set; }

        /// <summary>
        /// 任务列表显示奖励文本额外提示
        /// </summary>
        public string Tips { get; set; }

        /// <summary>
        /// 日常任务分类
        /// </summary>
        public int? CategoryDay { get; set; }

        /// <summary>
        /// 显示图标类型（0默认，1红包）
        /// </summary>
        public int? IconType { get; set; }

        /// <summary>
        /// 跳转类型（0默认，1跳转站内新闻，2跳转站内视频，3跳转网页，4分享,5 ）
        /// </summary>
        public int? JumpType { get; set; }

        /// <summary>
        /// 跳转自定义显示标题
        /// </summary>
        public string JumpTitle { get; set; }

        /// <summary>
        /// 跳转地址
        /// </summary>
        public string JumpUrl { get; set; }

        /// <summary>
        /// 阅读次数
        /// </summary>
        public int? AlreadyNumber { get; set; }

        /// <summary>
        /// 上限次数
        /// </summary>
        public int? UpperNumber { get; set; }

        /// <summary>
        /// 上限奖励
        /// </summary>
        public int? UpperBeans { get; set; }
    }
}
