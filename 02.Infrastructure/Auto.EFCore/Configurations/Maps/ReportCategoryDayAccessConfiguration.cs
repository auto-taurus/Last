using System.Composition;
using Microsoft.EntityFrameworkCore;
using Auto.EFCore.Entities;

namespace Auto.EFCore.Configurations.Maps
{
	[Export(typeof(IEntityTypeConfiguration))]
	public class ReportCategoryDayAccessConfiguration : IEntityTypeConfiguration
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<ReportCategoryDayAccess>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("Report_Category_DayAccess", "dbo");
			
				// Set key for entity
				builder.HasKey(p => p.CategoryAccessId);
			
				// Set identity for entity (auto increment)
				builder.Property(p => p.CategoryAccessId).UseSqlServerIdentityColumn();
			
				// Set configuration for columns
				builder.Property(p => p.CategoryAccessId).HasColumnType("int").IsRequired();
				builder.Property(p => p.CategoryId).HasColumnType("int");
				builder.Property(p => p.CategoryName).HasColumnType("nvarchar(100)");
				builder.Property(p => p.Count).HasColumnType("int");
				builder.Property(p => p.Today).HasColumnType("date");
				builder.Property(p => p.LastUpdateTime).HasColumnType("datetime");
			
			});
		}
	}
}
