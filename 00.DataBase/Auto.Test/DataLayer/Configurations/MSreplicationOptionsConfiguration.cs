using System.Composition;
using Microsoft.EntityFrameworkCore;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.DataLayer.Configurations
{
	[Export(typeof(IEntityTypeConfiguration))]
	public class MSreplicationOptionsConfiguration : IEntityTypeConfiguration
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<MSreplicationOptions>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("MSreplication_options", "dbo");
			
			#warning Add configuration for entity's key
			
				// Set configuration for columns
				builder.Property(p => p.Optname).HasColumnName("optname").HasColumnType("sysname").IsRequired();
				builder.Property(p => p.Value).HasColumnName("value").HasColumnType("bit").IsRequired();
				builder.Property(p => p.MajorVersion).HasColumnName("major_version").HasColumnType("int").IsRequired();
				builder.Property(p => p.MinorVersion).HasColumnName("minor_version").HasColumnType("int").IsRequired();
				builder.Property(p => p.Revision).HasColumnName("revision").HasColumnType("int").IsRequired();
				builder.Property(p => p.InstallFailures).HasColumnName("install_failures").HasColumnType("int").IsRequired();
			
			});
		}
	}
}
