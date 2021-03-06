using System.Composition;
using Microsoft.EntityFrameworkCore;
using Auto.Entities.Modals;

namespace Auto.Configurations.Maps
{
	[Export(typeof(IConfigurations))]
	public class WebSpecialConfiguration : IConfigurations
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<WebSpecial>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("Web_Special", "dbo");
			
				// Set key for entity
				builder.HasKey(p => p.SpecialId);
			
				// Set identity for entity (auto increment)
				builder.Property(p => p.SpecialId).UseSqlServerIdentityColumn();
			
				// Set configuration for columns
				builder.Property(p => p.SpecialId).HasColumnType("int").IsRequired();
				builder.Property(p => p.SiteId).HasColumnType("int");
				builder.Property(p => p.SpecialCode).HasColumnType("varchar(10)");
				builder.Property(p => p.Name).HasColumnType("nvarchar(100)");
				builder.Property(p => p.DisplayType).HasColumnType("int");
				builder.Property(p => p.IsEnable).HasColumnType("int");
				builder.Property(p => p.RowVers).HasColumnType("timestamp");
				builder.Property(p => p.Remarks).HasColumnType("nvarchar(510)");
				builder.Property(p => p.CreateBy).HasColumnType("int");
				builder.Property(p => p.CreateTime).HasColumnType("datetime");
			
			});
		}
	}
}
