using System.Composition;
using Microsoft.EntityFrameworkCore;
using Auto.EFCore.Entities;

namespace Auto.EFCore.Configurations.Maps {
    [Export(typeof(IEntityTypeConfiguration))]
    public class SystemRoleConfiguration : IEntityTypeConfiguration {
        public void Configure(ModelBuilder modelBuilder) {
            modelBuilder.Entity<SystemRole>(builder => {
                // Set configuration for entity
                builder.ToTable("System_Role", "dbo");

                // Set key for entity
                builder.HasKey(p => p.RoleId);

                // Set configuration for columns
                builder.Property(p => p.RoleId).HasColumnType("int").IsRequired();
                builder.Property(p => p.RoleName).HasColumnType("nvarchar(40)");
                builder.Property(p => p.IsEnable).HasColumnType("int");
                builder.Property(p => p.Remarks).HasColumnType("nvarchar(510)");
                builder.Property(p => p.CreateBy).HasColumnType("int");
                builder.Property(p => p.CreateTime).HasColumnType("datetime");

            });
        }
    }
}
