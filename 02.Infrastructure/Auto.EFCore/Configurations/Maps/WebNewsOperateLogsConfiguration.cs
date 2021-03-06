using System.Composition;
using Microsoft.EntityFrameworkCore;
using Auto.EFCore.Entities;

namespace Auto.EFCore.Configurations.Maps
{
	[Export(typeof(IEntityTypeConfiguration))]
	public class WebNewsOperateLogsConfiguration : IEntityTypeConfiguration
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<WebNewsOperateLogs>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("Web_NewsOperate_Logs", "dbo");
			
				// Set key for entity
				builder.HasKey(p => p.NewsOperateId);
			
				// Set identity for entity (auto increment)
				builder.Property(p => p.NewsOperateId).UseSqlServerIdentityColumn();
			
				// Set configuration for columns
				builder.Property(p => p.NewsOperateId).HasColumnType("int").IsRequired();
				builder.Property(p => p.NewsId).HasColumnType("varchar(12)");
				builder.Property(p => p.OperateType).HasColumnType("nvarchar(40)");
				builder.Property(p => p.OperateStatus).HasColumnType("nvarchar(510)");
				builder.Property(p => p.Remarks).HasColumnType("nvarchar(510)");
				builder.Property(p => p.CreateBy).HasColumnType("int");
				builder.Property(p => p.CreateName).HasColumnType("nvarchar(40)");
				builder.Property(p => p.CreateTime).HasColumnType("datetime");
			
				// Add configuration for foreign keys
				builder
					.HasOne(p => p.WebNews)
					.WithMany(b => b.WebNewsOperateLogs)
					.HasForeignKey(p => p.NewsId)
					.HasConstraintName("FK_WEB_NEWS_REFERENCE_WEB_NEWS");
			
			});
		}
	}
}
