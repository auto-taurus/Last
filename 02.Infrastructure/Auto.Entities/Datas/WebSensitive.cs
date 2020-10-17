using Auto.Commons.EfCore;
using System;
using System.Collections.Generic;

namespace Auto.Entities.Datas
{
    public partial class WebSensitive
        : EntityBase
    {
        public WebSensitive()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int SensitiveId { get; set; }

        public int? SiteId { get; set; }

        public int? Type { get; set; }

        public string TypeText { get; set; }

        public string SensitiveWords { get; set; }

        public string Author { get; set; }

        public string Urls { get; set; }

        public Byte[] RowVers { get; set; }
        
        #endregion

        #region Generated Relationships
        #endregion

    }
}
