using System.Composition;
using Microsoft.EntityFrameworkCore;
using Auto.Entities.Modals;

namespace Auto.Configurations.Maps {
    [Export(typeof(IConfigurations))]
    public class SystemRoleConfiguration : IConfigurations {
        public void Configure(ModelBuilder modelBuilder) {
            modelBuilder.Entity<SystemRole>(builder => {
                #region Generated Configure
                // table
                builder.ToTable("System_Role", "dbo");

                // key
                builder.HasKey(t => t.RoleId);

                // properties
                builder.Property(t => t.RoleId)
                    .IsRequired()
                    .HasColumnName("RoleId")
                    .HasColumnType("int")
                    .ValueGeneratedOnAdd();

                builder.Property(t => t.RoleName)
                    .HasColumnName("RoleName")
                    .HasColumnType("nvarchar(20)")
                    .HasMaxLength(20);

                builder.Property(t => t.IsEnable)
                    .HasColumnName("IsEnable")
                    .HasColumnType("int");

                builder.Property(t => t.Remarks)
                    .HasColumnName("Remarks")
                    .HasColumnType("nvarchar(255)")
                    .HasMaxLength(255);

                builder.Property(t => t.CreateBy)
                    .HasColumnName("CreateBy")
                    .HasColumnType("int");

                builder.Property(t => t.CreateTime)
                    .HasColumnName("CreateTime")
                    .HasColumnType("datetime");

                // relationships
                #endregion
            });
        }
    }
}
