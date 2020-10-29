using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Mapping
{
    public partial class MemberFansMap
        : IEntityTypeConfiguration<Master.Data.Entities.MemberFans>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Master.Data.Entities.MemberFans> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Member_Fans", "dbo");

            // key
            builder.HasKey(t => t.FansId);

            // properties
            builder.Property(t => t.FansId)
                .IsRequired()
                .HasColumnName("FansId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.MemberId)
                .HasColumnName("MemberId")
                .HasColumnType("int");

            builder.Property(t => t.MemberFansId)
                .HasColumnName("MemberFansId")
                .HasColumnType("int");

            builder.Property(t => t.MemberFansName)
                .HasColumnName("MemberFansName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

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
                .WithMany(t => t.MemberFans)
                .HasForeignKey(d => d.MemberId)
                .HasConstraintName("FK_MEMBER_F_REFERENCE_MEMBER_I");

            #endregion
        }

    }
}
