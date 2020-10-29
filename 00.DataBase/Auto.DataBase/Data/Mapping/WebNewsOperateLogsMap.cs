using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Mapping
{
    public partial class WebNewsOperateLogsMap
        : IEntityTypeConfiguration<Master.Data.Entities.WebNewsOperateLogs>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Master.Data.Entities.WebNewsOperateLogs> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Web_NewsOperate_Logs", "dbo");

            // key
            builder.HasKey(t => t.NewsOperateId);

            // properties
            builder.Property(t => t.NewsOperateId)
                .IsRequired()
                .HasColumnName("NewsOperateId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.NewsId)
                .HasColumnName("NewsId")
                .HasColumnType("varchar(12)")
                .HasMaxLength(12);

            builder.Property(t => t.OperateType)
                .HasColumnName("OperateType")
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.OperateStatus)
                .HasColumnName("OperateStatus")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.CreateBy)
                .HasColumnName("CreateBy")
                .HasColumnType("int");

            builder.Property(t => t.CreateName)
                .HasColumnName("CreateName")
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.CreateTime)
                .HasColumnName("CreateTime")
                .HasColumnType("datetime");

            // relationships
            builder.HasOne(t => t.WebNews)
                .WithMany(t => t.WebNewsOperateLogs)
                .HasForeignKey(d => d.NewsId)
                .HasConstraintName("FK_WEB_NEWS_REFERENCE_WEB_NEWS");

            #endregion
        }

    }
}
