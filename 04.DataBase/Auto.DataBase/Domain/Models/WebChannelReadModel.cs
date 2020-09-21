using System;
using System.Collections.Generic;

namespace Company.AutoNews.Domain.Models
{
    public partial class WebChannelReadModel
        : EntityReadModel
    {
        #region Generated Properties
        public int ChannelId { get; set; }

        public int? SiteNo { get; set; }

        public string ChannelName { get; set; }

        public string ChannelAddress { get; set; }

        public string ChannelJs { get; set; }

        public int? IsEnable { get; set; }

        public Byte[] Timestamp { get; set; }

        public string Remarks { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateTime { get; set; }

        #endregion

    }
}
