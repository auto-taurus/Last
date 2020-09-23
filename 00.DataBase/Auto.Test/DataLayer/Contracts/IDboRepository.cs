using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnLineStoreCore.EntityLayer;
using OnLineStoreCore.DataLayer.Contracts;

namespace OnLineStoreCore.DataLayer.Contracts
{
	public interface IDboRepository : IRepository
	{
		IQueryable<AutoBatchInsertNewsId> GetAutoBatchInsertNewsIds();

		Task<AutoBatchInsertNewsId> GetAutoBatchInsertNewsIdAsync(AutoBatchInsertNewsId entity);

		Task<Int32> AddAutoBatchInsertNewsIdAsync(AutoBatchInsertNewsId entity);

		Task<Int32> UpdateAutoBatchInsertNewsIdAsync(AutoBatchInsertNewsId changes);

		Task<Int32> RemoveAutoBatchInsertNewsIdAsync(AutoBatchInsertNewsId entity);

		IQueryable<ReportCategoryDayAccess> GetReportCategoryDayAccesses();

		Task<ReportCategoryDayAccess> GetReportCategoryDayAccessAsync(ReportCategoryDayAccess entity);

		Task<Int32> AddReportCategoryDayAccessAsync(ReportCategoryDayAccess entity);

		Task<Int32> UpdateReportCategoryDayAccessAsync(ReportCategoryDayAccess changes);

		Task<Int32> RemoveReportCategoryDayAccessAsync(ReportCategoryDayAccess entity);

		IQueryable<ReportCategoryDayClick> GetReportCategoryDayClicks();

		Task<ReportCategoryDayClick> GetReportCategoryDayClickAsync(ReportCategoryDayClick entity);

		Task<Int32> AddReportCategoryDayClickAsync(ReportCategoryDayClick entity);

		Task<Int32> UpdateReportCategoryDayClickAsync(ReportCategoryDayClick changes);

		Task<Int32> RemoveReportCategoryDayClickAsync(ReportCategoryDayClick entity);

		IQueryable<ReportNewsDayAccess> GetReportNewsDayAccesses();

		Task<ReportNewsDayAccess> GetReportNewsDayAccessAsync(ReportNewsDayAccess entity);

		Task<Int32> AddReportNewsDayAccessAsync(ReportNewsDayAccess entity);

		Task<Int32> UpdateReportNewsDayAccessAsync(ReportNewsDayAccess changes);

		Task<Int32> RemoveReportNewsDayAccessAsync(ReportNewsDayAccess entity);

		IQueryable<ReportNewsDayClick> GetReportNewsDayClicks();

		Task<ReportNewsDayClick> GetReportNewsDayClickAsync(ReportNewsDayClick entity);

		Task<Int32> AddReportNewsDayClickAsync(ReportNewsDayClick entity);

		Task<Int32> UpdateReportNewsDayClickAsync(ReportNewsDayClick changes);

		Task<Int32> RemoveReportNewsDayClickAsync(ReportNewsDayClick entity);

		IQueryable<ReportSiteDayAccess> GetReportSiteDayAccesses();

		Task<ReportSiteDayAccess> GetReportSiteDayAccessAsync(ReportSiteDayAccess entity);

		Task<Int32> AddReportSiteDayAccessAsync(ReportSiteDayAccess entity);

		Task<Int32> UpdateReportSiteDayAccessAsync(ReportSiteDayAccess changes);

		Task<Int32> RemoveReportSiteDayAccessAsync(ReportSiteDayAccess entity);

		IQueryable<SystemDictionary> GetSystemDictionaries();

		Task<SystemDictionary> GetSystemDictionaryAsync(SystemDictionary entity);

		Task<Int32> AddSystemDictionaryAsync(SystemDictionary entity);

		Task<Int32> UpdateSystemDictionaryAsync(SystemDictionary changes);

		Task<Int32> RemoveSystemDictionaryAsync(SystemDictionary entity);

		IQueryable<SystemLogs> GetSystemLogs();

		Task<SystemLogs> GetSystemLogsAsync(SystemLogs entity);

		Task<Int32> AddSystemLogsAsync(SystemLogs entity);

		Task<Int32> UpdateSystemLogsAsync(SystemLogs changes);

		Task<Int32> RemoveSystemLogsAsync(SystemLogs entity);

		IQueryable<SystemMenu> GetSystemMenus();

		Task<SystemMenu> GetSystemMenuAsync(SystemMenu entity);

		Task<Int32> AddSystemMenuAsync(SystemMenu entity);

		Task<Int32> UpdateSystemMenuAsync(SystemMenu changes);

		Task<Int32> RemoveSystemMenuAsync(SystemMenu entity);

		IQueryable<SystemRole> GetSystemRoles();

		Task<SystemRole> GetSystemRoleAsync(SystemRole entity);

		Task<Int32> AddSystemRoleAsync(SystemRole entity);

		Task<Int32> UpdateSystemRoleAsync(SystemRole changes);

		Task<Int32> RemoveSystemRoleAsync(SystemRole entity);

		IQueryable<SystemRoleDictionary> GetSystemRoleDictionaries(Int32? roleId = null);

		Task<SystemRoleDictionary> GetSystemRoleDictionaryAsync(SystemRoleDictionary entity);

		Task<Int32> AddSystemRoleDictionaryAsync(SystemRoleDictionary entity);

		Task<Int32> UpdateSystemRoleDictionaryAsync(SystemRoleDictionary changes);

		Task<Int32> RemoveSystemRoleDictionaryAsync(SystemRoleDictionary entity);

		IQueryable<SystemRoleInMenu> GetSystemRoleInMenus();

		Task<Int32> AddSystemRoleInMenuAsync(SystemRoleInMenu entity);

		IQueryable<SystemUsers> GetSystemUsers();

		Task<SystemUsers> GetSystemUsersAsync(SystemUsers entity);

		Task<Int32> AddSystemUsersAsync(SystemUsers entity);

		Task<Int32> UpdateSystemUsersAsync(SystemUsers changes);

		Task<Int32> RemoveSystemUsersAsync(SystemUsers entity);

		IQueryable<SystemUsersDictionary> GetSystemUsersDictionaries(Int32? userId = null);

		Task<SystemUsersDictionary> GetSystemUsersDictionaryAsync(SystemUsersDictionary entity);

		Task<Int32> AddSystemUsersDictionaryAsync(SystemUsersDictionary entity);

		Task<Int32> UpdateSystemUsersDictionaryAsync(SystemUsersDictionary changes);

		Task<Int32> RemoveSystemUsersDictionaryAsync(SystemUsersDictionary entity);

		IQueryable<SystemUsersInMenu> GetSystemUsersInMenus();

		Task<Int32> AddSystemUsersInMenuAsync(SystemUsersInMenu entity);

		IQueryable<SystemUsersInRole> GetSystemUsersInRoles();

		Task<Int32> AddSystemUsersInRoleAsync(SystemUsersInRole entity);

		IQueryable<SystemUsersRefreshToken> GetSystemUsersRefreshTokens();

		Task<SystemUsersRefreshToken> GetSystemUsersRefreshTokenAsync(SystemUsersRefreshToken entity);

		Task<Int32> AddSystemUsersRefreshTokenAsync(SystemUsersRefreshToken entity);

		Task<Int32> UpdateSystemUsersRefreshTokenAsync(SystemUsersRefreshToken changes);

		Task<Int32> RemoveSystemUsersRefreshTokenAsync(SystemUsersRefreshToken entity);

		IQueryable<WebCategory> GetWebCategories();

		Task<WebCategory> GetWebCategoryAsync(WebCategory entity);

		Task<Int32> AddWebCategoryAsync(WebCategory entity);

		Task<Int32> UpdateWebCategoryAsync(WebCategory changes);

		Task<Int32> RemoveWebCategoryAsync(WebCategory entity);

		IQueryable<WebChannel> GetWebChannels();

		Task<WebChannel> GetWebChannelAsync(WebChannel entity);

		Task<Int32> AddWebChannelAsync(WebChannel entity);

		Task<Int32> UpdateWebChannelAsync(WebChannel changes);

		Task<Int32> RemoveWebChannelAsync(WebChannel entity);

		IQueryable<WebNews> GetWebNews(Int32? categoryId = null);

		Task<WebNews> GetWebNewsAsync(WebNews entity);

		Task<Int32> AddWebNewsAsync(WebNews entity);

		Task<Int32> UpdateWebNewsAsync(WebNews changes);

		Task<Int32> RemoveWebNewsAsync(WebNews entity);

		IQueryable<WebNewsOperateLogs> GetWebNewsOperateLogs(Int32? newsId = null);

		Task<WebNewsOperateLogs> GetWebNewsOperateLogsAsync(WebNewsOperateLogs entity);

		Task<Int32> AddWebNewsOperateLogsAsync(WebNewsOperateLogs entity);

		Task<Int32> UpdateWebNewsOperateLogsAsync(WebNewsOperateLogs changes);

		Task<Int32> RemoveWebNewsOperateLogsAsync(WebNewsOperateLogs entity);

		IQueryable<WebNewsSensitive> GetWebNewsSensitives();

		Task<WebNewsSensitive> GetWebNewsSensitiveAsync(WebNewsSensitive entity);

		Task<Int32> AddWebNewsSensitiveAsync(WebNewsSensitive entity);

		Task<Int32> UpdateWebNewsSensitiveAsync(WebNewsSensitive changes);

		Task<Int32> RemoveWebNewsSensitiveAsync(WebNewsSensitive entity);

		IQueryable<WebSensitive> GetWebSensitives();

		Task<WebSensitive> GetWebSensitiveAsync(WebSensitive entity);

		Task<Int32> AddWebSensitiveAsync(WebSensitive entity);

		Task<Int32> UpdateWebSensitiveAsync(WebSensitive changes);

		Task<Int32> RemoveWebSensitiveAsync(WebSensitive entity);

		IQueryable<WebSite> GetWebSites();

		Task<WebSite> GetWebSiteAsync(WebSite entity);

		Task<Int32> AddWebSiteAsync(WebSite entity);

		Task<Int32> UpdateWebSiteAsync(WebSite changes);

		Task<Int32> RemoveWebSiteAsync(WebSite entity);

		IQueryable<WebSpecial> GetWebSpecials();

		Task<WebSpecial> GetWebSpecialAsync(WebSpecial entity);

		Task<Int32> AddWebSpecialAsync(WebSpecial entity);

		Task<Int32> UpdateWebSpecialAsync(WebSpecial changes);

		Task<Int32> RemoveWebSpecialAsync(WebSpecial entity);
	}
}
