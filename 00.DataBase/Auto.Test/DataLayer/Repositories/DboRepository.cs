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
		public DboRepository(AutoNewsDbContext dbContext)
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

		public IQueryable<SystemRoleInMenu> GetSystemRoleInMenus()
		{
			// Get query from DbSet
			var query = DbContext.Set<SystemRoleInMenu>().AsQueryable();
			
			return query;
		}

		public async Task<Int32> AddSystemRoleInMenuAsync(SystemRoleInMenu entity)
		{
			// Add entity in DbSet
			Add(entity);
			
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

		public IQueryable<SystemUsersInMenu> GetSystemUsersInMenus()
		{
			// Get query from DbSet
			var query = DbContext.Set<SystemUsersInMenu>().AsQueryable();
			
			return query;
		}

		public async Task<Int32> AddSystemUsersInMenuAsync(SystemUsersInMenu entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<SystemUsersInRole> GetSystemUsersInRoles()
		{
			// Get query from DbSet
			var query = DbContext.Set<SystemUsersInRole>().AsQueryable();
			
			return query;
		}

		public async Task<Int32> AddSystemUsersInRoleAsync(SystemUsersInRole entity)
		{
			// Add entity in DbSet
			Add(entity);
			
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

		public IQueryable<WebNews> GetWebNews(Int32? categoryId = null)
		{
			// Get query from DbSet
			var query = DbContext.Set<WebNews>().AsQueryable();
			
			if (categoryId.HasValue)
			{
				// Filter by: 'CategoryId'
				query = query.Where(item => item.CategoryId == categoryId);
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

		public IQueryable<WebNewsOperateLogs> GetWebNewsOperateLogs(Int32? newsId = null)
		{
			// Get query from DbSet
			var query = DbContext.Set<WebNewsOperateLogs>().AsQueryable();
			
			if (newsId.HasValue)
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
	}
}
