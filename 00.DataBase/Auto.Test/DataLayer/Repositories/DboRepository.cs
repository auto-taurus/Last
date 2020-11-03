using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnLineStoreCore.EntityLayer;
using OnLineStoreCore.DataLayer.Contracts;

namespace OnLineStoreCore.DataLayer.Repositories
{
	public class DboRepository : Repository, IDboRepository
	{
		public DboRepository(MasterDbContext dbContext)
			: base(dbContext)
		{
		}

		public IQueryable<AutoBatchInsertNewsId> GetAutoBatchInsertNewsIds()
		{
			// Get query from DbSet
			var query = DbContext.Set<AutoBatchInsertNewsId>().AsQueryable();
			
			return query;
		}

		public async Task<AutoBatchInsertNewsId> GetAutoBatchInsertNewsIdAsync(AutoBatchInsertNewsId entity)
			=> await DbContext.Set<AutoBatchInsertNewsId>().FirstOrDefaultAsync(item => item.Id == entity.Id);

		public async Task<Int32> AddAutoBatchInsertNewsIdAsync(AutoBatchInsertNewsId entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateAutoBatchInsertNewsIdAsync(AutoBatchInsertNewsId changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveAutoBatchInsertNewsIdAsync(AutoBatchInsertNewsId entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<MemberComment> GetMemberComments(Int32? memberId = null, String newsId = null)
		{
			// Get query from DbSet
			var query = DbContext.Set<MemberComment>().AsQueryable();
			
			if (memberId.HasValue)
			{
				// Filter by: 'MemberId'
				query = query.Where(item => item.MemberId == memberId);
			}
			
			if (!string.IsNullOrEmpty(newsId))
			{
				// Filter by: 'NewsId'
				query = query.Where(item => item.NewsId == newsId);
			}
			
			return query;
		}

		public async Task<MemberComment> GetMemberCommentAsync(MemberComment entity)
			=> await DbContext.Set<MemberComment>().FirstOrDefaultAsync(item => item.CommentId == entity.CommentId);

		public async Task<Int32> AddMemberCommentAsync(MemberComment entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateMemberCommentAsync(MemberComment changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveMemberCommentAsync(MemberComment entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<MemberCommentSensitive> GetMemberCommentSensitives()
		{
			// Get query from DbSet
			var query = DbContext.Set<MemberCommentSensitive>().AsQueryable();
			
			return query;
		}

		public async Task<MemberCommentSensitive> GetMemberCommentSensitiveAsync(MemberCommentSensitive entity)
			=> await DbContext.Set<MemberCommentSensitive>().FirstOrDefaultAsync(item => item.CommentSensitiveId == entity.CommentSensitiveId);

		public async Task<Int32> AddMemberCommentSensitiveAsync(MemberCommentSensitive entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateMemberCommentSensitiveAsync(MemberCommentSensitive changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveMemberCommentSensitiveAsync(MemberCommentSensitive entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<MemberCommentUp> GetMemberCommentUps(Int32? commentId = null)
		{
			// Get query from DbSet
			var query = DbContext.Set<MemberCommentUp>().AsQueryable();
			
			if (commentId.HasValue)
			{
				// Filter by: 'CommentId'
				query = query.Where(item => item.CommentId == commentId);
			}
			
			return query;
		}

		public async Task<MemberCommentUp> GetMemberCommentUpAsync(MemberCommentUp entity)
			=> await DbContext.Set<MemberCommentUp>().FirstOrDefaultAsync(item => item.CommentUpId == entity.CommentUpId);

		public async Task<Int32> AddMemberCommentUpAsync(MemberCommentUp entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateMemberCommentUpAsync(MemberCommentUp changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveMemberCommentUpAsync(MemberCommentUp entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<MemberFans> GetMemberFans(Int32? memberId = null)
		{
			// Get query from DbSet
			var query = DbContext.Set<MemberFans>().AsQueryable();
			
			if (memberId.HasValue)
			{
				// Filter by: 'MemberId'
				query = query.Where(item => item.MemberId == memberId);
			}
			
			return query;
		}

		public async Task<MemberFans> GetMemberFansAsync(MemberFans entity)
			=> await DbContext.Set<MemberFans>().FirstOrDefaultAsync(item => item.FansId == entity.FansId);

		public async Task<Int32> AddMemberFansAsync(MemberFans entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateMemberFansAsync(MemberFans changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveMemberFansAsync(MemberFans entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<MemberFavorites> GetMemberFavorites(Int32? memberId = null)
		{
			// Get query from DbSet
			var query = DbContext.Set<MemberFavorites>().AsQueryable();
			
			if (memberId.HasValue)
			{
				// Filter by: 'MemberId'
				query = query.Where(item => item.MemberId == memberId);
			}
			
			return query;
		}

		public async Task<MemberFavorites> GetMemberFavoritesAsync(MemberFavorites entity)
			=> await DbContext.Set<MemberFavorites>().FirstOrDefaultAsync(item => item.FavoritesId == entity.FavoritesId);

		public async Task<Int32> AddMemberFavoritesAsync(MemberFavorites entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateMemberFavoritesAsync(MemberFavorites changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveMemberFavoritesAsync(MemberFavorites entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<MemberFollow> GetMemberFollows(Int32? memberId = null)
		{
			// Get query from DbSet
			var query = DbContext.Set<MemberFollow>().AsQueryable();
			
			if (memberId.HasValue)
			{
				// Filter by: 'MemberId'
				query = query.Where(item => item.MemberId == memberId);
			}
			
			return query;
		}

		public async Task<MemberFollow> GetMemberFollowAsync(MemberFollow entity)
			=> await DbContext.Set<MemberFollow>().FirstOrDefaultAsync(item => item.FollowId == entity.FollowId);

		public async Task<Int32> AddMemberFollowAsync(MemberFollow entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateMemberFollowAsync(MemberFollow changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveMemberFollowAsync(MemberFollow entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<MemberFootprint> GetMemberFootprints(Int32? memberId = null)
		{
			// Get query from DbSet
			var query = DbContext.Set<MemberFootprint>().AsQueryable();
			
			if (memberId.HasValue)
			{
				// Filter by: 'MemberId'
				query = query.Where(item => item.MemberId == memberId);
			}
			
			return query;
		}

		public async Task<MemberFootprint> GetMemberFootprintAsync(MemberFootprint entity)
			=> await DbContext.Set<MemberFootprint>().FirstOrDefaultAsync(item => item.FootprintId == entity.FootprintId);

		public async Task<Int32> AddMemberFootprintAsync(MemberFootprint entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateMemberFootprintAsync(MemberFootprint changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveMemberFootprintAsync(MemberFootprint entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<MemberIncome> GetMemberIncomes(Int32? memberId = null, Int32? taskId = null)
		{
			// Get query from DbSet
			var query = DbContext.Set<MemberIncome>().AsQueryable();
			
			if (memberId.HasValue)
			{
				// Filter by: 'MemberId'
				query = query.Where(item => item.MemberId == memberId);
			}
			
			if (taskId.HasValue)
			{
				// Filter by: 'TaskId'
				query = query.Where(item => item.TaskId == taskId);
			}
			
			return query;
		}

		public async Task<MemberIncome> GetMemberIncomeAsync(MemberIncome entity)
			=> await DbContext.Set<MemberIncome>().FirstOrDefaultAsync(item => item.IncomeId == entity.IncomeId);

		public async Task<Int32> AddMemberIncomeAsync(MemberIncome entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateMemberIncomeAsync(MemberIncome changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveMemberIncomeAsync(MemberIncome entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<MemberInfos> GetMemberInfos()
		{
			// Get query from DbSet
			var query = DbContext.Set<MemberInfos>().AsQueryable();
			
			return query;
		}

		public async Task<MemberInfos> GetMemberInfosAsync(MemberInfos entity)
			=> await DbContext.Set<MemberInfos>().FirstOrDefaultAsync(item => item.MemberId == entity.MemberId);

		public async Task<Int32> AddMemberInfosAsync(MemberInfos entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateMemberInfosAsync(MemberInfos changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveMemberInfosAsync(MemberInfos entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<MemberLoginLog> GetMemberLoginLogs()
		{
			// Get query from DbSet
			var query = DbContext.Set<MemberLoginLog>().AsQueryable();
			
			return query;
		}

		public async Task<MemberLoginLog> GetMemberLoginLogAsync(MemberLoginLog entity)
			=> await DbContext.Set<MemberLoginLog>().FirstOrDefaultAsync(item => item.LoginLogId == entity.LoginLogId);

		public async Task<Int32> AddMemberLoginLogAsync(MemberLoginLog entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateMemberLoginLogAsync(MemberLoginLog changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveMemberLoginLogAsync(MemberLoginLog entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<MemberMessage> GetMemberMessages(Int32? memberId = null)
		{
			// Get query from DbSet
			var query = DbContext.Set<MemberMessage>().AsQueryable();
			
			if (memberId.HasValue)
			{
				// Filter by: 'MemberId'
				query = query.Where(item => item.MemberId == memberId);
			}
			
			return query;
		}

		public async Task<MemberMessage> GetMemberMessageAsync(MemberMessage entity)
			=> await DbContext.Set<MemberMessage>().FirstOrDefaultAsync(item => item.MessageId == entity.MessageId);

		public async Task<Int32> AddMemberMessageAsync(MemberMessage entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateMemberMessageAsync(MemberMessage changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveMemberMessageAsync(MemberMessage entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<MemberProblem> GetMemberProblems()
		{
			// Get query from DbSet
			var query = DbContext.Set<MemberProblem>().AsQueryable();
			
			return query;
		}

		public async Task<MemberProblem> GetMemberProblemAsync(MemberProblem entity)
			=> await DbContext.Set<MemberProblem>().FirstOrDefaultAsync(item => item.ProblemId == entity.ProblemId);

		public async Task<Int32> AddMemberProblemAsync(MemberProblem entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateMemberProblemAsync(MemberProblem changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveMemberProblemAsync(MemberProblem entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<MemberWithdraw> GetMemberWithdraws(Int32? memberId = null)
		{
			// Get query from DbSet
			var query = DbContext.Set<MemberWithdraw>().AsQueryable();
			
			if (memberId.HasValue)
			{
				// Filter by: 'MemberId'
				query = query.Where(item => item.MemberId == memberId);
			}
			
			return query;
		}

		public async Task<MemberWithdraw> GetMemberWithdrawAsync(MemberWithdraw entity)
			=> await DbContext.Set<MemberWithdraw>().FirstOrDefaultAsync(item => item.WithdrawId == entity.WithdrawId);

		public async Task<Int32> AddMemberWithdrawAsync(MemberWithdraw entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateMemberWithdrawAsync(MemberWithdraw changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveMemberWithdrawAsync(MemberWithdraw entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<MemberWithdrawConfig> GetMemberWithdrawConfigs()
		{
			// Get query from DbSet
			var query = DbContext.Set<MemberWithdrawConfig>().AsQueryable();
			
			return query;
		}

		public async Task<MemberWithdrawConfig> GetMemberWithdrawConfigAsync(MemberWithdrawConfig entity)
			=> await DbContext.Set<MemberWithdrawConfig>().FirstOrDefaultAsync(item => item.WithdrawConfigId == entity.WithdrawConfigId);

		public async Task<Int32> AddMemberWithdrawConfigAsync(MemberWithdrawConfig entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateMemberWithdrawConfigAsync(MemberWithdrawConfig changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveMemberWithdrawConfigAsync(MemberWithdrawConfig entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<ReportCategoryDayAccess> GetReportCategoryDayAccesses()
		{
			// Get query from DbSet
			var query = DbContext.Set<ReportCategoryDayAccess>().AsQueryable();
			
			return query;
		}

		public async Task<ReportCategoryDayAccess> GetReportCategoryDayAccessAsync(ReportCategoryDayAccess entity)
			=> await DbContext.Set<ReportCategoryDayAccess>().FirstOrDefaultAsync(item => item.CategoryAccessId == entity.CategoryAccessId);

		public async Task<Int32> AddReportCategoryDayAccessAsync(ReportCategoryDayAccess entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateReportCategoryDayAccessAsync(ReportCategoryDayAccess changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveReportCategoryDayAccessAsync(ReportCategoryDayAccess entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<ReportCategoryDayClick> GetReportCategoryDayClicks()
		{
			// Get query from DbSet
			var query = DbContext.Set<ReportCategoryDayClick>().AsQueryable();
			
			return query;
		}

		public async Task<ReportCategoryDayClick> GetReportCategoryDayClickAsync(ReportCategoryDayClick entity)
			=> await DbContext.Set<ReportCategoryDayClick>().FirstOrDefaultAsync(item => item.CategoryClickId == entity.CategoryClickId);

		public async Task<Int32> AddReportCategoryDayClickAsync(ReportCategoryDayClick entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateReportCategoryDayClickAsync(ReportCategoryDayClick changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveReportCategoryDayClickAsync(ReportCategoryDayClick entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<ReportNewsDayAccess> GetReportNewsDayAccesses()
		{
			// Get query from DbSet
			var query = DbContext.Set<ReportNewsDayAccess>().AsQueryable();
			
			return query;
		}

		public async Task<ReportNewsDayAccess> GetReportNewsDayAccessAsync(ReportNewsDayAccess entity)
			=> await DbContext.Set<ReportNewsDayAccess>().FirstOrDefaultAsync(item => item.NewsAccessId == entity.NewsAccessId);

		public async Task<Int32> AddReportNewsDayAccessAsync(ReportNewsDayAccess entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateReportNewsDayAccessAsync(ReportNewsDayAccess changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveReportNewsDayAccessAsync(ReportNewsDayAccess entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<ReportNewsDayClick> GetReportNewsDayClicks()
		{
			// Get query from DbSet
			var query = DbContext.Set<ReportNewsDayClick>().AsQueryable();
			
			return query;
		}

		public async Task<ReportNewsDayClick> GetReportNewsDayClickAsync(ReportNewsDayClick entity)
			=> await DbContext.Set<ReportNewsDayClick>().FirstOrDefaultAsync(item => item.NewsClickId == entity.NewsClickId);

		public async Task<Int32> AddReportNewsDayClickAsync(ReportNewsDayClick entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateReportNewsDayClickAsync(ReportNewsDayClick changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveReportNewsDayClickAsync(ReportNewsDayClick entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<ReportSiteDayAccess> GetReportSiteDayAccesses()
		{
			// Get query from DbSet
			var query = DbContext.Set<ReportSiteDayAccess>().AsQueryable();
			
			return query;
		}

		public async Task<ReportSiteDayAccess> GetReportSiteDayAccessAsync(ReportSiteDayAccess entity)
			=> await DbContext.Set<ReportSiteDayAccess>().FirstOrDefaultAsync(item => item.SiteAccessId == entity.SiteAccessId);

		public async Task<Int32> AddReportSiteDayAccessAsync(ReportSiteDayAccess entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateReportSiteDayAccessAsync(ReportSiteDayAccess changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveReportSiteDayAccessAsync(ReportSiteDayAccess entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<SystemDictionary> GetSystemDictionaries()
		{
			// Get query from DbSet
			var query = DbContext.Set<SystemDictionary>().AsQueryable();
			
			return query;
		}

		public async Task<SystemDictionary> GetSystemDictionaryAsync(SystemDictionary entity)
			=> await DbContext.Set<SystemDictionary>().FirstOrDefaultAsync(item => item.DictionaryId == entity.DictionaryId);

		public async Task<Int32> AddSystemDictionaryAsync(SystemDictionary entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateSystemDictionaryAsync(SystemDictionary changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveSystemDictionaryAsync(SystemDictionary entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<SystemLogs> GetSystemLogs()
		{
			// Get query from DbSet
			var query = DbContext.Set<SystemLogs>().AsQueryable();
			
			return query;
		}

		public async Task<SystemLogs> GetSystemLogsAsync(SystemLogs entity)
			=> await DbContext.Set<SystemLogs>().FirstOrDefaultAsync(item => item.LogsId == entity.LogsId);

		public async Task<Int32> AddSystemLogsAsync(SystemLogs entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateSystemLogsAsync(SystemLogs changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveSystemLogsAsync(SystemLogs entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<SystemMenu> GetSystemMenus()
		{
			// Get query from DbSet
			var query = DbContext.Set<SystemMenu>().AsQueryable();
			
			return query;
		}

		public async Task<SystemMenu> GetSystemMenuAsync(SystemMenu entity)
			=> await DbContext.Set<SystemMenu>().FirstOrDefaultAsync(item => item.MenuId == entity.MenuId);

		public async Task<Int32> AddSystemMenuAsync(SystemMenu entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateSystemMenuAsync(SystemMenu changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveSystemMenuAsync(SystemMenu entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<SystemRole> GetSystemRoles()
		{
			// Get query from DbSet
			var query = DbContext.Set<SystemRole>().AsQueryable();
			
			return query;
		}

		public async Task<SystemRole> GetSystemRoleAsync(SystemRole entity)
			=> await DbContext.Set<SystemRole>().FirstOrDefaultAsync(item => item.RoleId == entity.RoleId);

		public async Task<Int32> AddSystemRoleAsync(SystemRole entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateSystemRoleAsync(SystemRole changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveSystemRoleAsync(SystemRole entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<SystemRoleDictionary> GetSystemRoleDictionaries(Int32? roleId = null)
		{
			// Get query from DbSet
			var query = DbContext.Set<SystemRoleDictionary>().AsQueryable();
			
			if (roleId.HasValue)
			{
				// Filter by: 'RoleId'
				query = query.Where(item => item.RoleId == roleId);
			}
			
			return query;
		}

		public async Task<SystemRoleDictionary> GetSystemRoleDictionaryAsync(SystemRoleDictionary entity)
			=> await DbContext.Set<SystemRoleDictionary>().FirstOrDefaultAsync(item => item.Id == entity.Id);

		public async Task<Int32> AddSystemRoleDictionaryAsync(SystemRoleDictionary entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateSystemRoleDictionaryAsync(SystemRoleDictionary changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveSystemRoleDictionaryAsync(SystemRoleDictionary entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<SystemRoleInMenu> GetSystemRoleInMenus(Int32? menuId = null, Int32? roleId = null)
		{
			// Get query from DbSet
			var query = DbContext.Set<SystemRoleInMenu>().AsQueryable();
			
			if (menuId.HasValue)
			{
				// Filter by: 'MenuId'
				query = query.Where(item => item.MenuId == menuId);
			}
			
			if (roleId.HasValue)
			{
				// Filter by: 'RoleId'
				query = query.Where(item => item.RoleId == roleId);
			}
			
			return query;
		}

		public async Task<SystemRoleInMenu> GetSystemRoleInMenuAsync(SystemRoleInMenu entity)
			=> await DbContext.Set<SystemRoleInMenu>().FirstOrDefaultAsync(item => item.Id == entity.Id);

		public async Task<Int32> AddSystemRoleInMenuAsync(SystemRoleInMenu entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateSystemRoleInMenuAsync(SystemRoleInMenu changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveSystemRoleInMenuAsync(SystemRoleInMenu entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<SystemUsers> GetSystemUsers()
		{
			// Get query from DbSet
			var query = DbContext.Set<SystemUsers>().AsQueryable();
			
			return query;
		}

		public async Task<SystemUsers> GetSystemUsersAsync(SystemUsers entity)
			=> await DbContext.Set<SystemUsers>().FirstOrDefaultAsync(item => item.UsersId == entity.UsersId);

		public async Task<Int32> AddSystemUsersAsync(SystemUsers entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateSystemUsersAsync(SystemUsers changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveSystemUsersAsync(SystemUsers entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<SystemUsersDictionary> GetSystemUsersDictionaries(Int32? userId = null)
		{
			// Get query from DbSet
			var query = DbContext.Set<SystemUsersDictionary>().AsQueryable();
			
			if (userId.HasValue)
			{
				// Filter by: 'UserId'
				query = query.Where(item => item.UserId == userId);
			}
			
			return query;
		}

		public async Task<SystemUsersDictionary> GetSystemUsersDictionaryAsync(SystemUsersDictionary entity)
			=> await DbContext.Set<SystemUsersDictionary>().FirstOrDefaultAsync(item => item.Id == entity.Id);

		public async Task<Int32> AddSystemUsersDictionaryAsync(SystemUsersDictionary entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateSystemUsersDictionaryAsync(SystemUsersDictionary changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveSystemUsersDictionaryAsync(SystemUsersDictionary entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<SystemUsersInMenu> GetSystemUsersInMenus(Int32? menuId = null, Int32? userId = null)
		{
			// Get query from DbSet
			var query = DbContext.Set<SystemUsersInMenu>().AsQueryable();
			
			if (menuId.HasValue)
			{
				// Filter by: 'MenuId'
				query = query.Where(item => item.MenuId == menuId);
			}
			
			if (userId.HasValue)
			{
				// Filter by: 'UserId'
				query = query.Where(item => item.UserId == userId);
			}
			
			return query;
		}

		public async Task<SystemUsersInMenu> GetSystemUsersInMenuAsync(SystemUsersInMenu entity)
			=> await DbContext.Set<SystemUsersInMenu>().FirstOrDefaultAsync(item => item.Id == entity.Id);

		public async Task<Int32> AddSystemUsersInMenuAsync(SystemUsersInMenu entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateSystemUsersInMenuAsync(SystemUsersInMenu changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveSystemUsersInMenuAsync(SystemUsersInMenu entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<SystemUsersInRole> GetSystemUsersInRoles(Int32? roleId = null, Int32? usersId = null)
		{
			// Get query from DbSet
			var query = DbContext.Set<SystemUsersInRole>().AsQueryable();
			
			if (roleId.HasValue)
			{
				// Filter by: 'RoleId'
				query = query.Where(item => item.RoleId == roleId);
			}
			
			if (usersId.HasValue)
			{
				// Filter by: 'UsersId'
				query = query.Where(item => item.UsersId == usersId);
			}
			
			return query;
		}

		public async Task<SystemUsersInRole> GetSystemUsersInRoleAsync(SystemUsersInRole entity)
			=> await DbContext.Set<SystemUsersInRole>().FirstOrDefaultAsync(item => item.Id == entity.Id);

		public async Task<Int32> AddSystemUsersInRoleAsync(SystemUsersInRole entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateSystemUsersInRoleAsync(SystemUsersInRole changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveSystemUsersInRoleAsync(SystemUsersInRole entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<SystemUsersRefreshToken> GetSystemUsersRefreshTokens()
		{
			// Get query from DbSet
			var query = DbContext.Set<SystemUsersRefreshToken>().AsQueryable();
			
			return query;
		}

		public async Task<SystemUsersRefreshToken> GetSystemUsersRefreshTokenAsync(SystemUsersRefreshToken entity)
			=> await DbContext.Set<SystemUsersRefreshToken>().FirstOrDefaultAsync(item => item.RefreshTokenId == entity.RefreshTokenId);

		public async Task<Int32> AddSystemUsersRefreshTokenAsync(SystemUsersRefreshToken entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateSystemUsersRefreshTokenAsync(SystemUsersRefreshToken changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveSystemUsersRefreshTokenAsync(SystemUsersRefreshToken entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<TaskInfo> GetTaskInfos()
		{
			// Get query from DbSet
			var query = DbContext.Set<TaskInfo>().AsQueryable();
			
			return query;
		}

		public async Task<TaskInfo> GetTaskInfoAsync(TaskInfo entity)
			=> await DbContext.Set<TaskInfo>().FirstOrDefaultAsync(item => item.TaskId == entity.TaskId);

		public async Task<Int32> AddTaskInfoAsync(TaskInfo entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateTaskInfoAsync(TaskInfo changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveTaskInfoAsync(TaskInfo entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<WebCategory> GetWebCategories()
		{
			// Get query from DbSet
			var query = DbContext.Set<WebCategory>().AsQueryable();
			
			return query;
		}

		public async Task<WebCategory> GetWebCategoryAsync(WebCategory entity)
			=> await DbContext.Set<WebCategory>().FirstOrDefaultAsync(item => item.CategoryId == entity.CategoryId);

		public async Task<Int32> AddWebCategoryAsync(WebCategory entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateWebCategoryAsync(WebCategory changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveWebCategoryAsync(WebCategory entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<WebChannel> GetWebChannels()
		{
			// Get query from DbSet
			var query = DbContext.Set<WebChannel>().AsQueryable();
			
			return query;
		}

		public async Task<WebChannel> GetWebChannelAsync(WebChannel entity)
			=> await DbContext.Set<WebChannel>().FirstOrDefaultAsync(item => item.ChannelId == entity.ChannelId);

		public async Task<Int32> AddWebChannelAsync(WebChannel entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateWebChannelAsync(WebChannel changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveWebChannelAsync(WebChannel entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<WebNews> GetWebNews(Int32? categoryId = null, Int32? sourceId = null)
		{
			// Get query from DbSet
			var query = DbContext.Set<WebNews>().AsQueryable();
			
			if (categoryId.HasValue)
			{
				// Filter by: 'CategoryId'
				query = query.Where(item => item.CategoryId == categoryId);
			}
			
			if (sourceId.HasValue)
			{
				// Filter by: 'SourceId'
				query = query.Where(item => item.SourceId == sourceId);
			}
			
			return query;
		}

		public async Task<WebNews> GetWebNewsAsync(WebNews entity)
			=> await DbContext.Set<WebNews>().FirstOrDefaultAsync(item => item.NewsId == entity.NewsId);

		public async Task<Int32> AddWebNewsAsync(WebNews entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateWebNewsAsync(WebNews changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveWebNewsAsync(WebNews entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<WebNewsOperateLogs> GetWebNewsOperateLogs(String newsId = null)
		{
			// Get query from DbSet
			var query = DbContext.Set<WebNewsOperateLogs>().AsQueryable();
			
			if (!string.IsNullOrEmpty(newsId))
			{
				// Filter by: 'NewsId'
				query = query.Where(item => item.NewsId == newsId);
			}
			
			return query;
		}

		public async Task<WebNewsOperateLogs> GetWebNewsOperateLogsAsync(WebNewsOperateLogs entity)
			=> await DbContext.Set<WebNewsOperateLogs>().FirstOrDefaultAsync(item => item.NewsOperateId == entity.NewsOperateId);

		public async Task<Int32> AddWebNewsOperateLogsAsync(WebNewsOperateLogs entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateWebNewsOperateLogsAsync(WebNewsOperateLogs changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveWebNewsOperateLogsAsync(WebNewsOperateLogs entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<WebNewsSensitive> GetWebNewsSensitives()
		{
			// Get query from DbSet
			var query = DbContext.Set<WebNewsSensitive>().AsQueryable();
			
			return query;
		}

		public async Task<WebNewsSensitive> GetWebNewsSensitiveAsync(WebNewsSensitive entity)
			=> await DbContext.Set<WebNewsSensitive>().FirstOrDefaultAsync(item => item.NewsSensitiveId == entity.NewsSensitiveId);

		public async Task<Int32> AddWebNewsSensitiveAsync(WebNewsSensitive entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateWebNewsSensitiveAsync(WebNewsSensitive changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveWebNewsSensitiveAsync(WebNewsSensitive entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<WebSensitive> GetWebSensitives()
		{
			// Get query from DbSet
			var query = DbContext.Set<WebSensitive>().AsQueryable();
			
			return query;
		}

		public async Task<WebSensitive> GetWebSensitiveAsync(WebSensitive entity)
			=> await DbContext.Set<WebSensitive>().FirstOrDefaultAsync(item => item.SensitiveId == entity.SensitiveId);

		public async Task<Int32> AddWebSensitiveAsync(WebSensitive entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateWebSensitiveAsync(WebSensitive changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveWebSensitiveAsync(WebSensitive entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<WebSite> GetWebSites()
		{
			// Get query from DbSet
			var query = DbContext.Set<WebSite>().AsQueryable();
			
			return query;
		}

		public async Task<WebSite> GetWebSiteAsync(WebSite entity)
			=> await DbContext.Set<WebSite>().FirstOrDefaultAsync(item => item.SiteId == entity.SiteId);

		public async Task<Int32> AddWebSiteAsync(WebSite entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateWebSiteAsync(WebSite changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveWebSiteAsync(WebSite entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<WebSource> GetWebSources(Int32? categoryId = null)
		{
			// Get query from DbSet
			var query = DbContext.Set<WebSource>().AsQueryable();
			
			if (categoryId.HasValue)
			{
				// Filter by: 'CategoryId'
				query = query.Where(item => item.CategoryId == categoryId);
			}
			
			return query;
		}

		public async Task<WebSource> GetWebSourceAsync(WebSource entity)
			=> await DbContext.Set<WebSource>().FirstOrDefaultAsync(item => item.SourceId == entity.SourceId);

		public async Task<Int32> AddWebSourceAsync(WebSource entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateWebSourceAsync(WebSource changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveWebSourceAsync(WebSource entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<WebSpecial> GetWebSpecials()
		{
			// Get query from DbSet
			var query = DbContext.Set<WebSpecial>().AsQueryable();
			
			return query;
		}

		public async Task<WebSpecial> GetWebSpecialAsync(WebSpecial entity)
			=> await DbContext.Set<WebSpecial>().FirstOrDefaultAsync(item => item.SpecialId == entity.SpecialId);

		public async Task<Int32> AddWebSpecialAsync(WebSpecial entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> UpdateWebSpecialAsync(WebSpecial changes)
		{
			// Update entity in DbSet
			Update(changes);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public async Task<Int32> RemoveWebSpecialAsync(WebSpecial entity)
		{
			// Remove entity from DbSet
			Remove(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<SptValues> GetSptValues()
			=> DbContext.Set<SptValues>();
	}
}
