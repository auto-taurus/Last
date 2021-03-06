using System.Composition;
using Microsoft.EntityFrameworkCore;
using Auto.Entities.Modals;

namespace Auto.Configurations.Maps {
    [Export(typeof(IConfigurations))]
    public class MemberCommentConfiguration : IConfigurations {
        public void Configure(ModelBuilder modelBuilder) {
            modelBuilder.Entity<MemberComment>(builder => {
                // Set configuration for entity
                builder.ToTable("Member_Comment", "dbo");

                // Set key for entity
                builder.HasKey(p => p.CommentId);

                // Set identity for entity (auto increment)
                builder.Property(p => p.CommentId).UseSqlServerIdentityColumn();

                // Set configuration for columns
                builder.Property(p => p.CommentId).HasColumnType("int").IsRequired();
                builder.Property(p => p.NewsId).HasColumnType("varchar(12)");
                builder.Property(p => p.ParentId).HasColumnType("int");
                builder.Property(p => p.MemberId).HasColumnType("int");
                builder.Property(p => p.MemberName).HasColumnType("nvarchar(40)");
                builder.Property(p => p.CommentBody).HasColumnType("nvarchar(510)");
                builder.Property(p => p.CommentTime).HasColumnType("datetime");
                builder.Property(p => p.QuoteId).HasColumnType("int");
                builder.Property(p => p.QuoteName).HasColumnType("nvarchar(40)");
                builder.Property(p => p.Up).HasColumnType("int");
                builder.Property(p => p.Number).HasColumnType("int");
                builder.Property(p => p.IsEnable).HasColumnType("int");
                builder.Property(p => p.Remarks).HasColumnType("nvarchar(510)");

                // Add configuration for foreign keys
                builder
                    .HasOne(p => p.MemberInfos)
                    .WithMany(b => b.MemberComments)
                    .HasForeignKey(p => p.MemberId)
                    .HasConstraintName("FK_MEMBER_C_REFERENCE_MEMBER_I");

                builder
                    .HasOne(p => p.WebNews)
                    .WithMany(b => b.MemberComments)
                    .HasForeignKey(p => p.NewsId)
                    .HasConstraintName("FK_MEMBER_C_REFERENCE_WEB_NEWS");

            });
        }

    }
}
