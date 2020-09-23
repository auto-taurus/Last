using System;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.RequestModels
{
	public static class Extensions
	{
		public static AutoBatchInsertNewsId ToEntity(this AutoBatchInsertNewsIdRequestModel requestModel)
		{
			return new AutoBatchInsertNewsId
			{
				Id = requestModel.Id,
				NewsId = requestModel.NewsId,
				Message = requestModel.Message
			};
		}

		public static AutoBatchInsertNewsIdRequestModel ToRequestModel(this AutoBatchInsertNewsId entity)
		{
			return new AutoBatchInsertNewsIdRequestModel
			{
				Id = entity.Id,
				NewsId = entity.NewsId,
				Message = entity.Message
			};
		}

		public static ReportCategoryDayAccess ToEntity(this ReportCategoryDayAccessRequestModel requestModel)
		{
			return new ReportCategoryDayAccess
			{
				CategoryAccessId = requestModel.CategoryAccessId,
				CategoryId = requestModel.CategoryId,
				CategoryName = requestModel.CategoryName,
				Count = requestModel.Count,
				Today = requestModel.Today,
				LastUpdateTime = requestModel.LastUpdateTime
			};
		}

		public static ReportCategoryDayAccessRequestModel ToRequestModel(this ReportCategoryDayAccess entity)
		{
			return new ReportCategoryDayAccessRequestModel
			{
				CategoryAccessId = entity.CategoryAccessId,
				CategoryId = entity.CategoryId,
				CategoryName = entity.CategoryName,
				Count = entity.Count,
				Today = entity.Today,
				LastUpdateTime = entity.LastUpdateTime
			};
		}

		public static ReportCategoryDayClick ToEntity(this ReportCategoryDayClickRequestModel requestModel)
		{
			return new ReportCategoryDayClick
			{
				CategoryClickId = requestModel.CategoryClickId,
				CategoryId = requestModel.CategoryId,
				CategoryName = requestModel.CategoryName,
				Count = requestModel.Count,
				Today = requestModel.Today,
				LastUpdateTime = requestModel.LastUpdateTime
			};
		}

		public static ReportCategoryDayClickRequestModel ToRequestModel(this ReportCategoryDayClick entity)
		{
			return new ReportCategoryDayClickRequestModel
			{
				CategoryClickId = entity.CategoryClickId,
				CategoryId = entity.CategoryId,
				CategoryName = entity.CategoryName,
				Count = entity.Count,
				Today = entity.Today,
				LastUpdateTime = entity.LastUpdateTime
			};
		}

		public static ReportNewsDayAccess ToEntity(this ReportNewsDayAccessRequestModel requestModel)
		{
			return new ReportNewsDayAccess
			{
				NewsAccessId = requestModel.NewsAccessId,
				NewsId = requestModel.NewsId,
				CategoryId = requestModel.CategoryId,
				CategoryName = requestModel.CategoryName,
				SpecialCode = requestModel.SpecialCode,
				SpecialName = requestModel.SpecialName,
				Count = requestModel.Count,
				Today = requestModel.Today,
				LastUpdateTime = requestModel.LastUpdateTime
			};
		}

		public static ReportNewsDayAccessRequestModel ToRequestModel(this ReportNewsDayAccess entity)
		{
			return new ReportNewsDayAccessRequestModel
			{
				NewsAccessId = entity.NewsAccessId,
				NewsId = entity.NewsId,
				CategoryId = entity.CategoryId,
				CategoryName = entity.CategoryName,
				SpecialCode = entity.SpecialCode,
				SpecialName = entity.SpecialName,
				Count = entity.Count,
				Today = entity.Today,
				LastUpdateTime = entity.LastUpdateTime
			};
		}

		public static ReportNewsDayClick ToEntity(this ReportNewsDayClickRequestModel requestModel)
		{
			return new ReportNewsDayClick
			{
				NewsClickId = requestModel.NewsClickId,
				NewsId = requestModel.NewsId,
				CategoryId = requestModel.CategoryId,
				CategoryName = requestModel.CategoryName,
				SpecialCode = requestModel.SpecialCode,
				SpecialName = requestModel.SpecialName,
				Count = requestModel.Count,
				Today = requestModel.Today,
				LastUpdateTime = requestModel.LastUpdateTime
			};
		}

		public static ReportNewsDayClickRequestModel ToRequestModel(this ReportNewsDayClick entity)
		{
			return new ReportNewsDayClickRequestModel
			{
				NewsClickId = entity.NewsClickId,
				NewsId = entity.NewsId,
				CategoryId = entity.CategoryId,
				CategoryName = entity.CategoryName,
				SpecialCode = entity.SpecialCode,
				SpecialName = entity.SpecialName,
				Count = entity.Count,
				Today = entity.Today,
				LastUpdateTime = entity.LastUpdateTime
			};
		}

		public static ReportSiteDayAccess ToEntity(this ReportSiteDayAccessRequestModel requestModel)
		{
			return new ReportSiteDayAccess
			{
				SiteAccessId = requestModel.SiteAccessId,
				SiteNo = requestModel.SiteNo,
				Count = requestModel.Count,
				Today = requestModel.Today,
				LastUpdateTime = requestModel.LastUpdateTime
			};
		}

		public static ReportSiteDayAccessRequestModel ToRequestModel(this ReportSiteDayAccess entity)
		{
			return new ReportSiteDayAccessRequestModel
			{
				SiteAccessId = entity.SiteAccessId,
				SiteNo = entity.SiteNo,
				Count = entity.Count,
				Today = entity.Today,
				LastUpdateTime = entity.LastUpdateTime
			};
		}

		public static SystemDictionary ToEntity(this SystemDictionaryRequestModel requestModel)
		{
			return new SystemDictionary
			{
				DictionaryId = requestModel.DictionaryId,
				Keys = requestModel.Keys,
				Name = requestModel.Name,
				Value = requestModel.Value,
				Remarks = requestModel.Remarks
			};
		}

		public static SystemDictionaryRequestModel ToRequestModel(this SystemDictionary entity)
		{
			return new SystemDictionaryRequestModel
			{
				DictionaryId = entity.DictionaryId,
				Keys = entity.Keys,
				Name = entity.Name,
				Value = entity.Value,
				Remarks = entity.Remarks
			};
		}

		public static SystemLogs ToEntity(this SystemLogsRequestModel requestModel)
		{
			return new SystemLogs
			{
				LogsId = requestModel.LogsId,
				Methods = requestModel.Methods,
				Grade = requestModel.Grade,
				Source = requestModel.Source,
				Args = requestModel.Args,
				Errors = requestModel.Errors,
				CreateBy = requestModel.CreateBy,
				CreateTime = requestModel.CreateTime
			};
		}

		public static SystemLogsRequestModel ToRequestModel(this SystemLogs entity)
		{
			return new SystemLogsRequestModel
			{
				LogsId = entity.LogsId,
				Methods = entity.Methods,
				Grade = entity.Grade,
				Source = entity.Source,
				Args = entity.Args,
				Errors = entity.Errors,
				CreateBy = entity.CreateBy,
				CreateTime = entity.CreateTime
			};
		}

		public static SystemMenu ToEntity(this SystemMenuRequestModel requestModel)
		{
			return new SystemMenu
			{
				MenuId = requestModel.MenuId,
				SiteNo = requestModel.SiteNo,
				MenuIcon = requestModel.MenuIcon,
				MenuName = requestModel.MenuName,
				ParentId = requestModel.ParentId,
				NodeValue = requestModel.NodeValue,
				Areas = requestModel.Areas,
				Controller = requestModel.Controller,
				Action = requestModel.Action,
				Urls = requestModel.Urls,
				RouterName = requestModel.RouterName,
				RouterPath = requestModel.RouterPath,
				Component = requestModel.Component,
				ShowAlways = requestModel.ShowAlways,
				ShowHeader = requestModel.ShowHeader,
				HideInBread = requestModel.HideInBread,
				HideInMenu = requestModel.HideInMenu,
				NotCache = requestModel.NotCache,
				BeforeCloseName = requestModel.BeforeCloseName,
				Sequence = requestModel.Sequence,
				IsEnable = requestModel.IsEnable,
				RowVers = requestModel.RowVers,
				Remarks = requestModel.Remarks,
				CreateBy = requestModel.CreateBy,
				CreateTime = requestModel.CreateTime
			};
		}

		public static SystemMenuRequestModel ToRequestModel(this SystemMenu entity)
		{
			return new SystemMenuRequestModel
			{
				MenuId = entity.MenuId,
				SiteNo = entity.SiteNo,
				MenuIcon = entity.MenuIcon,
				MenuName = entity.MenuName,
				ParentId = entity.ParentId,
				NodeValue = entity.NodeValue,
				Areas = entity.Areas,
				Controller = entity.Controller,
				Action = entity.Action,
				Urls = entity.Urls,
				RouterName = entity.RouterName,
				RouterPath = entity.RouterPath,
				Component = entity.Component,
				ShowAlways = entity.ShowAlways,
				ShowHeader = entity.ShowHeader,
				HideInBread = entity.HideInBread,
				HideInMenu = entity.HideInMenu,
				NotCache = entity.NotCache,
				BeforeCloseName = entity.BeforeCloseName,
				Sequence = entity.Sequence,
				IsEnable = entity.IsEnable,
				RowVers = entity.RowVers,
				Remarks = entity.Remarks,
				CreateBy = entity.CreateBy,
				CreateTime = entity.CreateTime
			};
		}

		public static SystemRole ToEntity(this SystemRoleRequestModel requestModel)
		{
			return new SystemRole
			{
				RoleId = requestModel.RoleId,
				RoleName = requestModel.RoleName,
				IsEnable = requestModel.IsEnable,
				Remarks = requestModel.Remarks,
				CreateBy = requestModel.CreateBy,
				CreateDate = requestModel.CreateDate
			};
		}

		public static SystemRoleRequestModel ToRequestModel(this SystemRole entity)
		{
			return new SystemRoleRequestModel
			{
				RoleId = entity.RoleId,
				RoleName = entity.RoleName,
				IsEnable = entity.IsEnable,
				Remarks = entity.Remarks,
				CreateBy = entity.CreateBy,
				CreateDate = entity.CreateDate
			};
		}

		public static SystemRoleDictionary ToEntity(this SystemRoleDictionaryRequestModel requestModel)
		{
			return new SystemRoleDictionary
			{
				Id = requestModel.Id,
				RoleId = requestModel.RoleId,
				DictionaryKey = requestModel.DictionaryKey,
				DictionaryValue = requestModel.DictionaryValue
			};
		}

		public static SystemRoleDictionaryRequestModel ToRequestModel(this SystemRoleDictionary entity)
		{
			return new SystemRoleDictionaryRequestModel
			{
				Id = entity.Id,
				RoleId = entity.RoleId,
				DictionaryKey = entity.DictionaryKey,
				DictionaryValue = entity.DictionaryValue
			};
		}

		public static SystemRoleInMenu ToEntity(this SystemRoleInMenuRequestModel requestModel)
		{
			return new SystemRoleInMenu
			{
				RoleId = requestModel.RoleId,
				MenuId = requestModel.MenuId
			};
		}

		public static SystemRoleInMenuRequestModel ToRequestModel(this SystemRoleInMenu entity)
		{
			return new SystemRoleInMenuRequestModel
			{
				RoleId = entity.RoleId,
				MenuId = entity.MenuId
			};
		}

		public static SystemUsers ToEntity(this SystemUsersRequestModel requestModel)
		{
			return new SystemUsers
			{
				UsersId = requestModel.UsersId,
				UsersName = requestModel.UsersName,
				LoginName = requestModel.LoginName,
				Password = requestModel.Password,
				MobilePhone = requestModel.MobilePhone,
				Email = requestModel.Email,
				LoginIp = requestModel.LoginIp,
				LoginTime = requestModel.LoginTime,
				IsEnable = requestModel.IsEnable,
				Remarks = requestModel.Remarks,
				CreateBy = requestModel.CreateBy,
				CreateTime = requestModel.CreateTime
			};
		}

		public static SystemUsersRequestModel ToRequestModel(this SystemUsers entity)
		{
			return new SystemUsersRequestModel
			{
				UsersId = entity.UsersId,
				UsersName = entity.UsersName,
				LoginName = entity.LoginName,
				Password = entity.Password,
				MobilePhone = entity.MobilePhone,
				Email = entity.Email,
				LoginIp = entity.LoginIp,
				LoginTime = entity.LoginTime,
				IsEnable = entity.IsEnable,
				Remarks = entity.Remarks,
				CreateBy = entity.CreateBy,
				CreateTime = entity.CreateTime
			};
		}

		public static SystemUsersDictionary ToEntity(this SystemUsersDictionaryRequestModel requestModel)
		{
			return new SystemUsersDictionary
			{
				Id = requestModel.Id,
				UserId = requestModel.UserId,
				DictionaryKey = requestModel.DictionaryKey,
				DictionaryValue = requestModel.DictionaryValue
			};
		}

		public static SystemUsersDictionaryRequestModel ToRequestModel(this SystemUsersDictionary entity)
		{
			return new SystemUsersDictionaryRequestModel
			{
				Id = entity.Id,
				UserId = entity.UserId,
				DictionaryKey = entity.DictionaryKey,
				DictionaryValue = entity.DictionaryValue
			};
		}

		public static SystemUsersInMenu ToEntity(this SystemUsersInMenuRequestModel requestModel)
		{
			return new SystemUsersInMenu
			{
				UserId = requestModel.UserId,
				MenuId = requestModel.MenuId
			};
		}

		public static SystemUsersInMenuRequestModel ToRequestModel(this SystemUsersInMenu entity)
		{
			return new SystemUsersInMenuRequestModel
			{
				UserId = entity.UserId,
				MenuId = entity.MenuId
			};
		}

		public static SystemUsersInRole ToEntity(this SystemUsersInRoleRequestModel requestModel)
		{
			return new SystemUsersInRole
			{
				UsersId = requestModel.UsersId,
				RoleId = requestModel.RoleId
			};
		}

		public static SystemUsersInRoleRequestModel ToRequestModel(this SystemUsersInRole entity)
		{
			return new SystemUsersInRoleRequestModel
			{
				UsersId = entity.UsersId,
				RoleId = entity.RoleId
			};
		}

		public static SystemUsersRefreshToken ToEntity(this SystemUsersRefreshTokenRequestModel requestModel)
		{
			return new SystemUsersRefreshToken
			{
				RefreshTokenId = requestModel.RefreshTokenId,
				UsersId = requestModel.UsersId,
				AccessToken = requestModel.AccessToken,
				Expires = requestModel.Expires,
				Active = requestModel.Active
			};
		}

		public static SystemUsersRefreshTokenRequestModel ToRequestModel(this SystemUsersRefreshToken entity)
		{
			return new SystemUsersRefreshTokenRequestModel
			{
				RefreshTokenId = entity.RefreshTokenId,
				UsersId = entity.UsersId,
				AccessToken = entity.AccessToken,
				Expires = entity.Expires,
				Active = entity.Active
			};
		}

		public static WebCategory ToEntity(this WebCategoryRequestModel requestModel)
		{
			return new WebCategory
			{
				CategoryId = requestModel.CategoryId,
				SiteNo = requestModel.SiteNo,
				CategoryName = requestModel.CategoryName,
				ParentId = requestModel.ParentId,
				NodeValue = requestModel.NodeValue,
				Controller = requestModel.Controller,
				Action = requestModel.Action,
				Urls = requestModel.Urls,
				DocumentNumber = requestModel.DocumentNumber,
				VirtualAccessNumber = requestModel.VirtualAccessNumber,
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
				SiteNo = entity.SiteNo,
				CategoryName = entity.CategoryName,
				ParentId = entity.ParentId,
				NodeValue = entity.NodeValue,
				Controller = entity.Controller,
				Action = entity.Action,
				Urls = entity.Urls,
				DocumentNumber = entity.DocumentNumber,
				VirtualAccessNumber = entity.VirtualAccessNumber,
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

		public static WebChannel ToEntity(this WebChannelRequestModel requestModel)
		{
			return new WebChannel
			{
				ChannelId = requestModel.ChannelId,
				SiteNo = requestModel.SiteNo,
				ChannelName = requestModel.ChannelName,
				ChannelAddress = requestModel.ChannelAddress,
				ChannelJs = requestModel.ChannelJs,
				IsEnable = requestModel.IsEnable,
				RowVers = requestModel.RowVers,
				Remarks = requestModel.Remarks,
				CreateBy = requestModel.CreateBy,
				CreateTime = requestModel.CreateTime
			};
		}

		public static WebChannelRequestModel ToRequestModel(this WebChannel entity)
		{
			return new WebChannelRequestModel
			{
				ChannelId = entity.ChannelId,
				SiteNo = entity.SiteNo,
				ChannelName = entity.ChannelName,
				ChannelAddress = entity.ChannelAddress,
				ChannelJs = entity.ChannelJs,
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
				SiteNo = requestModel.SiteNo,
				SpecialCode = requestModel.SpecialCode,
				CategoryId = requestModel.CategoryId,
				CategoryName = requestModel.CategoryName,
				NewsTitle = requestModel.NewsTitle,
				CustomTitle = requestModel.CustomTitle,
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
				ClickNumber = requestModel.ClickNumber,
				AuditName = requestModel.AuditName,
				AuditStatus = requestModel.AuditStatus,
				AuditTime = requestModel.AuditTime,
				PushStatus = requestModel.PushStatus,
				PushName = requestModel.PushName,
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
				SiteNo = entity.SiteNo,
				SpecialCode = entity.SpecialCode,
				CategoryId = entity.CategoryId,
				CategoryName = entity.CategoryName,
				NewsTitle = entity.NewsTitle,
				CustomTitle = entity.CustomTitle,
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
				ClickNumber = entity.ClickNumber,
				AuditName = entity.AuditName,
				AuditStatus = entity.AuditStatus,
				AuditTime = entity.AuditTime,
				PushStatus = entity.PushStatus,
				PushName = entity.PushName,
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

		public static WebNewsOperateLogs ToEntity(this WebNewsOperateLogsRequestModel requestModel)
		{
			return new WebNewsOperateLogs
			{
				NewsOperateId = requestModel.NewsOperateId,
				NewsId = requestModel.NewsId,
				OperateType = requestModel.OperateType,
				OperateStatus = requestModel.OperateStatus,
				Remarks = requestModel.Remarks,
				CreateBy = requestModel.CreateBy,
				CreateName = requestModel.CreateName,
				CreateTime = requestModel.CreateTime
			};
		}

		public static WebNewsOperateLogsRequestModel ToRequestModel(this WebNewsOperateLogs entity)
		{
			return new WebNewsOperateLogsRequestModel
			{
				NewsOperateId = entity.NewsOperateId,
				NewsId = entity.NewsId,
				OperateType = entity.OperateType,
				OperateStatus = entity.OperateStatus,
				Remarks = entity.Remarks,
				CreateBy = entity.CreateBy,
				CreateName = entity.CreateName,
				CreateTime = entity.CreateTime
			};
		}

		public static WebNewsSensitive ToEntity(this WebNewsSensitiveRequestModel requestModel)
		{
			return new WebNewsSensitive
			{
				NewsSensitiveId = requestModel.NewsSensitiveId,
				SiteMark = requestModel.SiteMark,
				NewId = requestModel.NewId,
				NewTitleRecords = requestModel.NewTitleRecords,
				CustomTitleRecords = requestModel.CustomTitleRecords,
				ContentsRecords = requestModel.ContentsRecords,
				IsEnable = requestModel.IsEnable,
				Remarks = requestModel.Remarks,
				CreateBy = requestModel.CreateBy,
				CreateTime = requestModel.CreateTime
			};
		}

		public static WebNewsSensitiveRequestModel ToRequestModel(this WebNewsSensitive entity)
		{
			return new WebNewsSensitiveRequestModel
			{
				NewsSensitiveId = entity.NewsSensitiveId,
				SiteMark = entity.SiteMark,
				NewId = entity.NewId,
				NewTitleRecords = entity.NewTitleRecords,
				CustomTitleRecords = entity.CustomTitleRecords,
				ContentsRecords = entity.ContentsRecords,
				IsEnable = entity.IsEnable,
				Remarks = entity.Remarks,
				CreateBy = entity.CreateBy,
				CreateTime = entity.CreateTime
			};
		}

		public static WebSensitive ToEntity(this WebSensitiveRequestModel requestModel)
		{
			return new WebSensitive
			{
				SensitiveId = requestModel.SensitiveId,
				SiteNo = requestModel.SiteNo,
				Type = requestModel.Type,
				TypeText = requestModel.TypeText,
				SensitiveWords = requestModel.SensitiveWords,
				Author = requestModel.Author,
				Urls = requestModel.Urls,
				RowVers = requestModel.RowVers,
				IsEnable = requestModel.IsEnable,
				Remarks = requestModel.Remarks,
				CreateBy = requestModel.CreateBy,
				CreateTime = requestModel.CreateTime
			};
		}

		public static WebSensitiveRequestModel ToRequestModel(this WebSensitive entity)
		{
			return new WebSensitiveRequestModel
			{
				SensitiveId = entity.SensitiveId,
				SiteNo = entity.SiteNo,
				Type = entity.Type,
				TypeText = entity.TypeText,
				SensitiveWords = entity.SensitiveWords,
				Author = entity.Author,
				Urls = entity.Urls,
				RowVers = entity.RowVers,
				IsEnable = entity.IsEnable,
				Remarks = entity.Remarks,
				CreateBy = entity.CreateBy,
				CreateTime = entity.CreateTime
			};
		}

		public static WebSite ToEntity(this WebSiteRequestModel requestModel)
		{
			return new WebSite
			{
				SiteId = requestModel.SiteId,
				SiteNo = requestModel.SiteNo,
				SiteName = requestModel.SiteName,
				SiteUrls = requestModel.SiteUrls,
				LogoUrls = requestModel.LogoUrls,
				Count = requestModel.Count,
				Title = requestModel.Title,
				Keywords = requestModel.Keywords,
				Description = requestModel.Description,
				RowVers = requestModel.RowVers,
				IsEnable = requestModel.IsEnable,
				Remarks = requestModel.Remarks,
				CreateBy = requestModel.CreateBy,
				CreateTime = requestModel.CreateTime
			};
		}

		public static WebSiteRequestModel ToRequestModel(this WebSite entity)
		{
			return new WebSiteRequestModel
			{
				SiteId = entity.SiteId,
				SiteNo = entity.SiteNo,
				SiteName = entity.SiteName,
				SiteUrls = entity.SiteUrls,
				LogoUrls = entity.LogoUrls,
				Count = entity.Count,
				Title = entity.Title,
				Keywords = entity.Keywords,
				Description = entity.Description,
				RowVers = entity.RowVers,
				IsEnable = entity.IsEnable,
				Remarks = entity.Remarks,
				CreateBy = entity.CreateBy,
				CreateTime = entity.CreateTime
			};
		}

		public static WebSpecial ToEntity(this WebSpecialRequestModel requestModel)
		{
			return new WebSpecial
			{
				SpecialId = requestModel.SpecialId,
				SiteNo = requestModel.SiteNo,
				SpecialCode = requestModel.SpecialCode,
				Name = requestModel.Name,
				DisplayType = requestModel.DisplayType,
				IsEnable = requestModel.IsEnable,
				RowVers = requestModel.RowVers,
				Remarks = requestModel.Remarks,
				CreateBy = requestModel.CreateBy,
				CreateTime = requestModel.CreateTime
			};
		}

		public static WebSpecialRequestModel ToRequestModel(this WebSpecial entity)
		{
			return new WebSpecialRequestModel
			{
				SpecialId = entity.SpecialId,
				SiteNo = entity.SiteNo,
				SpecialCode = entity.SpecialCode,
				Name = entity.Name,
				DisplayType = entity.DisplayType,
				IsEnable = entity.IsEnable,
				RowVers = entity.RowVers,
				Remarks = entity.Remarks,
				CreateBy = entity.CreateBy,
				CreateTime = entity.CreateTime
			};
		}
	}
}
