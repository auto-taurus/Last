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

		IQueryable<MemberComment> GetMemberComments(Int32? memberId = null, String newsId = null);

		Task<MemberComment> GetMemberCommentAsync(MemberComment entity);

		Task<Int32> AddMemberCommentAsync(MemberComment entity);

		Task<Int32> UpdateMemberCommentAsync(MemberComment changes);

		Task<Int32> RemoveMemberCommentAsync(MemberComment entity);

		IQueryable<MemberCommentSensitive> GetMemberCommentSensitives();

		Task<MemberCommentSensitive> GetMemberCommentSensitiveAsync(MemberCommentSensitive entity);

		Task<Int32> AddMemberCommentSensitiveAsync(MemberCommentSensitive entity);

		Task<Int32> UpdateMemberCommentSensitiveAsync(MemberCommentSensitive changes);

		Task<Int32> RemoveMemberCommentSensitiveAsync(MemberCommentSensitive entity);

		IQueryable<MemberCommentUp> GetMemberCommentUps(Int32? commentId = null);

		Task<MemberCommentUp> GetMemberCommentUpAsync(MemberCommentUp entity);

		Task<Int32> AddMemberCommentUpAsync(MemberCommentUp entity);

		Task<Int32> UpdateMemberCommentUpAsync(MemberCommentUp changes);

		Task<Int32> RemoveMemberCommentUpAsync(MemberCommentUp entity);

		IQueryable<MemberFans> GetMemberFans(Int32? memberId = null);

		Task<MemberFans> GetMemberFansAsync(MemberFans entity);

		Task<Int32> AddMemberFansAsync(MemberFans entity);

		Task<Int32> UpdateMemberFansAsync(MemberFans changes);

		Task<Int32> RemoveMemberFansAsync(MemberFans entity);

		IQueryable<MemberFavorites> GetMemberFavorites(Int32? memberId = null);

		Task<MemberFavorites> GetMemberFavoritesAsync(MemberFavorites entity);

		Task<Int32> AddMemberFavoritesAsync(MemberFavorites entity);

		Task<Int32> UpdateMemberFavoritesAsync(MemberFavorites changes);

		Task<Int32> RemoveMemberFavoritesAsync(MemberFavorites entity);

		IQueryable<MemberFollow> GetMemberFollows(Int32? memberId = null);

		Task<MemberFollow> GetMemberFollowAsync(MemberFollow entity);

		Task<Int32> AddMemberFollowAsync(MemberFollow entity);

		Task<Int32> UpdateMemberFollowAsync(MemberFollow changes);

		Task<Int32> RemoveMemberFollowAsync(MemberFollow entity);

		IQueryable<MemberFootprint> GetMemberFootprints(Int32? memberId = null);

		Task<MemberFootprint> GetMemberFootprintAsync(MemberFootprint entity);

		Task<Int32> AddMemberFootprintAsync(MemberFootprint entity);

		Task<Int32> UpdateMemberFootprintAsync(MemberFootprint changes);

		Task<Int32> RemoveMemberFootprintAsync(MemberFootprint entity);

		IQueryable<MemberIncome> GetMemberIncomes(Int32? memberId = null, Int32? taskId = null);

		Task<MemberIncome> GetMemberIncomeAsync(MemberIncome entity);

		Task<Int32> AddMemberIncomeAsync(MemberIncome entity);

		Task<Int32> UpdateMemberIncomeAsync(MemberIncome changes);

		Task<Int32> RemoveMemberIncomeAsync(MemberIncome entity);

		IQueryable<MemberInfos> GetMemberInfos();

		Task<MemberInfos> GetMemberInfosAsync(MemberInfos entity);

		Task<Int32> AddMemberInfosAsync(MemberInfos entity);

		Task<Int32> UpdateMemberInfosAsync(MemberInfos changes);

		Task<Int32> RemoveMemberInfosAsync(MemberInfos entity);

		IQueryable<MemberLoginLog> GetMemberLoginLogs();

		Task<MemberLoginLog> GetMemberLoginLogAsync(MemberLoginLog entity);

		Task<Int32> AddMemberLoginLogAsync(MemberLoginLog entity);

		Task<Int32> UpdateMemberLoginLogAsync(MemberLoginLog changes);

		Task<Int32> RemoveMemberLoginLogAsync(MemberLoginLog entity);

		IQueryable<MemberMessage> GetMemberMessages(Int32? memberId = null);

		Task<MemberMessage> GetMemberMessageAsync(MemberMessage entity);

		Task<Int32> AddMemberMessageAsync(MemberMessage entity);

		Task<Int32> UpdateMemberMessageAsync(MemberMessage changes);

		Task<Int32> RemoveMemberMessageAsync(MemberMessage entity);

		IQueryable<MemberProblem> GetMemberProblems();

		Task<MemberProblem> GetMemberProblemAsync(MemberProblem entity);

		Task<Int32> AddMemberProblemAsync(MemberProblem entity);

		Task<Int32> UpdateMemberProblemAsync(MemberProblem changes);

		Task<Int32> RemoveMemberProblemAsync(MemberProblem entity);

		IQueryable<MemberWithdraw> GetMemberWithdraws(Int32? memberId = null);

		Task<MemberWithdraw> GetMemberWithdrawAsync(MemberWithdraw entity);

		Task<Int32> AddMemberWithdrawAsync(MemberWithdraw entity);

		Task<Int32> UpdateMemberWithdrawAsync(MemberWithdraw changes);

		Task<Int32> RemoveMemberWithdrawAsync(MemberWithdraw entity);

		IQueryable<MemberWithdrawConfig> GetMemberWithdrawConfigs();

		Task<MemberWithdrawConfig> GetMemberWithdrawConfigAsync(MemberWithdrawConfig entity);

		Task<Int32> AddMemberWithdrawConfigAsync(MemberWithdrawConfig entity);

		Task<Int32> UpdateMemberWithdrawConfigAsync(MemberWithdrawConfig changes);

		Task<Int32> RemoveMemberWithdrawConfigAsync(MemberWithdrawConfig entity);

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

		IQueryable<SystemRoleInMenu> GetSystemRoleInMenus(Int32? menuId = null, Int32? roleId = null);

		Task<SystemRoleInMenu> GetSystemRoleInMenuAsync(SystemRoleInMenu entity);

		Task<Int32> AddSystemRoleInMenuAsync(SystemRoleInMenu entity);

		Task<Int32> UpdateSystemRoleInMenuAsync(SystemRoleInMenu changes);

		Task<Int32> RemoveSystemRoleInMenuAsync(SystemRoleInMenu entity);

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

		IQueryable<SystemUsersInMenu> GetSystemUsersInMenus(Int32? menuId = null, Int32? userId = null);

		Task<SystemUsersInMenu> GetSystemUsersInMenuAsync(SystemUsersInMenu entity);

		Task<Int32> AddSystemUsersInMenuAsync(SystemUsersInMenu entity);

		Task<Int32> UpdateSystemUsersInMenuAsync(SystemUsersInMenu changes);

		Task<Int32> RemoveSystemUsersInMenuAsync(SystemUsersInMenu entity);

		IQueryable<SystemUsersInRole> GetSystemUsersInRoles(Int32? roleId = null, Int32? usersId = null);

		Task<SystemUsersInRole> GetSystemUsersInRoleAsync(SystemUsersInRole entity);

		Task<Int32> AddSystemUsersInRoleAsync(SystemUsersInRole entity);

		Task<Int32> UpdateSystemUsersInRoleAsync(SystemUsersInRole changes);

		Task<Int32> RemoveSystemUsersInRoleAsync(SystemUsersInRole entity);

		IQueryable<SystemUsersRefreshToken> GetSystemUsersRefreshTokens();

		Task<SystemUsersRefreshToken> GetSystemUsersRefreshTokenAsync(SystemUsersRefreshToken entity);

		Task<Int32> AddSystemUsersRefreshTokenAsync(SystemUsersRefreshToken entity);

		Task<Int32> UpdateSystemUsersRefreshTokenAsync(SystemUsersRefreshToken changes);

		Task<Int32> RemoveSystemUsersRefreshTokenAsync(SystemUsersRefreshToken entity);

		IQueryable<TaskInfo> GetTaskInfos();

		Task<TaskInfo> GetTaskInfoAsync(TaskInfo entity);

		Task<Int32> AddTaskInfoAsync(TaskInfo entity);

		Task<Int32> UpdateTaskInfoAsync(TaskInfo changes);

		Task<Int32> RemoveTaskInfoAsync(TaskInfo entity);

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

		IQueryable<WebNews> GetWebNews(Int32? categoryId = null, Int32? sourceId = null);

		Task<WebNews> GetWebNewsAsync(WebNews entity);

		Task<Int32> AddWebNewsAsync(WebNews entity);

		Task<Int32> UpdateWebNewsAsync(WebNews changes);

		Task<Int32> RemoveWebNewsAsync(WebNews entity);

		IQueryable<WebNewsOperateLogs> GetWebNewsOperateLogs(String newsId = null);

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

		IQueryable<WebSource> GetWebSources(Int32? categoryId = null);

		Task<WebSource> GetWebSourceAsync(WebSource entity);

		Task<Int32> AddWebSourceAsync(WebSource entity);

		Task<Int32> UpdateWebSourceAsync(WebSource changes);

		Task<Int32> RemoveWebSourceAsync(WebSource entity);

		IQueryable<WebSpecial> GetWebSpecials();

		Task<WebSpecial> GetWebSpecialAsync(WebSpecial entity);

		Task<Int32> AddWebSpecialAsync(WebSpecial entity);

		Task<Int32> UpdateWebSpecialAsync(WebSpecial changes);

		Task<Int32> RemoveWebSpecialAsync(WebSpecial entity);

		IQueryable<SptValues> GetSptValues();
	}
}
