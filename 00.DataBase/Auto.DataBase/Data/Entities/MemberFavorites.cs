using System;
using System.Collections.Generic;

namespace AutoNews.Data.Entities
{
    public partial class MemberFavorites
    {
        public MemberFavorites()
        {
            #region Generated Constructor
            #endregion
        }

        #region Generated Properties
        public int FavoritesId { get; set; }

        public int? MemberId { get; set; }

        public string SourceId { get; set; }

        public string SourceTable { get; set; }

        public DateTime? FavoritesTime { get; set; }

        public int? IsEnable { get; set; }

        public string Remarks { get; set; }

        #endregion

        #region Generated Relationships
        public virtual MemberInfos MemberInfos { get; set; }

        #endregion

    }
}
