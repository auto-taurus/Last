using System.Composition;
using Microsoft.EntityFrameworkCore;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.DataLayer.Configurations
{
	[Export(typeof(IEntityTypeConfiguration))]
	public class WebSourceConfiguration : IEntityTypeConfiguration
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<WebSource>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("Web_Source", "dbo");
			
				// Set key for entity
				builder.HasKey(p => p.SourceId);
			
				// Set identity for entity (auto increment)
				builder.Property(p => p.SourceId).UseSqlServerIdentityColumn();
			
				// Set configuration for columns
				builder.Property(p => p.SourceId).HasColumnType("int").IsRequired();
				builder.Property(p => p.CategoryId).HasColumnType("int");
				builder.Property(p => p.SourceName).HasColumnType("nvarchar(40)");
				builder.Property(p => p.SourceLogo).HasColumnType("nvarchar(510)");
				builder.Property(p => p.FollowNumber).HasColumnType("int");
				builder.Property(p => p.Sequence).HasColumnType("int");
				builder.Property(p => p.IsEnable).HasColumnType("int");
				builder.Property(p => p.Remarks).HasColumnType("datetime");
			
				// Add configuration for foreign keys
				builder
					.HasOne(p => p.WebCategoryFk)
					.WithMany(b => b.WebSources)
					.HasForeignKey(p => p.CategoryId)
					.HasConstraintName("FK_WEB_SOUR_REFERENCE_WEB_CATE");
			
			});
		}
	}
}
