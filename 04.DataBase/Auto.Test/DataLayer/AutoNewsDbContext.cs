using Microsoft.EntityFrameworkCore;
using OnLineStoreCore.DataLayer.Configurations;

namespace OnLineStoreCore.DataLayer
{
	public class AutoNewsDbContext : DbContext
	{
		public AutoNewsDbContext(DbContextOptions<AutoNewsDbContext> options, IEntityMapper entityMapper)
			: base(options)
		{
			EntityMapper = entityMapper;
		}

		public IEntityMapper EntityMapper { get; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			// This code will change for EF Core 2
			EntityMapper.ConfigureEntities(modelBuilder);
			
				base.OnModelCreating(modelBuilder);
		}
	}
}
