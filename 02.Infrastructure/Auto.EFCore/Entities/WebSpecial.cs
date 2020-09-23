using System;
using System.Collections.Generic;

namespace Auto.EFCore.Entities
{
    public partial class WebSpecial
        : EntityBase
    {
        public WebSpecial()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int SpecialId { get; set; }

        public int? SiteNo { get; set; }

        public string SpecialCode { get; set; }

        public string Name { get; set; }

        public int? DisplayType { get; set; }
        
        public Byte[] RowVers { get; set; }


        #endregion

        #region Generated Relationships

        #endregion

    }
}
