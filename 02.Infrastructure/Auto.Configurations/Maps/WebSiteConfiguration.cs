using System.Composition;
using Microsoft.EntityFrameworkCore;
using Auto.Entities.Modals;

namespace Auto.Configurations.Maps
{
	[Export(typeof(IConfigurations))]
	public class WebSiteConfiguration : IConfigurations
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<WebSite>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("Web_Site", "dbo");
			
				// Set key for entity
				builder.HasKey(p => p.SiteId);
			
				// Set identity for entity (auto increment)
				builder.Property(p => p.SiteId).UseSqlServerIdentityColumn();
			
				// Set configuration for columns
				builder.Property(p => p.SiteId).HasColumnType("int").IsRequired();
				builder.Property(p => p.SiteName).HasColumnType("nvarchar(100)");
				builder.Property(p => p.SiteUrls).HasColumnType("varchar(255)");
				builder.Property(p => p.LogoUrls).HasColumnType("varchar(255)");
				builder.Property(p => p.AccessNumber).HasColumnType("int");
				builder.Property(p => p.Title).HasColumnType("varchar(255)");
				builder.Property(p => p.Keywords).HasColumnType("varchar(255)");
				builder.Property(p => p.Description).HasColumnType("varchar(255)");
                builder.Property(t => t.RowVers)
                    .IsRowVersion()
                    .HasColumnName("RowVers")
                    .HasColumnType("rowversion")
                    .HasMaxLength(8)
                    .ValueGeneratedOnAddOrUpdate();
                builder.Property(p => p.IsEnable).HasColumnType("int");
				builder.Property(p => p.Remarks).HasColumnType("nvarchar(510)");
				builder.Property(p => p.CreateBy).HasColumnType("int");
				builder.Property(p => p.CreateTime).HasColumnType("datetime");
			
			});
		}
	}
}
