using System;
using System.Collections.Generic;

namespace AutoNews.Data.Entities
{
    public partial class AppInfo
    {
        public AppInfo()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int AppId { get; set; }

        public string Code { get; set; }

        public string LogoUrl { get; set; }

        public string PackageName { get; set; }

        public string AppName { get; set; }

        public string Version { get; set; }

        public decimal? VersionSize { get; set; }

        public int? VersionCode { get; set; }

        public string AppUrl { get; set; }

        public string Introduction { get; set; }

        public string UpdateLog { get; set; }

        public int? Status { get; set; }

        public int? IsMandatory { get; set; }

        public int? IsEnable { get; set; }

        public string Remarks { get; set; }

        public DateTime? CreateTime { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
