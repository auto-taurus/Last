using System;
using System.Collections.Generic;

namespace AutoNews.Domain.Models
{
    public partial class WebCategoryCreateModel
    {
        #region Generated Properties
        public int CategoryId { get; set; }

        public int? SiteId { get; set; }

        public string CategoryName { get; set; }

        public int? ParentId { get; set; }

        public string NodeValue { get; set; }

        public string Controller { get; set; }

        public string Action { get; set; }

        public string Urls { get; set; }

        public int? DocumentNumber { get; set; }

        public int? AccessNumber { get; set; }

        public int? ClickNumber { get; set; }

        public string Title { get; set; }

        public string Keywords { get; set; }

        public string Description { get; set; }

        public int? Sequence { get; set; }

        public int? IsEnable { get; set; }

        public Byte[] RowVers { get; set; }

        public string Remarks { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateTime { get; set; }

        #endregion

    }
}
