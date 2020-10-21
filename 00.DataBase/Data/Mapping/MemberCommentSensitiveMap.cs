using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Mapping
{
    public partial class MemberCommentSensitiveMap
        : IEntityTypeConfiguration<AutoNews.Data.Entities.MemberCommentSensitive>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AutoNews.Data.Entities.MemberCommentSensitive> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Member_CommentSensitive", "dbo");

            // key
            builder.HasKey(t => t.CommentSensitiveId);

            // properties
            builder.Property(t => t.CommentSensitiveId)
                .IsRequired()
                .HasColumnName("CommentSensitiveId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.SensitiveWords)
                .HasColumnName("SensitiveWords")
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.ReplaceValue)
                .HasColumnName("ReplaceValue")
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
        }

    }
}
