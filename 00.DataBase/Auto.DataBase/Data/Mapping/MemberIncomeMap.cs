using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Mapping
{
    public partial class MemberIncomeMap
        : IEntityTypeConfiguration<AutoNews.Data.Entities.MemberIncome>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AutoNews.Data.Entities.MemberIncome> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Member_Income", "dbo");

            // key
            builder.HasKey(t => t.IncomeId);

            // properties
            builder.Property(t => t.IncomeId)
                .IsRequired()
                .HasColumnName("IncomeId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.MemberId)
                .HasColumnName("MemberId")
                .HasColumnType("int");

            builder.Property(t => t.TaskCode)
                .HasColumnName("TaskCode")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.TaksName)
                .HasColumnName("TaksName")
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.CategoryDay)
                .HasColumnName("CategoryDay")
                .HasColumnType("int");

            builder.Property(t => t.CategoryFixed)
                .HasColumnName("CategoryFixed")
                .HasColumnType("int");

            builder.Property(t => t.Title)
                .HasColumnName("Title")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Beans)
                .HasColumnName("Beans")
                .HasColumnType("int");

            builder.Property(t => t.BeansText)
                .HasColumnName("BeansText")
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.CreateTime)
                .HasColumnName("CreateTime")
                .HasColumnType("datetime");

            builder.Property(t => t.Proportion)
                .HasColumnName("Proportion")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.ReadTime)
                .HasColumnName("ReadTime")
                .HasColumnType("int");

            builder.Property(t => t.Status)
                .HasColumnName("Status")
                .HasColumnType("int");

            builder.Property(t => t.AuditBy)
                .HasColumnName("AuditBy")
                .HasColumnType("int");

            builder.Property(t => t.AuditName)
                .HasColumnName("AuditName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.AuditTime)
                .HasColumnName("AuditTime")
                .HasColumnType("datetime");

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            // relationships
            builder.HasOne(t => t.MemberInfos)
                .WithMany(t => t.MemberIncomes)
                .HasForeignKey(d => d.MemberId)
                .HasConstraintName("FK_MEMBER_I_REFERENCE_MEMBER_I");

            #endregion
        }

    }
}
