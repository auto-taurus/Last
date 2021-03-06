using Auto.Entities.Modals;
using Microsoft.EntityFrameworkCore;
using System.Composition;

namespace Auto.Configurations.Maps {
    [Export(typeof(IConfigurations))]
    public class SystemUsersInMenuConfiguration : IConfigurations {
        public void Configure(ModelBuilder modelBuilder) {
            modelBuilder.Entity<SystemUsersInMenu>(builder => {
                #region Generated Configure
                // table
                builder.ToTable("System_UsersInMenu", "dbo");

                // key
                builder.HasKey(t => new { t.UserId, t.MenuId });

                // properties

                builder.Property(t => t.UserId)
                    .HasColumnName("UserId")
                    .HasColumnType("int");

                builder.Property(t => t.MenuId)
                    .HasColumnName("MenuId")
                    .HasColumnType("int");

                // relationships
                builder.HasOne(t => t.SystemMenu)
                    .WithMany(t => t.SystemUsersInMenus)
                    .HasForeignKey(d => d.MenuId)
                    .HasConstraintName("FK_SYSTEM_U_REFERENCE_SYSTEM_M");

                builder.HasOne(t => t.SystemUsers)
                    .WithMany(t => t.SystemUsersInMenus)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_SYSTEM_U_REFERENCE_SYSTEM_UM");

                #endregion

            });
        }
    }
}
