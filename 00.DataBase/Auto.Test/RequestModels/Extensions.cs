using System;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.RequestModels
{
	public static class Extensions
	{
		public static MSreplicationOptions ToEntity(this MSreplicationOptionsRequestModel requestModel)
		{
			return new MSreplicationOptions
			{
				Optname = requestModel.Optname,
				Value = requestModel.Value,
				MajorVersion = requestModel.MajorVersion,
				MinorVersion = requestModel.MinorVersion,
				Revision = requestModel.Revision,
				InstallFailures = requestModel.InstallFailures
			};
		}

		public static MSreplicationOptionsRequestModel ToRequestModel(this MSreplicationOptions entity)
		{
			return new MSreplicationOptionsRequestModel
			{
				Optname = entity.Optname,
				Value = entity.Value,
				MajorVersion = entity.MajorVersion,
				MinorVersion = entity.MinorVersion,
				Revision = entity.Revision,
				InstallFailures = entity.InstallFailures
			};
		}

		public static SptFallbackDb ToEntity(this SptFallbackDbRequestModel requestModel)
		{
			return new SptFallbackDb
			{
				XserverName = requestModel.XserverName,
				XdttmIns = requestModel.XdttmIns,
				XdttmLastInsUpd = requestModel.XdttmLastInsUpd,
				XfallbackDbid = requestModel.XfallbackDbid,
				Name = requestModel.Name,
				Dbid = requestModel.Dbid,
				Status = requestModel.Status,
				Version = requestModel.Version
			};
		}

		public static SptFallbackDbRequestModel ToRequestModel(this SptFallbackDb entity)
		{
			return new SptFallbackDbRequestModel
			{
				XserverName = entity.XserverName,
				XdttmIns = entity.XdttmIns,
				XdttmLastInsUpd = entity.XdttmLastInsUpd,
				XfallbackDbid = entity.XfallbackDbid,
				Name = entity.Name,
				Dbid = entity.Dbid,
				Status = entity.Status,
				Version = entity.Version
			};
		}

		public static SptFallbackDev ToEntity(this SptFallbackDevRequestModel requestModel)
		{
			return new SptFallbackDev
			{
				XserverName = requestModel.XserverName,
				XdttmIns = requestModel.XdttmIns,
				XdttmLastInsUpd = requestModel.XdttmLastInsUpd,
				XfallbackLow = requestModel.XfallbackLow,
				XfallbackDrive = requestModel.XfallbackDrive,
				Low = requestModel.Low,
				High = requestModel.High,
				Status = requestModel.Status,
				Name = requestModel.Name,
				Phyname = requestModel.Phyname
			};
		}

		public static SptFallbackDevRequestModel ToRequestModel(this SptFallbackDev entity)
		{
			return new SptFallbackDevRequestModel
			{
				XserverName = entity.XserverName,
				XdttmIns = entity.XdttmIns,
				XdttmLastInsUpd = entity.XdttmLastInsUpd,
				XfallbackLow = entity.XfallbackLow,
				XfallbackDrive = entity.XfallbackDrive,
				Low = entity.Low,
				High = entity.High,
				Status = entity.Status,
				Name = entity.Name,
				Phyname = entity.Phyname
			};
		}

		public static SptFallbackUsg ToEntity(this SptFallbackUsgRequestModel requestModel)
		{
			return new SptFallbackUsg
			{
				XserverName = requestModel.XserverName,
				XdttmIns = requestModel.XdttmIns,
				XdttmLastInsUpd = requestModel.XdttmLastInsUpd,
				XfallbackVstart = requestModel.XfallbackVstart,
				Dbid = requestModel.Dbid,
				Segmap = requestModel.Segmap,
				Lstart = requestModel.Lstart,
				Sizepg = requestModel.Sizepg,
				Vstart = requestModel.Vstart
			};
		}

		public static SptFallbackUsgRequestModel ToRequestModel(this SptFallbackUsg entity)
		{
			return new SptFallbackUsgRequestModel
			{
				XserverName = entity.XserverName,
				XdttmIns = entity.XdttmIns,
				XdttmLastInsUpd = entity.XdttmLastInsUpd,
				XfallbackVstart = entity.XfallbackVstart,
				Dbid = entity.Dbid,
				Segmap = entity.Segmap,
				Lstart = entity.Lstart,
				Sizepg = entity.Sizepg,
				Vstart = entity.Vstart
			};
		}

		public static SptMonitor ToEntity(this SptMonitorRequestModel requestModel)
		{
			return new SptMonitor
			{
				Lastrun = requestModel.Lastrun,
				CpuBusy = requestModel.CpuBusy,
				IoBusy = requestModel.IoBusy,
				Idle = requestModel.Idle,
				PackReceived = requestModel.PackReceived,
				PackSent = requestModel.PackSent,
				Connections = requestModel.Connections,
				PackErrors = requestModel.PackErrors,
				TotalRead = requestModel.TotalRead,
				TotalWrite = requestModel.TotalWrite,
				TotalErrors = requestModel.TotalErrors
			};
		}

		public static SptMonitorRequestModel ToRequestModel(this SptMonitor entity)
		{
			return new SptMonitorRequestModel
			{
				Lastrun = entity.Lastrun,
				CpuBusy = entity.CpuBusy,
				IoBusy = entity.IoBusy,
				Idle = entity.Idle,
				PackReceived = entity.PackReceived,
				PackSent = entity.PackSent,
				Connections = entity.Connections,
				PackErrors = entity.PackErrors,
				TotalRead = entity.TotalRead,
				TotalWrite = entity.TotalWrite,
				TotalErrors = entity.TotalErrors
			};
		}

		public static WebCategory ToEntity(this WebCategoryRequestModel requestModel)
		{
			return new WebCategory
			{
				CategoryId = requestModel.CategoryId,
				SiteId = requestModel.SiteId,
				CategoryName = requestModel.CategoryName,
				ParentId = requestModel.ParentId,
				NodeValue = requestModel.NodeValue,
				Controller = requestModel.Controller,
				Action = requestModel.Action,
				Urls = requestModel.Urls,
				DocumentNumber = requestModel.DocumentNumber,
				AccessNumber = requestModel.AccessNumber,
				ClickNumber = requestModel.ClickNumber,
				Title = requestModel.Title,
				Keywords = requestModel.Keywords,
				Description = requestModel.Description,
				Sequence = requestModel.Sequence,
				IsEnable = requestModel.IsEnable,
				RowVers = requestModel.RowVers,
				Remarks = requestModel.Remarks,
				CreateBy = requestModel.CreateBy,
				CreateTime = requestModel.CreateTime
			};
		}

		public static WebCategoryRequestModel ToRequestModel(this WebCategory entity)
		{
			return new WebCategoryRequestModel
			{
				CategoryId = entity.CategoryId,
				SiteId = entity.SiteId,
				CategoryName = entity.CategoryName,
				ParentId = entity.ParentId,
				NodeValue = entity.NodeValue,
				Controller = entity.Controller,
				Action = entity.Action,
				Urls = entity.Urls,
				DocumentNumber = entity.DocumentNumber,
				AccessNumber = entity.AccessNumber,
				ClickNumber = entity.ClickNumber,
				Title = entity.Title,
				Keywords = entity.Keywords,
				Description = entity.Description,
				Sequence = entity.Sequence,
				IsEnable = entity.IsEnable,
				RowVers = entity.RowVers,
				Remarks = entity.Remarks,
				CreateBy = entity.CreateBy,
				CreateTime = entity.CreateTime
			};
		}

		public static WebNews ToEntity(this WebNewsRequestModel requestModel)
		{
			return new WebNews
			{
				NewsId = requestModel.NewsId,
				SiteId = requestModel.SiteId,
				SpecialCode = requestModel.SpecialCode,
				CategoryId = requestModel.CategoryId,
				CategoryName = requestModel.CategoryName,
				NewsTitle = requestModel.NewsTitle,
				CustomTitle = requestModel.CustomTitle,
				SourceId = requestModel.SourceId,
				Source = requestModel.Source,
				SourceAddress = requestModel.SourceAddress,
				SourceLogo = requestModel.SourceLogo,
				Tags = requestModel.Tags,
				Contents = requestModel.Contents,
				Controller = requestModel.Controller,
				Action = requestModel.Action,
				Urls = requestModel.Urls,
				ImageThums = requestModel.ImageThums,
				ImagePaths = requestModel.ImagePaths,
				DisplayType = requestModel.DisplayType,
				IsHot = requestModel.IsHot,
				Title = requestModel.Title,
				Keywords = requestModel.Keywords,
				Description = requestModel.Description,
				AccessNumber = requestModel.AccessNumber,
				VirtualAccessNumber = requestModel.VirtualAccessNumber,
				ClickNumber = requestModel.ClickNumber,
				Author = requestModel.Author,
				AuditBy = requestModel.AuditBy,
				AuditStatus = requestModel.AuditStatus,
				AuditTime = requestModel.AuditTime,
				PushBy = requestModel.PushBy,
				PushStatus = requestModel.PushStatus,
				PushTime = requestModel.PushTime,
				OperateType = requestModel.OperateType,
				CategorySort = requestModel.CategorySort,
				SingleSort = requestModel.SingleSort,
				Sequence = requestModel.Sequence,
				IsEnable = requestModel.IsEnable,
				RowVers = requestModel.RowVers,
				Remarks = requestModel.Remarks,
				CreateBy = requestModel.CreateBy,
				CreateTime = requestModel.CreateTime
			};
		}

		public static WebNewsRequestModel ToRequestModel(this WebNews entity)
		{
			return new WebNewsRequestModel
			{
				NewsId = entity.NewsId,
				SiteId = entity.SiteId,
				SpecialCode = entity.SpecialCode,
				CategoryId = entity.CategoryId,
				CategoryName = entity.CategoryName,
				NewsTitle = entity.NewsTitle,
				CustomTitle = entity.CustomTitle,
				SourceId = entity.SourceId,
				Source = entity.Source,
				SourceAddress = entity.SourceAddress,
				SourceLogo = entity.SourceLogo,
				Tags = entity.Tags,
				Contents = entity.Contents,
				Controller = entity.Controller,
				Action = entity.Action,
				Urls = entity.Urls,
				ImageThums = entity.ImageThums,
				ImagePaths = entity.ImagePaths,
				DisplayType = entity.DisplayType,
				IsHot = entity.IsHot,
				Title = entity.Title,
				Keywords = entity.Keywords,
				Description = entity.Description,
				AccessNumber = entity.AccessNumber,
				VirtualAccessNumber = entity.VirtualAccessNumber,
				ClickNumber = entity.ClickNumber,
				Author = entity.Author,
				AuditBy = entity.AuditBy,
				AuditStatus = entity.AuditStatus,
				AuditTime = entity.AuditTime,
				PushBy = entity.PushBy,
				PushStatus = entity.PushStatus,
				PushTime = entity.PushTime,
				OperateType = entity.OperateType,
				CategorySort = entity.CategorySort,
				SingleSort = entity.SingleSort,
				Sequence = entity.Sequence,
				IsEnable = entity.IsEnable,
				RowVers = entity.RowVers,
				Remarks = entity.Remarks,
				CreateBy = entity.CreateBy,
				CreateTime = entity.CreateTime
			};
		}

		public static WebSource ToEntity(this WebSourceRequestModel requestModel)
		{
			return new WebSource
			{
				SourceId = requestModel.SourceId,
				CategoryId = requestModel.CategoryId,
				SourceName = requestModel.SourceName,
				SourceLogo = requestModel.SourceLogo,
				FollowNumber = requestModel.FollowNumber,
				Sequence = requestModel.Sequence,
				IsEnable = requestModel.IsEnable,
				Remarks = requestModel.Remarks
			};
		}

		public static WebSourceRequestModel ToRequestModel(this WebSource entity)
		{
			return new WebSourceRequestModel
			{
				SourceId = entity.SourceId,
				CategoryId = entity.CategoryId,
				SourceName = entity.SourceName,
				SourceLogo = entity.SourceLogo,
				FollowNumber = entity.FollowNumber,
				Sequence = entity.Sequence,
				IsEnable = entity.IsEnable,
				Remarks = entity.Remarks
			};
		}
	}
}
