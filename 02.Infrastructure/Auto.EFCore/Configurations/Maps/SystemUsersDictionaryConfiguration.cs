using Auto.EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using System.Composition;

namespace Auto.EFCore.Configurations.Maps {
    [Export(typeof(IEntityTypeConfiguration))]
    public class SystemUsersDictionaryConfiguration : IEntityTypeConfiguration {
        public void Configure(ModelBuilder modelBuilder) {
            modelBuilder.Entity<SystemUsersDictionary>(builder => {
                // Set configuration for entity
                builder.ToTable("System_UsersDictionary", "dbo");

                // Set key for entity
                builder.HasKey(p => p.Id);

                // Set identity for entity (auto increment)
                builder.Property(p => p.Id).UseSqlServerIdentityColumn();

                // Set configuration for columns
                builder.Property(p => p.Id).HasColumnType("int").IsRequired();
                builder.Property(p => p.UserId).HasColumnType("int").IsRequired();
                builder.Property(p => p.DictionaryKey).HasColumnType("varchar(20)");
                builder.Property(p => p.DictionaryValue).HasColumnType("nvarchar(200)");

                // Add configuration for foreign keys
                builder
                    .HasOne(p => p.SystemUsers)
                    .WithMany(b => b.SystemUsersDictionaries)
                    .HasForeignKey(p => p.UserId)
                    .HasConstraintName("FK_SYSTEM_U_REFERENCE_SYSTEM_UC");

            });
        }
    }
}
