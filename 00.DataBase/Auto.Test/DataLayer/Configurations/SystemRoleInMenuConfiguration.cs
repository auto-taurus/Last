using System.Composition;
using Microsoft.EntityFrameworkCore;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.DataLayer.Configurations
{
	[Export(typeof(IEntityTypeConfiguration))]
	public class SystemRoleInMenuConfiguration : IEntityTypeConfiguration
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<SystemRoleInMenu>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("System_RoleInMenu", "dbo");
			
				// Set key for entity
				builder.HasKey(p => p.Id);
			
				// Set identity for entity (auto increment)
				builder.Property(p => p.Id).UseSqlServerIdentityColumn();
			
				// Set configuration for columns
				builder.Property(p => p.Id).HasColumnType("int").IsRequired();
				builder.Property(p => p.RoleId).HasColumnType("int");
				builder.Property(p => p.MenuId).HasColumnType("int");
			
				// Add configuration for foreign keys
				builder
					.HasOne(p => p.SystemMenuFk)
					.WithMany(b => b.SystemRoleInMenus)
					.HasForeignKey(p => p.MenuId)
					.HasConstraintName("FK_SYSTEM_R_REFERENCE_SYSTEM_M");
			
				builder
					.HasOne(p => p.SystemRoleFk)
					.WithMany(b => b.SystemRoleInMenus)
					.HasForeignKey(p => p.RoleId)
					.HasConstraintName("FK_SYSTEM_R_REFERENCE_SYSTEM_R");
			
			});
		}
	}
}
