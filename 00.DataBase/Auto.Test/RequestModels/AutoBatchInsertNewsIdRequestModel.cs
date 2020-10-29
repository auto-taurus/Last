using System;
using System.ComponentModel.DataAnnotations;
using NorthwindWebAPI.EntityLayer;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.RequestModels
{
	public class AutoBatchInsertNewsIdRequestModel
	{
		[Key]
		public Int32? Id { get; set; }

		public Int32? NewsId { get; set; }

		public String Message { get; set; }
	}
}
