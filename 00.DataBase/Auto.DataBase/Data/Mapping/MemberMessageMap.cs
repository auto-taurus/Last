using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Mapping
{
    public partial class MemberMessageMap
        : IEntityTypeConfiguration<AutoNews.Data.Entities.MemberMessage>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AutoNews.Data.Entities.MemberMessage> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Member_Message", "dbo");

            // key
            builder.HasKey(t => t.MessageId);

            // properties
            builder.Property(t => t.MessageId)
                .IsRequired()
                .HasColumnName("MessageId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.MemberId)
                .HasColumnName("MemberId")
                .HasColumnType("int");

            builder.Property(t => t.MemberName)
                .HasColumnName("MemberName")
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.LeaveBody)
                .HasColumnName("LeaveBody")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.LeaveType)
                .HasColumnName("LeaveType")
                .HasColumnType("int");

            builder.Property(t => t.CreateTime)
                .HasColumnName("CreateTime")
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
                .WithMany(t => t.MemberMessages)
                .HasForeignKey(d => d.MemberId)
                .HasConstraintName("FK_MEMBER_M_REFERENCE_MEMBER_I");

            #endregion
        }

    }
}
