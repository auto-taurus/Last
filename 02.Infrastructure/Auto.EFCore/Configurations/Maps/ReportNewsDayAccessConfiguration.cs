using System.Composition;
using Microsoft.EntityFrameworkCore;
using Auto.EFCore.Entities;

namespace Auto.EFCore.Configurations.Maps
{
	[Export(typeof(IEntityTypeConfiguration))]
	public class ReportNewsDayAccessConfiguration : IEntityTypeConfiguration
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<ReportNewsDayAccess>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("Report_News_DayAccess", "dbo");
			
				// Set key for entity
				builder.HasKey(p => p.NewsAccessId);
			
				// Set identity for entity (auto increment)
				builder.Property(p => p.NewsAccessId).UseSqlServerIdentityColumn();
			
				// Set configuration for columns
				builder.Property(p => p.NewsAccessId).HasColumnType("int").IsRequired();
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
