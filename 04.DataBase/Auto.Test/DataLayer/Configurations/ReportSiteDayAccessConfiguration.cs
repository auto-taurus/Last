using System.Composition;
using Microsoft.EntityFrameworkCore;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.DataLayer.Configurations
{
	[Export(typeof(IEntityTypeConfiguration))]
	public class ReportSiteDayAccessConfiguration : IEntityTypeConfiguration
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<ReportSiteDayAccess>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("Report_Site_DayAccess", "dbo");
			
				// Set key for entity
				builder.HasKey(p => p.SiteAccessId);
			
				// Set identity for entity (auto increment)
				builder.Property(p => p.SiteAccessId).UseSqlServerIdentityColumn();
			
				// Set configuration for columns
				builder.Property(p => p.SiteAccessId).HasColumnType("int").IsRequired();
				builder.Property(p => p.SiteNo).HasColumnType("char(10)");
				builder.Property(p => p.Count).HasColumnType("int");
				builder.Property(p => p.Today).HasColumnType("date");
				builder.Property(p => p.LastUpdateTime).HasColumnType("datetime");
			
			});
		}
	}
}
