using System.Composition;
using Microsoft.EntityFrameworkCore;
using Auto.Entities.Modals;

namespace Auto.Configurations.Maps
{
	[Export(typeof(IConfigurations))]
	public class WebSensitiveConfiguration : IConfigurations
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<WebSensitive>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("Web_Sensitive", "dbo");
			
				// Set key for entity
				builder.HasKey(p => p.SensitiveId);
			
				// Set identity for entity (auto increment)
				builder.Property(p => p.SensitiveId).UseSqlServerIdentityColumn();
			
				// Set configuration for columns
				builder.Property(p => p.SensitiveId).HasColumnType("int").IsRequired();
				builder.Property(p => p.SiteId).HasColumnType("int");
				builder.Property(p => p.Type).HasColumnType("int");
				builder.Property(p => p.TypeText).HasColumnType("nvarchar(40)");
				builder.Property(p => p.SensitiveWords).HasColumnType("nvarchar(100)");
				builder.Property(p => p.Author).HasColumnType("nvarchar(2000)");
				builder.Property(p => p.Urls).HasColumnType("nvarchar(8000)");
				builder.Property(p => p.RowVers).HasColumnType("timestamp");
				builder.Property(p => p.IsEnable).HasColumnType("int");
				builder.Property(p => p.Remarks).HasColumnType("nvarchar(510)");
				builder.Property(p => p.CreateBy).HasColumnType("int");
				builder.Property(p => p.CreateTime).HasColumnType("datetime");
			
			});
		}
	}
}
