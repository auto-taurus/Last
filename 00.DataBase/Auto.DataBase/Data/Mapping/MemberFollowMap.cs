using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Mapping
{
    public partial class MemberFollowMap
        : IEntityTypeConfiguration<AutoNews.Data.Entities.MemberFollow>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AutoNews.Data.Entities.MemberFollow> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Member_Follow", "dbo");

            // key
            builder.HasKey(t => t.FollowId);

            // properties
            builder.Property(t => t.FollowId)
                .IsRequired()
                .HasColumnName("FollowId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.MemberId)
                .HasColumnName("MemberId")
                .HasColumnType("int");

            builder.Property(t => t.SourceId)
                .HasColumnName("SourceId")
                .HasColumnType("int");

            builder.Property(t => t.SourceTable)
                .HasColumnName("SourceTable")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.CategoryId)
                .HasColumnName("CategoryId")
                .HasColumnType("int");

            builder.Property(t => t.FollowTime)
                .HasColumnName("FollowTime")
                .HasColumnType("datetime");

            builder.Property(t => t.IsEnable)
                .HasColumnName("IsEnable")
                .HasColumnType("int");

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            // relationships
            builder.HasOne(t => t.MemberInfos)
                .WithMany(t => t.MemberFollows)
                .HasForeignKey(d => d.MemberId)
                .HasConstraintName("FK_MEMBER_F_REFERENCE_MEMBER_I2");

            #endregion
        }

    }
}
