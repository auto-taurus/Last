using System;
using System.Collections.Generic;

namespace Auto.EFCore.Entities
{
    public partial class WebChannel
        : EntityBase
    {
        public WebChannel()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int ChannelId { get; set; }

        public int? SiteNo { get; set; }

        public string ChannelName { get; set; }

        public string ChannelAddress { get; set; }

        public string ChannelJs { get; set; }
        
        public Byte[] RowVers { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
