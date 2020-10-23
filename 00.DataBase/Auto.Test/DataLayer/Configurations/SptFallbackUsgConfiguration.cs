using System.Composition;
using Microsoft.EntityFrameworkCore;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.DataLayer.Configurations
{
	[Export(typeof(IEntityTypeConfiguration))]
	public class SptFallbackUsgConfiguration : IEntityTypeConfiguration
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<SptFallbackUsg>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("spt_fallback_usg", "dbo");
			
			#warning Add configuration for entity's key
			
				// Set configuration for columns
				builder.Property(p => p.XserverName).HasColumnName("xserver_name").HasColumnType("varchar(30)").IsRequired();
				builder.Property(p => p.XdttmIns).HasColumnName("xdttm_ins").HasColumnType("datetime").IsRequired();
				builder.Property(p => p.XdttmLastInsUpd).HasColumnName("xdttm_last_ins_upd").HasColumnType("datetime").IsRequired();
				builder.Property(p => p.XfallbackVstart).HasColumnName("xfallback_vstart").HasColumnType("int");
				builder.Property(p => p.Dbid).HasColumnName("dbid").HasColumnType("smallint").IsRequired();
				builder.Property(p => p.Segmap).HasColumnName("segmap").HasColumnType("int").IsRequired();
				builder.Property(p => p.Lstart).HasColumnName("lstart").HasColumnType("int").IsRequired();
				builder.Property(p => p.Sizepg).HasColumnName("sizepg").HasColumnType("int").IsRequired();
				builder.Property(p => p.Vstart).HasColumnName("vstart").HasColumnType("int").IsRequired();
			
			});
		}
	}
}
