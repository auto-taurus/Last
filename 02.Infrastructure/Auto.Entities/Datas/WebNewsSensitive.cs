using Auto.Commons.EfCore;
using System;
using System.Collections.Generic;

namespace Auto.Entities.Datas
{
    public partial class WebNewsSensitive
        : EntityBase
    {
        public WebNewsSensitive()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int NewsSensitiveId { get; set; }

        public int? SiteMark { get; set; }

        public int? NewId { get; set; }

        public string NewTitleRecords { get; set; }

        public string CustomTitleRecords { get; set; }

        public string ContentsRecords { get; set; }


        #endregion

        #region Generated Relationships
        #endregion

    }
}
