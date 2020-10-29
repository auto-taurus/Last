using System;
using System.Collections.Generic;

namespace Master.Domain.Models
{
    public partial class WebNewsUpdateModel
    {
        #region Generated Properties
        public string NewsId { get; set; }

        public int? SiteId { get; set; }

        public string SpecialCode { get; set; }

        public int? CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string NewsTitle { get; set; }

        public string CustomTitle { get; set; }

        public int? SourceId { get; set; }

        public string Source { get; set; }

        public string SourceAddress { get; set; }

        public string SourceLogo { get; set; }

        public string Tags { get; set; }

        public string Contents { get; set; }

        public string Controller { get; set; }

        public string Action { get; set; }

        public string Urls { get; set; }

        public string ImageThums { get; set; }

        public string ImagePaths { get; set; }

        public int? DisplayType { get; set; }

        public int? IsHot { get; set; }

        public string Title { get; set; }

        public string Keywords { get; set; }

        public string Description { get; set; }

        public int? AccessNumber { get; set; }

        public int? VirtualAccessNumber { get; set; }

        public int? ClickNumber { get; set; }

        public int? Author { get; set; }

        public string AuditBy { get; set; }

        public int? AuditStatus { get; set; }

        public DateTime? AuditTime { get; set; }

        public string PushBy { get; set; }

        public int? PushStatus { get; set; }

        public DateTime? PushTime { get; set; }

        public int? OperateType { get; set; }

        public int? CategorySort { get; set; }

        public int? SingleSort { get; set; }

        public int? Sequence { get; set; }

        public int? IsEnable { get; set; }

        public Byte[] RowVers { get; set; }

        public string Remarks { get; set; }

        public int? CreateBy { get; set; }

        public DateTime? CreateTime { get; set; }

        #endregion

    }
}
