using System.Composition;
using Microsoft.EntityFrameworkCore;
using Auto.Entities.Modals;

namespace Auto.Configurations.Maps
{
	[Export(typeof(IConfigurations))]
	public class ReportNewsDayClickConfiguration : IConfigurations
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<ReportNewsDayClick>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("Report_News_DayClick", "dbo");
			
				// Set key for entity
				builder.HasKey(p => p.NewsClickId);
			
				// Set identity for entity (auto increment)
				builder.Property(p => p.NewsClickId).UseSqlServerIdentityColumn();
			
				// Set configuration for columns
				builder.Property(p => p.NewsClickId).HasColumnType("int").IsRequired();
				builder.Property(p => p.NewsId).HasColumnType("varchar(12)");
				builder.Property(p => p.CategoryId).HasColumnType("int");
				builder.Property(p => p.CategoryName).HasColumnType("nvarchar(100)");
				builder.Property(p => p.SpecialCode).HasColumnType("int");
				builder.Property(p => p.SpecialName).HasColumnType("nvarchar(100)");
				builder.Property(p => p.Count).HasColumnType("int");
				builder.Property(p => p.Today).HasColumnType("date");
				builder.Property(p => p.LastUpdateTime).HasColumnType("datetime");
			
			});
		}
	}
}
