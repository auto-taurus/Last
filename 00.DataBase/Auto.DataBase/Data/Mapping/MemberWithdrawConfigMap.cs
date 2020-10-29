using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Mapping
{
    public partial class MemberWithdrawConfigMap
        : IEntityTypeConfiguration<Master.Data.Entities.MemberWithdrawConfig>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Master.Data.Entities.MemberWithdrawConfig> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Member_WithdrawConfig", "dbo");

            // key
            builder.HasKey(t => t.WithdrawConfigId);

            // properties
            builder.Property(t => t.WithdrawConfigId)
                .IsRequired()
                .HasColumnName("WithdrawConfigId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Methods)
                .HasColumnName("Methods")
                .HasColumnType("int");

            builder.Property(t => t.Tips)
                .HasColumnName("Tips")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.WithdrawTask)
                .HasColumnName("WithdrawTask")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.Amount)
                .HasColumnName("Amount")
                .HasColumnType("decimal(18,2)");

            builder.Property(t => t.AmountTips)
                .HasColumnName("AmountTips")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.AmountDesc)
                .HasColumnName("AmountDesc")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.AmountTask)
                .HasColumnName("AmountTask")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.Desc)
                .HasColumnName("Desc")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.IsEnable)
                .HasColumnName("IsEnable")
                .HasColumnType("int");

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("varchar(255)")
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
