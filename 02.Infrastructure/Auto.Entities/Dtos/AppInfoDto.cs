using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Entities.Dtos {
    public class AppInfoDto {
        public AppInfoDto() { }

        #region Generated Properties

        /// <summary>
        /// 渠道号
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        public string LogoUrl { get; set; }

        /// <summary>
        /// 程序包名称
        /// </summary>
        public string PackageName { get; set; }

        /// <summary>
        /// app名称
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// 显示版本号
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// 版本code 判断是否更新
        /// </summary>
        public int? VersionCode { get; set; }

        /// <summary>
        /// 版本大小
        /// </summary>
        public decimal? VersionSize { get; set; }

        /// <summary>
        /// app下载地址
        /// </summary>
        public string AppUrl { get; set; }

        /// <summary>
        /// 说明
        /// </summary>
        public string Introduction { get; set; }

        /// <summary>
        /// 更新日志
        /// </summary>
        public string UpdateLog { get; set; }

        /// <summary>
        /// 是否强制更新 （1是，0否）
        /// </summary>
        public int? IsMandatory { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime? UpdateTime { get; set; }
        #endregion
    }
}
