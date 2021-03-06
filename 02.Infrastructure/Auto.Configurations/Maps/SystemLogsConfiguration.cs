using System.Composition;
using Microsoft.EntityFrameworkCore;
using Auto.Entities.Modals;

namespace Auto.Configurations.Maps
{
	[Export(typeof(IConfigurations))]
	public class SystemLogsConfiguration : IConfigurations
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<SystemLogs>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("System_Logs", "dbo");
			
				// Set key for entity
				builder.HasKey(p => p.LogsId);
			
				// Set identity for entity (auto increment)
				builder.Property(p => p.LogsId).UseSqlServerIdentityColumn();
			
				// Set configuration for columns
				builder.Property(p => p.LogsId).HasColumnType("int").IsRequired();
				builder.Property(p => p.Methods).HasColumnType("varchar(100)");
				builder.Property(p => p.Grade).HasColumnType("int");
				builder.Property(p => p.Source).HasColumnType("varchar(50)");
				builder.Property(p => p.Args).HasColumnType("nvarchar(4000)");
				builder.Property(p => p.Errors).HasColumnType("nvarchar(4000)");
				builder.Property(p => p.CreateBy).HasColumnType("int");
				builder.Property(p => p.CreateTime).HasColumnType("datetime").IsRequired();
			
			});
		}
	}
}
