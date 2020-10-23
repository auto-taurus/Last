using System.Composition;
using Microsoft.EntityFrameworkCore;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.DataLayer.Configurations
{
	[Export(typeof(IEntityTypeConfiguration))]
	public class SptMonitorConfiguration : IEntityTypeConfiguration
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<SptMonitor>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("spt_monitor", "dbo");
			
			#warning Add configuration for entity's key
			
				// Set configuration for columns
				builder.Property(p => p.Lastrun).HasColumnName("lastrun").HasColumnType("datetime").IsRequired();
				builder.Property(p => p.CpuBusy).HasColumnName("cpu_busy").HasColumnType("int").IsRequired();
				builder.Property(p => p.IoBusy).HasColumnName("io_busy").HasColumnType("int").IsRequired();
				builder.Property(p => p.Idle).HasColumnName("idle").HasColumnType("int").IsRequired();
				builder.Property(p => p.PackReceived).HasColumnName("pack_received").HasColumnType("int").IsRequired();
				builder.Property(p => p.PackSent).HasColumnName("pack_sent").HasColumnType("int").IsRequired();
				builder.Property(p => p.Connections).HasColumnName("connections").HasColumnType("int").IsRequired();
				builder.Property(p => p.PackErrors).HasColumnName("pack_errors").HasColumnType("int").IsRequired();
				builder.Property(p => p.TotalRead).HasColumnName("total_read").HasColumnType("int").IsRequired();
				builder.Property(p => p.TotalWrite).HasColumnName("total_write").HasColumnType("int").IsRequired();
				builder.Property(p => p.TotalErrors).HasColumnName("total_errors").HasColumnType("int").IsRequired();
			
			});
		}
	}
}
