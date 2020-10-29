using System;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.EntityLayer
{
	public partial class MemberFavorites : IEntity
	{
		public MemberFavorites()
		{
		}

		public MemberFavorites(Int32? favoritesId)
		{
			FavoritesId = favoritesId;
		}

		public Int32? FavoritesId { get; set; }

		public Int32? MemberId { get; set; }

		public String SourceId { get; set; }

		public String SourceTable { get; set; }

		public DateTime? FavoritesTime { get; set; }

		public Int32? IsEnable { get; set; }

		public String Remarks { get; set; }

		public MemberInfos MemberInfosFk { get; set; }
	}
}
