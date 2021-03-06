using System.Composition;
using Microsoft.EntityFrameworkCore;
using Auto.Entities.Modals;

namespace Auto.Configurations.Maps {
    [Export(typeof(IConfigurations))]
    public class SystemRoleInMenuConfiguration : IConfigurations {
        public void Configure(ModelBuilder modelBuilder) {
            modelBuilder.Entity<SystemRoleInMenu>(builder => {
                #region Generated Configure
                // table
                builder.ToTable("System_RoleInMenu", "dbo");

                // key
                builder.HasKey(t => new { t.RoleId, t.MenuId });

                builder.Property(t => t.RoleId)
                    .HasColumnName("RoleId")
                    .HasColumnType("int");

                builder.Property(t => t.MenuId)
                    .HasColumnName("MenuId")
                    .HasColumnType("int");

                // relationships
                builder.HasOne(t => t.SystemMenu)
                    .WithMany(t => t.SystemRoleInMenus)
                    .HasForeignKey(d => d.MenuId)
                    .HasConstraintName("FK_SYSTEM_R_REFERENCE_SYSTEM_M");

                builder.HasOne(t => t.SystemRole)
                    .WithMany(t => t.SystemRoleInMenus)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_SYSTEM_R_REFERENCE_SYSTEM_R");

                #endregion
            });
        }
    }
}
