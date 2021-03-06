using System.Composition;
using Microsoft.EntityFrameworkCore;
using Auto.Entities.Modals;

namespace Auto.Configurations.Maps {
    [Export(typeof(IConfigurations))]
    public class MemberProblemConfiguration : IConfigurations {
        public void Configure(ModelBuilder modelBuilder) {
            modelBuilder.Entity<MemberProblem>(builder => {
                // Set configuration for entity
                builder.ToTable("Member_Problem", "dbo");

                // Set key for entity
                builder.HasKey(p => p.ProblemId);

                // Set identity for entity (auto increment)
                builder.Property(p => p.ProblemId).UseSqlServerIdentityColumn();

                // Set configuration for columns
                builder.Property(p => p.ProblemId).HasColumnType("int").IsRequired();
                builder.Property(p => p.Title).HasColumnType("nvarchar(100)");
                builder.Property(p => p.Desc).HasColumnType("nvarchar(510)");
                builder.Property(p => p.Type).HasColumnType("int");
                builder.Property(p => p.Urls).HasColumnType("nvarchar(510)");
                builder.Property(p => p.IsHot).HasColumnType("int");
                builder.Property(p => p.Sequence).HasColumnType("int");
                builder.Property(p => p.IsEnable).HasColumnType("int");
                builder.Property(p => p.Remarks).HasColumnType("nvarchar(510)");
                builder.Property(p => p.CreateBy).HasColumnType("int");
                builder.Property(p => p.CreateTime).HasColumnType("datetime");

            });
        }
    }
}
