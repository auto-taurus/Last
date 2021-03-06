using System.Composition;
using Auto.Configurations.Maps;
using Auto.Entities.Modals;
using Microsoft.EntityFrameworkCore;

namespace Auto.Configurations.Maps {
    [Export(typeof(IConfigurations))]
    public class SystemUsersInRoleConfiguration : IConfigurations {
        public void Configure(ModelBuilder modelBuilder) {
            modelBuilder.Entity<SystemUsersInRole>(builder => {
                #region Generated Configure
                // table
                builder.ToTable("System_UsersInRole", "dbo");

                // key
                builder.HasKey(t => new { t.UsersId, t.RoleId });

                // properties

                builder.Property(t => t.UsersId)
                    .HasColumnName("UsersId")
                    .HasColumnType("int");

                builder.Property(t => t.RoleId)
                    .HasColumnName("RoleId")
                    .HasColumnType("int");

                // relationships
                builder.HasOne(t => t.SystemRole)
                    .WithMany(t => t.SystemUsersInRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_SYSTEM_U_REFERENCE_SYSTEM_RU");

                builder.HasOne(t => t.SystemUsers)
                    .WithMany(t => t.SystemUsersInRoles)
                    .HasForeignKey(d => d.UsersId)
                    .HasConstraintName("FK_SYSTEM_U_REFERENCE_SYSTEM_UU");

                #endregion
            });
        }
    }
}
