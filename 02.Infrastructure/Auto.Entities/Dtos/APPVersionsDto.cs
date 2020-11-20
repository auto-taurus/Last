using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.Entities.Dtos {
    public class APPVersionsDto {
        public APPVersionsDto() { }

        #region Generated Properties
        public int AppId { get; set; }

        public string Code { get; set; }

        public string LogoUrl { get; set; }

        public string PackageName { get; set; }

        public string AppName { get; set; }

        public string Version { get; set; }

        public decimal? VersionSize { get; set; }

        public string AppUrl { get; set; }

        public string Introduction { get; set; }

        public string UpdateLog { get; set; }

        public int? IsMandatory { get; set; }

        public DateTime? CreateTime { get; set; }
        #endregion
    }
}
