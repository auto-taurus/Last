using System.Composition;
using Microsoft.EntityFrameworkCore;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.DataLayer.Configurations
{
	[Export(typeof(IEntityTypeConfiguration))]
	public class SptFallbackDevConfiguration : IEntityTypeConfiguration
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<SptFallbackDev>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("spt_fallback_dev", "dbo");
			
			#warning Add configuration for entity's key
			
				// Set configuration for columns
				builder.Property(p => p.XserverName).HasColumnName("xserver_name").HasColumnType("varchar(30)").IsRequired();
				builder.Property(p => p.XdttmIns).HasColumnName("xdttm_ins").HasColumnType("datetime").IsRequired();
				builder.Property(p => p.XdttmLastInsUpd).HasColumnName("xdttm_last_ins_upd").HasColumnType("datetime").IsRequired();
				builder.Property(p => p.XfallbackLow).HasColumnName("xfallback_low").HasColumnType("int");
				builder.Property(p => p.XfallbackDrive).HasColumnName("xfallback_drive").HasColumnType("char(2)");
				builder.Property(p => p.Low).HasColumnName("low").HasColumnType("int").IsRequired();
				builder.Property(p => p.High).HasColumnName("high").HasColumnType("int").IsRequired();
				builder.Property(p => p.Status).HasColumnName("status").HasColumnType("smallint").IsRequired();
				builder.Property(p => p.Name).HasColumnName("name").HasColumnType("varchar(30)").IsRequired();
				builder.Property(p => p.Phyname).HasColumnName("phyname").HasColumnType("varchar(127)").IsRequired();
			
			});
		}
	}
}
