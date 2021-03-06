using Auto.EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using System.Composition;

namespace Auto.EFCore.Configurations.Maps {
    [Export(typeof(IEntityTypeConfiguration))]
    public class SystemUsersInMenuConfiguration : IEntityTypeConfiguration {
        public void Configure(ModelBuilder modelBuilder) {
            modelBuilder.Entity<SystemUsersInMenu>(builder => {
                // Set configuration for entity
                builder.ToTable("System_UsersInMenu", "dbo");

                // Set key for entity
                builder.HasKey(p => p.Id);

                // Set configuration for columns
                builder.Property(p => p.UserId).HasColumnType("int");
                builder.Property(p => p.MenuId).HasColumnType("int");
                // relationships
                builder.HasOne(t => t.SystemMenu)
                    .WithMany(t => t.SystemUsers)
                    .HasForeignKey(d => d.MenuId)
                    .HasConstraintName("FK_SYSTEM_U_REFERENCE_SYSTEM_M");

                builder.HasOne(t => t.SystemUsers)
                    .WithMany(t => t.SystemMenus)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_SYSTEM_U_REFERENCE_SYSTEM_UM");

            });
        }
    }
}
