using System.Composition;
using Microsoft.EntityFrameworkCore;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.DataLayer.Configurations
{
	[Export(typeof(IEntityTypeConfiguration))]
	public class MemberLoginLogConfiguration : IEntityTypeConfiguration
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<MemberLoginLog>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("Member_LoginLog", "dbo");
			
				// Set key for entity
				builder.HasKey(p => p.LoginLogId);
			
				// Set identity for entity (auto increment)
				builder.Property(p => p.LoginLogId).UseSqlServerIdentityColumn();
			
				// Set configuration for columns
				builder.Property(p => p.LoginLogId).HasColumnType("numeric(18, 0)").IsRequired();
				builder.Property(p => p.Source).HasColumnType("char(10)");
				builder.Property(p => p.Column3).HasColumnName("Column_3").HasColumnType("char(10)");
				builder.Property(p => p.Column4).HasColumnName("Column_4").HasColumnType("char(10)");
			
			});
		}
	}
}
