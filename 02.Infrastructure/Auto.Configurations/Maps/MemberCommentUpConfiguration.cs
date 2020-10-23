using Auto.Entities.Modals;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Composition;
using System.Text;

namespace Auto.Configurations.Maps {
    [Export(typeof(IConfigurations))]
    public class MemberCommentUpConfiguration : IConfigurations {
        public void Configure(ModelBuilder modelBuilder) {
            modelBuilder.Entity<MemberCommentUp>(builder => {
                // Set configuration for entity
                builder.ToTable("Member_CommentUp", "dbo");

                // Set key for entity
                builder.HasKey(p => p.CommentUpId);

                // Set identity for entity (auto increment)
                builder.Property(p => p.CommentUpId).UseSqlServerIdentityColumn();

                // Set configuration for columns
                builder.Property(p => p.CommentUpId).HasColumnType("int").IsRequired();
                builder.Property(p => p.CommentId).HasColumnType("int");
                builder.Property(p => p.MemberId).HasColumnType("int");

                // Add configuration for foreign keys
                builder
                    .HasOne(p => p.MemberComment)
                    .WithMany(b => b.MemberCommentUps)
                    .HasForeignKey(p => p.CommentId)
                    .HasConstraintName("FK_MEMBER_C_REFERENCE_MEMBER_C");

            });
        }
    }
}
