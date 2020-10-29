using System.Composition;
using Microsoft.EntityFrameworkCore;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.DataLayer.Configurations
{
	[Export(typeof(IEntityTypeConfiguration))]
	public class SystemUsersInRoleConfiguration : IEntityTypeConfiguration
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<SystemUsersInRole>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("System_UsersInRole", "dbo");
			
				// Set key for entity
				builder.HasKey(p => p.Id);
			
				// Set identity for entity (auto increment)
				builder.Property(p => p.Id).UseSqlServerIdentityColumn();
			
				// Set configuration for columns
				builder.Property(p => p.Id).HasColumnType("int").IsRequired();
				builder.Property(p => p.UsersId).HasColumnType("int");
				builder.Property(p => p.RoleId).HasColumnType("int");
			
				// Add configuration for foreign keys
				builder
					.HasOne(p => p.SystemRoleFk)
					.WithMany(b => b.SystemUsersInRoles)
					.HasForeignKey(p => p.RoleId)
					.HasConstraintName("FK_SYSTEM_U_REFERENCE_SYSTEM_RU");
			
				builder
					.HasOne(p => p.SystemUsersFk)
					.WithMany(b => b.SystemUsersInRoles)
					.HasForeignKey(p => p.UsersId)
					.HasConstraintName("FK_SYSTEM_U_REFERENCE_SYSTEM_UU");
			
			});
		}
	}
}
