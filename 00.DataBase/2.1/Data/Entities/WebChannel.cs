using System;
using System.Collections.Generic;

namespace AutoNews.Data.Entities
{
    public partial class WebChannel
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

        public int? IsEnable { get; set; }

        public Byte[] RowVers { get; set; }

        public string Remarks { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateTime { get; set; }

        #endregion

        #region Generated Relationships
        #endregion

    }
}
