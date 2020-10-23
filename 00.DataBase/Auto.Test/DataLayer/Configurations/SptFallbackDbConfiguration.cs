using System.Composition;
using Microsoft.EntityFrameworkCore;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.DataLayer.Configurations
{
	[Export(typeof(IEntityTypeConfiguration))]
	public class SptFallbackDbConfiguration : IEntityTypeConfiguration
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<SptFallbackDb>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("spt_fallback_db", "dbo");
			
			#warning Add configuration for entity's key
			
				// Set configuration for columns
				builder.Property(p => p.XserverName).HasColumnName("xserver_name").HasColumnType("varchar(30)").IsRequired();
				builder.Property(p => p.XdttmIns).HasColumnName("xdttm_ins").HasColumnType("datetime").IsRequired();
				builder.Property(p => p.XdttmLastInsUpd).HasColumnName("xdttm_last_ins_upd").HasColumnType("datetime").IsRequired();
				builder.Property(p => p.XfallbackDbid).HasColumnName("xfallback_dbid").HasColumnType("smallint");
				builder.Property(p => p.Name).HasColumnName("name").HasColumnType("varchar(30)").IsRequired();
				builder.Property(p => p.Dbid).HasColumnName("dbid").HasColumnType("smallint").IsRequired();
				builder.Property(p => p.Status).HasColumnName("status").HasColumnType("smallint").IsRequired();
				builder.Property(p => p.Version).HasColumnName("version").HasColumnType("smallint").IsRequired();
			
			});
		}
	}
}
