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

		public IQueryable<MSreplicationOptions> GetMSreplicationOptions()
		{
			// Get query from DbSet
			var query = DbContext.Set<MSreplicationOptions>().AsQueryable();
			
			return query;
		}

		public async Task<Int32> AddMSreplicationOptionsAsync(MSreplicationOptions entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<SptFallbackDb> GetSptFallbackDbs()
		{
			// Get query from DbSet
			var query = DbContext.Set<SptFallbackDb>().AsQueryable();
			
			return query;
		}

		public async Task<Int32> AddSptFallbackDbAsync(SptFallbackDb entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<SptFallbackDev> GetSptFallbackDevs()
		{
			// Get query from DbSet
			var query = DbContext.Set<SptFallbackDev>().AsQueryable();
			
			return query;
		}

		public async Task<Int32> AddSptFallbackDevAsync(SptFallbackDev entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<SptFallbackUsg> GetSptFallbackUsgs()
		{
			// Get query from DbSet
			var query = DbContext.Set<SptFallbackUsg>().AsQueryable();
			
			return query;
		}

		public async Task<Int32> AddSptFallbackUsgAsync(SptFallbackUsg entity)
		{
			// Add entity in DbSet
			Add(entity);
			
			// Save changes through DbContext
			return await CommitChangesAsync();
		}

		public IQueryable<SptMonitor> GetSptMonitors()
		{
			// Get query from DbSet
			var query = DbContext.Set<SptMonitor>().AsQueryable();
			
			return query;
		}

		public async Task<Int32> AddSptMonitorAsync(SptMonitor entity)
		{
			// Add entity in DbSet
			Add(entity);
			
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

		public IQueryable<SptValues> GetSptValues()
			=> DbContext.Set<SptValues>();
	}
}
