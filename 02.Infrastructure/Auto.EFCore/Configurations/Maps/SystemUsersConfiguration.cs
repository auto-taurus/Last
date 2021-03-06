using System.Composition;
using Microsoft.EntityFrameworkCore;
using Auto.EFCore.Entities;

namespace Auto.EFCore.Configurations.Maps {
    [Export(typeof(IEntityTypeConfiguration))]
    public class SystemUsersConfiguration : IEntityTypeConfiguration {
        public void Configure(ModelBuilder modelBuilder) {
            modelBuilder.Entity<SystemUsers>(builder => {
                // Set configuration for entity
                builder.ToTable("System_Users", "dbo");

                // Set key for entity
                builder.HasKey(p => p.UsersId);

                // Set identity for entity (auto increment)
                builder.Property(p => p.UsersId).UseSqlServerIdentityColumn();

                // Set configuration for columns
                builder.Property(p => p.UsersId).HasColumnType("int").IsRequired();
                builder.Property(p => p.UsersName).HasColumnType("nvarchar(40)");
                builder.Property(p => p.LoginName).HasColumnType("varchar(50)");
                builder.Property(p => p.Password).HasColumnType("varchar(50)");
                builder.Property(p => p.MobilePhone).HasColumnType("varchar(50)");
                builder.Property(p => p.Email).HasColumnType("varchar(50)");
                builder.Property(p => p.LoginIp).HasColumnType("varchar(20)");
                builder.Property(p => p.LoginTime).HasColumnType("datetime");
                builder.Property(p => p.IsEnable).HasColumnType("int");
                builder.Property(p => p.Remarks).HasColumnType("nvarchar(510)");
                builder.Property(p => p.CreateBy).HasColumnType("int");
                builder.Property(p => p.CreateTime).HasColumnType("datetime");
            });
        }
    }
}
