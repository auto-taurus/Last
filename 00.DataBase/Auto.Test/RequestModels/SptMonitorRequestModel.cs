using System;
using System.ComponentModel.DataAnnotations;
using NorthwindWebAPI.EntityLayer;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.RequestModels
{
	public class SptMonitorRequestModel
	{
		public DateTime? Lastrun { get; set; }

		public Int32? CpuBusy { get; set; }

		public Int32? IoBusy { get; set; }

		public Int32? Idle { get; set; }

		public Int32? PackReceived { get; set; }

		public Int32? PackSent { get; set; }

		public Int32? Connections { get; set; }

		public Int32? PackErrors { get; set; }

		public Int32? TotalRead { get; set; }

		public Int32? TotalWrite { get; set; }

		public Int32? TotalErrors { get; set; }
	}
}
