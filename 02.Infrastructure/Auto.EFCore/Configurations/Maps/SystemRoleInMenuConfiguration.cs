using System.Composition;
using Microsoft.EntityFrameworkCore;
using Auto.EFCore.Entities;

namespace Auto.EFCore.Configurations.Maps {
    [Export(typeof(IEntityTypeConfiguration))]
    public class SystemRoleInMenuConfiguration : IEntityTypeConfiguration {
        public void Configure(ModelBuilder modelBuilder) {
            modelBuilder.Entity<SystemRoleInMenu>(builder => {
                // Set configuration for entity
                builder.ToTable("System_RoleInMenu", "dbo");

                // Set key for entity
                builder.HasKey(p => p.Id);

                // Set configuration for columns
                builder.Property(p => p.RoleId).HasColumnType("int");
                builder.Property(p => p.MenuId).HasColumnType("int");
                // relationships
                builder.HasOne(t => t.SystemMenu)
                    .WithMany(t => t.SystemRoles)
                    .HasForeignKey(d => d.MenuId)
                    .HasConstraintName("FK_SYSTEM_R_REFERENCE_SYSTEM_M");

                builder.HasOne(t => t.SystemRole)
                    .WithMany(t => t.SystemMenus)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_SYSTEM_R_REFERENCE_SYSTEM_R");
            });
        }
    }
}
