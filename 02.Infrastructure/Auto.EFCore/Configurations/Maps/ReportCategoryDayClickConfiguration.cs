using System.Composition;
using Microsoft.EntityFrameworkCore;
using Auto.EFCore.Entities;

namespace Auto.EFCore.Configurations.Maps
{
	[Export(typeof(IEntityTypeConfiguration))]
	public class ReportCategoryDayClickConfiguration : IEntityTypeConfiguration
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<ReportCategoryDayClick>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("Report_Category_DayClick", "dbo");
			
				// Set key for entity
				builder.HasKey(p => p.CategoryClickId);
			
				// Set identity for entity (auto increment)
				builder.Property(p => p.CategoryClickId).UseSqlServerIdentityColumn();
			
				// Set configuration for columns
				builder.Property(p => p.CategoryClickId).HasColumnType("int").IsRequired();
				builder.Property(p => p.CategoryId).HasColumnType("int");
				builder.Property(p => p.CategoryName).HasColumnType("nvarchar(100)");
				builder.Property(p => p.Count).HasColumnType("int");
				builder.Property(p => p.Today).HasColumnType("date");
				builder.Property(p => p.LastUpdateTime).HasColumnType("datetime");
			
			});
		}
	}
}
