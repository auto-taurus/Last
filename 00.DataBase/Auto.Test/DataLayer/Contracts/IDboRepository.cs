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
		IQueryable<MSreplicationOptions> GetMSreplicationOptions();

		Task<Int32> AddMSreplicationOptionsAsync(MSreplicationOptions entity);

		IQueryable<SptFallbackDb> GetSptFallbackDbs();

		Task<Int32> AddSptFallbackDbAsync(SptFallbackDb entity);

		IQueryable<SptFallbackDev> GetSptFallbackDevs();

		Task<Int32> AddSptFallbackDevAsync(SptFallbackDev entity);

		IQueryable<SptFallbackUsg> GetSptFallbackUsgs();

		Task<Int32> AddSptFallbackUsgAsync(SptFallbackUsg entity);

		IQueryable<SptMonitor> GetSptMonitors();

		Task<Int32> AddSptMonitorAsync(SptMonitor entity);

		IQueryable<WebCategory> GetWebCategories();

		Task<WebCategory> GetWebCategoryAsync(WebCategory entity);

		Task<Int32> AddWebCategoryAsync(WebCategory entity);

		Task<Int32> UpdateWebCategoryAsync(WebCategory changes);

		Task<Int32> RemoveWebCategoryAsync(WebCategory entity);

		IQueryable<WebNews> GetWebNews(Int32? categoryId = null, Int32? sourceId = null);

		Task<WebNews> GetWebNewsAsync(WebNews entity);

		Task<Int32> AddWebNewsAsync(WebNews entity);

		Task<Int32> UpdateWebNewsAsync(WebNews changes);

		Task<Int32> RemoveWebNewsAsync(WebNews entity);

		IQueryable<WebSource> GetWebSources(Int32? categoryId = null);

		Task<WebSource> GetWebSourceAsync(WebSource entity);

		Task<Int32> AddWebSourceAsync(WebSource entity);

		Task<Int32> UpdateWebSourceAsync(WebSource changes);

		Task<Int32> RemoveWebSourceAsync(WebSource entity);

		IQueryable<SptValues> GetSptValues();
	}
}
