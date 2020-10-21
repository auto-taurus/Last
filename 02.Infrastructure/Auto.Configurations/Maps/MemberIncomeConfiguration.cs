using System.Composition;
using Microsoft.EntityFrameworkCore;
using Auto.Entities.Modals;

namespace Auto.Configurations.Maps {
    [Export(typeof(IConfigurations))]
    public class MemberIncomeConfiguration : IConfigurations {
        public void Configure(ModelBuilder modelBuilder) {
            modelBuilder.Entity<MemberIncome>(builder => {
                // Set configuration for entity
                builder.ToTable("Member_Income", "dbo");

                // Set key for entity
                builder.HasKey(p => p.IncomeId);

                // Set identity for entity (auto increment)
                builder.Property(p => p.IncomeId).UseSqlServerIdentityColumn();

                // Set configuration for columns
                builder.Property(p => p.IncomeId).HasColumnType("int").IsRequired();
                builder.Property(p => p.MemberId).HasColumnType("int");
                builder.Property(p => p.TaskCode).HasColumnType("varchar(5)");
                builder.Property(p => p.TaksName).HasColumnType("nvarchar(40)");
                builder.Property(p => p.CategoryDay).HasColumnType("int");
                builder.Property(p => p.CategoryFixed).HasColumnType("int");
                builder.Property(p => p.Title).HasColumnType("nvarchar(200)");
                builder.Property(p => p.Beans).HasColumnType("int");
                builder.Property(p => p.BeansText).HasColumnType("nvarchar(20)");
                builder.Property(p => p.CreateTime).HasColumnType("datetime");
                builder.Property(p => p.Proportion).HasColumnType("varchar(20)");
                builder.Property(p => p.ReadTime).HasColumnType("int");
                builder.Property(p => p.Status).HasColumnType("int");
                builder.Property(p => p.Remarks).HasColumnType("nvarchar(510)");
                builder.Property(p => p.AuditBy).HasColumnType("int");
                builder.Property(p => p.AuditName).HasColumnType("nvarchar(100)");
                builder.Property(p => p.AuditTime).HasColumnType("datetime");

                // Add configuration for foreign keys
                builder
                    .HasOne(p => p.MemberInfos)
                    .WithMany(b => b.MemberIncomes)
                    .HasForeignKey(p => p.MemberId)
                    .HasConstraintName("FK_MEMBER_I_REFERENCE_MEMBER_I");

            });
        }
    }
}
