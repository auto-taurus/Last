using System;
using System.ComponentModel.DataAnnotations;
using NorthwindWebAPI.EntityLayer;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.RequestModels
{
	public class MSreplicationOptionsRequestModel
	{
		public object Optname { get; set; }

		public Boolean? Value { get; set; }

		public Int32? MajorVersion { get; set; }

		public Int32? MinorVersion { get; set; }

		public Int32? Revision { get; set; }

		public Int32? InstallFailures { get; set; }
	}
}
