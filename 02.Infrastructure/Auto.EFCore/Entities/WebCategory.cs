using System;
using System.Collections.Generic;

namespace Auto.EFCore.Entities
{
    public partial class WebCategory
        : EntityBase
    {
        public WebCategory()
        {
            #region Generated Constructor
            WebNews = new HashSet<WebNews>();
            #endregion
        }

        #region Generated Properties
        public int CategoryId { get; set; }

        public int? SiteNo { get; set; }

        public string CategoryName { get; set; }

        public int? ParentId { get; set; }

        public string NodeValue { get; set; }

        public string Controller { get; set; }

        public string Action { get; set; }

        public string Urls { get; set; }

        public int? DocumentNumber { get; set; }

        public int? VirtualAccessNumber { get; set; }

        public int? AccessNumber { get; set; }

        public int? ClickNumber { get; set; }

        public string Title { get; set; }

        public string Keywords { get; set; }

        public string Description { get; set; }

        public int? Sequence { get; set; }

        public Byte[] RowVers { get; set; }

        #endregion

        #region Generated Relationships
        public virtual ICollection<WebNews> WebNews { get; set; }

        #endregion

    }
}
