using System.Composition;
using Microsoft.EntityFrameworkCore;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.DataLayer.Configurations
{
	[Export(typeof(IEntityTypeConfiguration))]
	public class WebChannelConfiguration : IEntityTypeConfiguration
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<WebChannel>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("Web_Channel", "dbo");
			
				// Set key for entity
				builder.HasKey(p => p.ChannelId);
			
				// Set identity for entity (auto increment)
				builder.Property(p => p.ChannelId).UseSqlServerIdentityColumn();
			
				// Set configuration for columns
				builder.Property(p => p.ChannelId).HasColumnType("int").IsRequired();
				builder.Property(p => p.SiteNo).HasColumnType("int");
				builder.Property(p => p.ChannelName).HasColumnType("varchar(100)");
				builder.Property(p => p.ChannelAddress).HasColumnType("varchar(1000)");
				builder.Property(p => p.ChannelJs).HasColumnType("varchar(255)");
				builder.Property(p => p.IsEnable).HasColumnType("int");
				builder.Property(p => p.Timestamp).HasColumnType("timestamp");
				builder.Property(p => p.Remarks).HasColumnType("nvarchar(510)");
				builder.Property(p => p.CreateBy).HasColumnType("int");
				builder.Property(p => p.CreateTime).HasColumnType("datetime");
			
			});
		}
	}
}
