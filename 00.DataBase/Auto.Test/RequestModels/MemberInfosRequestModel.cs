using System;
using System.ComponentModel.DataAnnotations;
using NorthwindWebAPI.EntityLayer;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.RequestModels
{
	public class MemberInfosRequestModel
	{
		[Key]
		public Int32? MemberId { get; set; }

		[StringLength(10)]
		public String Code { get; set; }

		[StringLength(40)]
		public String NickName { get; set; }

		[StringLength(40)]
		public String Name { get; set; }

		public Int32? Sex { get; set; }

		[StringLength(15)]
		public String Phone { get; set; }

		[StringLength(20)]
		public String Alipay { get; set; }

		[StringLength(50)]
		public String Wechat { get; set; }

		[StringLength(100)]
		public String Password { get; set; }

		[StringLength(255)]
		public String Avatar { get; set; }

		public Int32? Beans { get; set; }

		public Int32? BeansTotals { get; set; }

		public DateTime? LastLoginTime { get; set; }

		public Int32? NewsNumber { get; set; }

		public Int32? FollowNumber { get; set; }

		public Int32? FavoritesNumber { get; set; }

		public Int32? FansNumber { get; set; }

		public Int32? IsEnbale { get; set; }

		[StringLength(510)]
		public String Remarks { get; set; }

		public DateTime? CreateTime { get; set; }
	}
}
