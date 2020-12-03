using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Mapping
{
    public partial class MemberCommentMap
        : IEntityTypeConfiguration<AutoNews.Data.Entities.MemberComment>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AutoNews.Data.Entities.MemberComment> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Member_Comment", "dbo");

            // key
            builder.HasKey(t => t.CommentId);

            // properties
            builder.Property(t => t.CommentId)
                .IsRequired()
                .HasColumnName("CommentId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.NewsId)
                .HasColumnName("NewsId")
                .HasColumnType("varchar(12)")
                .HasMaxLength(12);

            builder.Property(t => t.ParentId)
                .HasColumnName("ParentId")
                .HasColumnType("int");

            builder.Property(t => t.MemberId)
                .HasColumnName("MemberId")
                .HasColumnType("int");

            builder.Property(t => t.MemberName)
                .HasColumnName("MemberName")
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.CommentBody)
                .HasColumnName("CommentBody")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.CommentTime)
                .HasColumnName("CommentTime")
                .HasColumnType("datetime");

            builder.Property(t => t.QuoteId)
                .HasColumnName("QuoteId")
                .HasColumnType("int");

            builder.Property(t => t.QuoteName)
                .HasColumnName("QuoteName")
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.Up)
                .HasColumnName("Up")
                .HasColumnType("int");

            builder.Property(t => t.Number)
                .HasColumnName("Number")
                .HasColumnType("int");

            builder.Property(t => t.IsEnable)
                .HasColumnName("IsEnable")
                .HasColumnType("int");

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            // relationships
            builder.HasOne(t => t.MemberInfos)
                .WithMany(t => t.MemberComments)
                .HasForeignKey(d => d.MemberId)
                .HasConstraintName("FK_MEMBER_C_REFERENCE_MEMBER_I");

            builder.HasOne(t => t.WebNews)
                .WithMany(t => t.MemberComments)
                .HasForeignKey(d => d.NewsId)
                .HasConstraintName("FK_MEMBER_C_REFERENCE_WEB_NEWS");

            #endregion
        }

    }
}
