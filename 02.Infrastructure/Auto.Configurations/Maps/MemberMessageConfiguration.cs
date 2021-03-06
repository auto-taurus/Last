using System.Composition;
using Microsoft.EntityFrameworkCore;
using Auto.Entities.Modals;

namespace Auto.Configurations.Maps {
    [Export(typeof(IConfigurations))]
    public class MemberMessageConfiguration : IConfigurations {
        public void Configure(ModelBuilder modelBuilder) {
            modelBuilder.Entity<MemberMessage>(builder => {
                // Set configuration for entity
                builder.ToTable("Member_Message", "dbo");

                // Set key for entity
                builder.HasKey(p => p.MessageId);

                // Set identity for entity (auto increment)
                builder.Property(p => p.MessageId).UseSqlServerIdentityColumn();

                // Set configuration for columns
                builder.Property(p => p.MessageId).HasColumnType("int").IsRequired();
                builder.Property(p => p.MemberId).HasColumnType("int");
                builder.Property(p => p.MemberName).HasColumnType("nvarchar(40)");
                builder.Property(p => p.LeaveBody).HasColumnType("nvarchar(510)");
                builder.Property(p => p.LeaveType).HasColumnType("int");
                builder.Property(p => p.CreateTime).HasColumnType("datetime");
                builder.Property(p => p.IsEnable).HasColumnType("int");
                builder.Property(p => p.Remarks).HasColumnType("nvarchar(510)");

                // Add configuration for foreign keys
                builder
                    .HasOne(p => p.MemberInfos)
                    .WithMany(b => b.MemberMessages)
                    .HasForeignKey(p => p.MemberId)
                    .HasConstraintName("FK_MEMBER_M_REFERENCE_MEMBER_I");

            });
        }
    }
}
