using Auto.Commons.EfCore;
using System;
using System.Collections.Generic;

namespace Auto.Entities.Modals {
    public partial class WebNews
        : EntityBase {
        public WebNews() {
            #region Generated Constructor
            WebNewsOperateLogs = new HashSet<WebNewsOperateLogs>();
            MemberComments = new HashSet<MemberComment>();
            #endregion
        }

        #region Generated Properties
        public string NewsId { get; set; }

        public int? SiteId { get; set; }

        public string SpecialCode { get; set; }

        public int? CategoryId { get; set; }

        public string CategoryName { get; set; }

        public int? ContentType { get; set; }

        public string NewsTitle { get; set; }

        public string CustomTitle { get; set; }

        public int SourceId { get; set; }

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

        public string Author { get; set; }

        public int? AuditBy { get; set; }

        public int? AuditStatus { get; set; }

        public DateTime? AuditTime { get; set; }
        public int? PushBy { get; set; }

        public int? PushStatus { get; set; }

        public DateTime? PushTime { get; set; }

        public int? OperateType { get; set; }

        public int? CategorySort { get; set; }

        public int? SpecialSort { get; set; }

        public int? Sequence { get; set; }

        public Byte[] RowVers { get; set; }

        #endregion

        #region Generated Relationships
        public virtual WebCategory WebCategory { get; set; }

        public virtual ICollection<WebNewsOperateLogs> WebNewsOperateLogs { get; set; }
        public virtual ICollection<MemberComment> MemberComments { get; set; }

        public virtual WebSource WebSource { get; set; }
        #endregion

    }
}
