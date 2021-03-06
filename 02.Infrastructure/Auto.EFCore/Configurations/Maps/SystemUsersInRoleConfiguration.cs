using System.Composition;
using Auto.EFCore.Configurations.Maps;
using Auto.EFCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace OnLineStoreCore.DataLayer.Configurations {
    [Export(typeof(IEntityTypeConfiguration))]
    public class SystemUsersInRoleConfiguration : IEntityTypeConfiguration {
        public void Configure(ModelBuilder modelBuilder) {
            modelBuilder.Entity<SystemUsersInRole>(builder => {
                // Set configuration for entity
                builder.ToTable("System_UsersInRole", "dbo");

                // Set key for entity
                builder.HasKey(p => p.Id);

                // Set configuration for columns
                builder.Property(p => p.UsersId).HasColumnType("int");
                builder.Property(p => p.RoleId).HasColumnType("int");

                // relationships
                builder.HasOne(t => t.SystemRole)
                    .WithMany(t => t.SystemUsers)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_SYSTEM_U_REFERENCE_SYSTEM_RU");

                builder.HasOne(t => t.SystemUsers)
                    .WithMany(t => t.SystemRoles)
                    .HasForeignKey(d => d.UsersId)
                    .HasConstraintName("FK_SYSTEM_U_REFERENCE_SYSTEM_UU");
            });
        }
    }
}
