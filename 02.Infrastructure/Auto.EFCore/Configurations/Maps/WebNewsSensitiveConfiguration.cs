using System.Composition;
using Microsoft.EntityFrameworkCore;
using Auto.EFCore.Entities;

namespace Auto.EFCore.Configurations.Maps
{
	[Export(typeof(IEntityTypeConfiguration))]
	public class WebNewsSensitiveConfiguration : IEntityTypeConfiguration
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<WebNewsSensitive>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("Web_NewsSensitive", "dbo");
			
				// Set key for entity
				builder.HasKey(p => p.NewsSensitiveId);
			
				// Set identity for entity (auto increment)
				builder.Property(p => p.NewsSensitiveId).UseSqlServerIdentityColumn();
			
				// Set configuration for columns
				builder.Property(p => p.NewsSensitiveId).HasColumnType("int").IsRequired();
				builder.Property(p => p.SiteMark).HasColumnType("int");
				builder.Property(p => p.NewId).HasColumnType("int");
				builder.Property(p => p.NewTitleRecords).HasColumnType("nvarchar(2000)");
				builder.Property(p => p.CustomTitleRecords).HasColumnType("nvarchar(2000)");
				builder.Property(p => p.ContentsRecords).HasColumnType("nvarchar(2000)");
				builder.Property(p => p.IsEnable).HasColumnType("int");
				builder.Property(p => p.Remarks).HasColumnType("nvarchar(2000)");
				builder.Property(p => p.CreateBy).HasColumnType("int");
				builder.Property(p => p.CreateTime).HasColumnType("smalldatetime");
			
			});
		}
	}
}
