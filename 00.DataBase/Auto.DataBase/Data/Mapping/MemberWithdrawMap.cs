using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Mapping
{
    public partial class MemberWithdrawMap
        : IEntityTypeConfiguration<AutoNews.Data.Entities.MemberWithdraw>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AutoNews.Data.Entities.MemberWithdraw> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Member_Withdraw", "dbo");

            // key
            builder.HasKey(t => t.WithdrawId);

            // properties
            builder.Property(t => t.WithdrawId)
                .IsRequired()
                .HasColumnName("WithdrawId")
                .HasColumnType("bigint");

            builder.Property(t => t.MemberId)
                .HasColumnName("MemberId")
                .HasColumnType("int");

            builder.Property(t => t.Methods)
                .HasColumnName("Methods")
                .HasColumnType("int");

            builder.Property(t => t.Title)
                .HasColumnName("Title")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Beans)
                .HasColumnName("Beans")
                .HasColumnType("int");

            builder.Property(t => t.Amount)
                .HasColumnName("Amount")
                .HasColumnType("decimal(18,2)");

            builder.Property(t => t.Proportion)
                .HasColumnName("Proportion")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.CreateTime)
                .HasColumnName("CreateTime")
                .HasColumnType("datetime");

            builder.Property(t => t.Status)
                .HasColumnName("Status")
                .HasColumnType("int");

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.AuditId)
                .HasColumnName("AuditId")
                .HasColumnType("int");

            builder.Property(t => t.Audit)
                .HasColumnName("Audit")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.AuditTime)
                .HasColumnName("AuditTime")
                .HasColumnType("datetime");

            // relationships
            builder.HasOne(t => t.MemberInfos)
                .WithMany(t => t.MemberWithdraws)
                .HasForeignKey(d => d.MemberId)
                .HasConstraintName("FK_MEMBER_W_REFERENCE_MEMBER_I");

            #endregion
        }

    }
}
