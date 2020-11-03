using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Mapping
{
    public partial class MemberCommentUpMap
        : IEntityTypeConfiguration<AutoNews.Data.Entities.MemberCommentUp>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AutoNews.Data.Entities.MemberCommentUp> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Member_CommentUp", "dbo");

            // key
            builder.HasKey(t => t.CommentUpId);

            // properties
            builder.Property(t => t.CommentUpId)
                .IsRequired()
                .HasColumnName("CommentUpId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.CommentId)
                .HasColumnName("CommentId")
                .HasColumnType("int");

            builder.Property(t => t.MemberId)
                .HasColumnName("MemberId")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.MemberComment)
                .WithMany(t => t.MemberCommentUps)
                .HasForeignKey(d => d.CommentId)
                .HasConstraintName("FK_MEMBER_C_REFERENCE_MEMBER_C");

            #endregion
        }

    }
}
