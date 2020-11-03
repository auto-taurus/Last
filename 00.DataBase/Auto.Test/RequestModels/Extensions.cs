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

		public static MemberComment ToEntity(this MemberCommentRequestModel requestModel)
		{
			return new MemberComment
			{
				CommentId = requestModel.CommentId,
				NewsId = requestModel.NewsId,
				ParentId = requestModel.ParentId,
				MemberId = requestModel.MemberId,
				MemberName = requestModel.MemberName,
				CommentBody = requestModel.CommentBody,
				CommentTime = requestModel.CommentTime,
				QuoteId = requestModel.QuoteId,
				QuoteName = requestModel.QuoteName,
				Up = requestModel.Up,
				Number = requestModel.Number,
				IsEnable = requestModel.IsEnable,
				Remarks = requestModel.Remarks
			};
		}

		public static MemberCommentRequestModel ToRequestModel(this MemberComment entity)
		{
			return new MemberCommentRequestModel
			{
				CommentId = entity.CommentId,
				NewsId = entity.NewsId,
				ParentId = entity.ParentId,
				MemberId = entity.MemberId,
				MemberName = entity.MemberName,
				CommentBody = entity.CommentBody,
				CommentTime = entity.CommentTime,
				QuoteId = entity.QuoteId,
				QuoteName = entity.QuoteName,
				Up = entity.Up,
				Number = entity.Number,
				IsEnable = entity.IsEnable,
				Remarks = entity.Remarks
			};
		}

		public static MemberCommentSensitive ToEntity(this MemberCommentSensitiveRequestModel requestModel)
		{
			return new MemberCommentSensitive
			{
				CommentSensitiveId = requestModel.CommentSensitiveId,
				SensitiveWords = requestModel.SensitiveWords,
				ReplaceValue = requestModel.ReplaceValue,
				IsEnable = requestModel.IsEnable,
				Remarks = requestModel.Remarks,
				CreateBy = requestModel.CreateBy,
				CreateTime = requestModel.CreateTime
			};
		}

		public static MemberCommentSensitiveRequestModel ToRequestModel(this MemberCommentSensitive entity)
		{
			return new MemberCommentSensitiveRequestModel
			{
				CommentSensitiveId = entity.CommentSensitiveId,
				SensitiveWords = entity.SensitiveWords,
				ReplaceValue = entity.ReplaceValue,
				IsEnable = entity.IsEnable,
				Remarks = entity.Remarks,
				CreateBy = entity.CreateBy,
				CreateTime = entity.CreateTime
			};
		}

		public static MemberCommentUp ToEntity(this MemberCommentUpRequestModel requestModel)
		{
			return new MemberCommentUp
			{
				CommentUpId = requestModel.CommentUpId,
				CommentId = requestModel.CommentId,
				MemberId = requestModel.MemberId
			};
		}

		public static MemberCommentUpRequestModel ToRequestModel(this MemberCommentUp entity)
		{
			return new MemberCommentUpRequestModel
			{
				CommentUpId = entity.CommentUpId,
				CommentId = entity.CommentId,
				MemberId = entity.MemberId
			};
		}

		public static MemberFans ToEntity(this MemberFansRequestModel requestModel)
		{
			return new MemberFans
			{
				FansId = requestModel.FansId,
				MemberId = requestModel.MemberId,
				MemberFansId = requestModel.MemberFansId,
				MemberFansName = requestModel.MemberFansName,
				FollowTime = requestModel.FollowTime,
				IsEnable = requestModel.IsEnable,
				Remarks = requestModel.Remarks
			};
		}

		public static MemberFansRequestModel ToRequestModel(this MemberFans entity)
		{
			return new MemberFansRequestModel
			{
				FansId = entity.FansId,
				MemberId = entity.MemberId,
				MemberFansId = entity.MemberFansId,
				MemberFansName = entity.MemberFansName,
				FollowTime = entity.FollowTime,
				IsEnable = entity.IsEnable,
				Remarks = entity.Remarks
			};
		}

		public static MemberFavorites ToEntity(this MemberFavoritesRequestModel requestModel)
		{
			return new MemberFavorites
			{
				FavoritesId = requestModel.FavoritesId,
				MemberId = requestModel.MemberId,
				SourceId = requestModel.SourceId,
				SourceTable = requestModel.SourceTable,
				FavoritesTime = requestModel.FavoritesTime,
				IsEnable = requestModel.IsEnable,
				Remarks = requestModel.Remarks
			};
		}

		public static MemberFavoritesRequestModel ToRequestModel(this MemberFavorites entity)
		{
			return new MemberFavoritesRequestModel
			{
				FavoritesId = entity.FavoritesId,
				MemberId = entity.MemberId,
				SourceId = entity.SourceId,
				SourceTable = entity.SourceTable,
				FavoritesTime = entity.FavoritesTime,
				IsEnable = entity.IsEnable,
				Remarks = entity.Remarks
			};
		}

		public static MemberFollow ToEntity(this MemberFollowRequestModel requestModel)
		{
			return new MemberFollow
			{
				FollowId = requestModel.FollowId,
				MemberId = requestModel.MemberId,
				SourceId = requestModel.SourceId,
				SourceTable = requestModel.SourceTable,
				CategoryId = requestModel.CategoryId,
				FollowTime = requestModel.FollowTime,
				IsEnable = requestModel.IsEnable,
				Remarks = requestModel.Remarks
			};
		}

		public static MemberFollowRequestModel ToRequestModel(this MemberFollow entity)
		{
			return new MemberFollowRequestModel
			{
				FollowId = entity.FollowId,
				MemberId = entity.MemberId,
				SourceId = entity.SourceId,
				SourceTable = entity.SourceTable,
				CategoryId = entity.CategoryId,
				FollowTime = entity.FollowTime,
				IsEnable = entity.IsEnable,
				Remarks = entity.Remarks
			};
		}

		public static MemberFootprint ToEntity(this MemberFootprintRequestModel requestModel)
		{
			return new MemberFootprint
			{
				FootprintId = requestModel.FootprintId,
				MemberId = requestModel.MemberId,
				SourceId = requestModel.SourceId,
				SourceTable = requestModel.SourceTable,
				BrowseTime = requestModel.BrowseTime,
				IsEnable = requestModel.IsEnable,
				Remarks = requestModel.Remarks
			};
		}

		public static MemberFootprintRequestModel ToRequestModel(this MemberFootprint entity)
		{
			return new MemberFootprintRequestModel
			{
				FootprintId = entity.FootprintId,
				MemberId = entity.MemberId,
				SourceId = entity.SourceId,
				SourceTable = entity.SourceTable,
				BrowseTime = entity.BrowseTime,
				IsEnable = entity.IsEnable,
				Remarks = entity.Remarks
			};
		}

		public static MemberIncome ToEntity(this MemberIncomeRequestModel requestModel)
		{
			return new MemberIncome
			{
				IncomeId = requestModel.IncomeId,
				MemberId = requestModel.MemberId,
				TaskId = requestModel.TaskId,
				TaskCode = requestModel.TaskCode,
				TaksName = requestModel.TaksName,
				Title = requestModel.Title,
				Beans = requestModel.Beans,
				BeansText = requestModel.BeansText,
				CreateTime = requestModel.CreateTime,
				Proportion = requestModel.Proportion,
				ReadTime = requestModel.ReadTime,
				Status = requestModel.Status,
				Remarks = requestModel.Remarks,
				AuditId = requestModel.AuditId,
				Audit = requestModel.Audit,
				AuditTime = requestModel.AuditTime
			};
		}

		public static MemberIncomeRequestModel ToRequestModel(this MemberIncome entity)
		{
			return new MemberIncomeRequestModel
			{
				IncomeId = entity.IncomeId,
				MemberId = entity.MemberId,
				TaskId = entity.TaskId,
				TaskCode = entity.TaskCode,
				TaksName = entity.TaksName,
				Title = entity.Title,
				Beans = entity.Beans,
				BeansText = entity.BeansText,
				CreateTime = entity.CreateTime,
				Proportion = entity.Proportion,
				ReadTime = entity.ReadTime,
				Status = entity.Status,
				Remarks = entity.Remarks,
				AuditId = entity.AuditId,
				Audit = entity.Audit,
				AuditTime = entity.AuditTime
			};
		}

		public static MemberInfos ToEntity(this MemberInfosRequestModel requestModel)
		{
			return new MemberInfos
			{
				MemberId = requestModel.MemberId,
				Code = requestModel.Code,
				NickName = requestModel.NickName,
				Name = requestModel.Name,
				Sex = requestModel.Sex,
				Phone = requestModel.Phone,
				Alipay = requestModel.Alipay,
				Wechat = requestModel.Wechat,
				Password = requestModel.Password,
				Avatar = requestModel.Avatar,
				Beans = requestModel.Beans,
				BeansTotals = requestModel.BeansTotals,
				LastLoginTime = requestModel.LastLoginTime,
				NewsNumber = requestModel.NewsNumber,
				FollowNumber = requestModel.FollowNumber,
				FavoritesNumber = requestModel.FavoritesNumber,
				FansNumber = requestModel.FansNumber,
				IsNew = requestModel.IsNew,
				IsEnbale = requestModel.IsEnbale,
				Remarks = requestModel.Remarks,
				CreateTime = requestModel.CreateTime
			};
		}

		public static MemberInfosRequestModel ToRequestModel(this MemberInfos entity)
		{
			return new MemberInfosRequestModel
			{
				MemberId = entity.MemberId,
				Code = entity.Code,
				NickName = entity.NickName,
				Name = entity.Name,
				Sex = entity.Sex,
				Phone = entity.Phone,
				Alipay = entity.Alipay,
				Wechat = entity.Wechat,
				Password = entity.Password,
				Avatar = entity.Avatar,
				Beans = entity.Beans,
				BeansTotals = entity.BeansTotals,
				LastLoginTime = entity.LastLoginTime,
				NewsNumber = entity.NewsNumber,
				FollowNumber = entity.FollowNumber,
				FavoritesNumber = entity.FavoritesNumber,
				FansNumber = entity.FansNumber,
				IsNew = entity.IsNew,
				IsEnbale = entity.IsEnbale,
				Remarks = entity.Remarks,
				CreateTime = entity.CreateTime
			};
		}

		public static MemberLoginLog ToEntity(this MemberLoginLogRequestModel requestModel)
		{
			return new MemberLoginLog
			{
				LoginLogId = requestModel.LoginLogId,
				Source = requestModel.Source,
				Column3 = requestModel.Column3,
				Column4 = requestModel.Column4
			};
		}

		public static MemberLoginLogRequestModel ToRequestModel(this MemberLoginLog entity)
		{
			return new MemberLoginLogRequestModel
			{
				LoginLogId = entity.LoginLogId,
				Source = entity.Source,
				Column3 = entity.Column3,
				Column4 = entity.Column4
			};
		}

		public static MemberMessage ToEntity(this MemberMessageRequestModel requestModel)
		{
			return new MemberMessage
			{
				MessageId = requestModel.MessageId,
				MemberId = requestModel.MemberId,
				MemberName = requestModel.MemberName,
				LeaveBody = requestModel.LeaveBody,
				LeaveType = requestModel.LeaveType,
				CreateTime = requestModel.CreateTime,
				IsEnable = requestModel.IsEnable,
				Remarks = requestModel.Remarks
			};
		}

		public static MemberMessageRequestModel ToRequestModel(this MemberMessage entity)
		{
			return new MemberMessageRequestModel
			{
				MessageId = entity.MessageId,
				MemberId = entity.MemberId,
				MemberName = entity.MemberName,
				LeaveBody = entity.LeaveBody,
				LeaveType = entity.LeaveType,
				CreateTime = entity.CreateTime,
				IsEnable = entity.IsEnable,
				Remarks = entity.Remarks
			};
		}

		public static MemberProblem ToEntity(this MemberProblemRequestModel requestModel)
		{
			return new MemberProblem
			{
				ProblemId = requestModel.ProblemId,
				Title = requestModel.Title,
				Desc = requestModel.Desc,
				Type = requestModel.Type,
				Urls = requestModel.Urls,
				IsHot = requestModel.IsHot,
				Sequence = requestModel.Sequence,
				IsEnable = requestModel.IsEnable,
				Remarks = requestModel.Remarks,
				CreateBy = requestModel.CreateBy,
				CreateTime = requestModel.CreateTime
			};
		}

		public static MemberProblemRequestModel ToRequestModel(this MemberProblem entity)
		{
			return new MemberProblemRequestModel
			{
				ProblemId = entity.ProblemId,
				Title = entity.Title,
				Desc = entity.Desc,
				Type = entity.Type,
				Urls = entity.Urls,
				IsHot = entity.IsHot,
				Sequence = entity.Sequence,
				IsEnable = entity.IsEnable,
				Remarks = entity.Remarks,
				CreateBy = entity.CreateBy,
				CreateTime = entity.CreateTime
			};
		}

		public static MemberWithdraw ToEntity(this MemberWithdrawRequestModel requestModel)
		{
			return new MemberWithdraw
			{
				WithdrawId = requestModel.WithdrawId,
				MemberId = requestModel.MemberId,
				Methods = requestModel.Methods,
				Title = requestModel.Title,
				Beans = requestModel.Beans,
				Amount = requestModel.Amount,
				Proportion = requestModel.Proportion,
				CreateTime = requestModel.CreateTime,
				Status = requestModel.Status,
				Remarks = requestModel.Remarks,
				AuditId = requestModel.AuditId,
				Audit = requestModel.Audit,
				AuditTime = requestModel.AuditTime
			};
		}

		public static MemberWithdrawRequestModel ToRequestModel(this MemberWithdraw entity)
		{
			return new MemberWithdrawRequestModel
			{
				WithdrawId = entity.WithdrawId,
				MemberId = entity.MemberId,
				Methods = entity.Methods,
				Title = entity.Title,
				Beans = entity.Beans,
				Amount = entity.Amount,
				Proportion = entity.Proportion,
				CreateTime = entity.CreateTime,
				Status = entity.Status,
				Remarks = entity.Remarks,
				AuditId = entity.AuditId,
				Audit = entity.Audit,
				AuditTime = entity.AuditTime
			};
		}

		public static MemberWithdrawConfig ToEntity(this MemberWithdrawConfigRequestModel requestModel)
		{
			return new MemberWithdrawConfig
			{
				WithdrawConfigId = requestModel.WithdrawConfigId,
				Methods = requestModel.Methods,
				Tips = requestModel.Tips,
				WithdrawTask = requestModel.WithdrawTask,
				Amount = requestModel.Amount,
				AmountTips = requestModel.AmountTips,
				AmountDesc = requestModel.AmountDesc,
				AmountTask = requestModel.AmountTask,
				Desc = requestModel.Desc,
				IsEnable = requestModel.IsEnable,
				Remarks = requestModel.Remarks,
				CreateBy = requestModel.CreateBy,
				CreateTime = requestModel.CreateTime
			};
		}

		public static MemberWithdrawConfigRequestModel ToRequestModel(this MemberWithdrawConfig entity)
		{
			return new MemberWithdrawConfigRequestModel
			{
				WithdrawConfigId = entity.WithdrawConfigId,
				Methods = entity.Methods,
				Tips = entity.Tips,
				WithdrawTask = entity.WithdrawTask,
				Amount = entity.Amount,
				AmountTips = entity.AmountTips,
				AmountDesc = entity.AmountDesc,
				AmountTask = entity.AmountTask,
				Desc = entity.Desc,
				IsEnable = entity.IsEnable,
				Remarks = entity.Remarks,
				CreateBy = entity.CreateBy,
				CreateTime = entity.CreateTime
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
				SiteId = requestModel.SiteId,
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
				SiteId = entity.SiteId,
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
				TypeKey = requestModel.TypeKey,
				DistKey = requestModel.DistKey,
				DistName = requestModel.DistName,
				DistValue = requestModel.DistValue,
				Sequence = requestModel.Sequence,
				IsEnable = requestModel.IsEnable,
				Remarks = requestModel.Remarks
			};
		}

		public static SystemDictionaryRequestModel ToRequestModel(this SystemDictionary entity)
		{
			return new SystemDictionaryRequestModel
			{
				DictionaryId = entity.DictionaryId,
				TypeKey = entity.TypeKey,
				DistKey = entity.DistKey,
				DistName = entity.DistName,
				DistValue = entity.DistValue,
				Sequence = entity.Sequence,
				IsEnable = entity.IsEnable,
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
				SiteId = requestModel.SiteId,
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
				SiteId = entity.SiteId,
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
				Id = requestModel.Id,
				RoleId = requestModel.RoleId,
				MenuId = requestModel.MenuId
			};
		}

		public static SystemRoleInMenuRequestModel ToRequestModel(this SystemRoleInMenu entity)
		{
			return new SystemRoleInMenuRequestModel
			{
				Id = entity.Id,
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
				Id = requestModel.Id,
				UserId = requestModel.UserId,
				MenuId = requestModel.MenuId
			};
		}

		public static SystemUsersInMenuRequestModel ToRequestModel(this SystemUsersInMenu entity)
		{
			return new SystemUsersInMenuRequestModel
			{
				Id = entity.Id,
				UserId = entity.UserId,
				MenuId = entity.MenuId
			};
		}

		public static SystemUsersInRole ToEntity(this SystemUsersInRoleRequestModel requestModel)
		{
			return new SystemUsersInRole
			{
				Id = requestModel.Id,
				UsersId = requestModel.UsersId,
				RoleId = requestModel.RoleId
			};
		}

		public static SystemUsersInRoleRequestModel ToRequestModel(this SystemUsersInRole entity)
		{
			return new SystemUsersInRoleRequestModel
			{
				Id = entity.Id,
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

		public static TaskInfo ToEntity(this TaskInfoRequestModel requestModel)
		{
			return new TaskInfo
			{
				TaskId = requestModel.TaskId,
				TaskCode = requestModel.TaskCode,
				RelatedTasks = requestModel.RelatedTasks,
				TaskName = requestModel.TaskName,
				Desc = requestModel.Desc,
				SaveDesc = requestModel.SaveDesc,
				CategoryDay = requestModel.CategoryDay,
				CategoryFixed = requestModel.CategoryFixed,
				Platform = requestModel.Platform,
				Beans = requestModel.Beans,
				BeansText = requestModel.BeansText,
				IsDisplay = requestModel.IsDisplay,
				IsEnable = requestModel.IsEnable,
				Remarks = requestModel.Remarks,
				CreateBy = requestModel.CreateBy,
				CreateTime = requestModel.CreateTime
			};
		}

		public static TaskInfoRequestModel ToRequestModel(this TaskInfo entity)
		{
			return new TaskInfoRequestModel
			{
				TaskId = entity.TaskId,
				TaskCode = entity.TaskCode,
				RelatedTasks = entity.RelatedTasks,
				TaskName = entity.TaskName,
				Desc = entity.Desc,
				SaveDesc = entity.SaveDesc,
				CategoryDay = entity.CategoryDay,
				CategoryFixed = entity.CategoryFixed,
				Platform = entity.Platform,
				Beans = entity.Beans,
				BeansText = entity.BeansText,
				IsDisplay = entity.IsDisplay,
				IsEnable = entity.IsEnable,
				Remarks = entity.Remarks,
				CreateBy = entity.CreateBy,
				CreateTime = entity.CreateTime
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

		public static WebChannel ToEntity(this WebChannelRequestModel requestModel)
		{
			return new WebChannel
			{
				ChannelId = requestModel.ChannelId,
				SiteId = requestModel.SiteId,
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
				SiteId = entity.SiteId,
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
				SiteId = requestModel.SiteId,
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
				SiteId = entity.SiteId,
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

		public static WebSpecial ToEntity(this WebSpecialRequestModel requestModel)
		{
			return new WebSpecial
			{
				SpecialId = requestModel.SpecialId,
				SiteId = requestModel.SiteId,
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
				SiteId = entity.SiteId,
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
