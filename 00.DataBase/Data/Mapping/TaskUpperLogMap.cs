using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Mapping
{
    public partial class TaskUpperLogMap
        : IEntityTypeConfiguration<AutoNews.Data.Entities.TaskUpperLog>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AutoNews.Data.Entities.TaskUpperLog> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Task_UpperLog", "dbo");

            // key
            builder.HasKey(t => t.UpperLogId);

            // properties
            builder.Property(t => t.UpperLogId)
                .IsRequired()
                .HasColumnName("UpperLogId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.TaskId)
                .HasColumnName("TaskId")
                .HasColumnType("int");

            builder.Property(t => t.MemberId)
                .HasColumnName("MemberId")
                .HasColumnType("int");

            builder.Property(t => t.NewsId)
                .HasColumnName("NewsId")
                .HasColumnType("varchar(12)")
                .HasMaxLength(12);

            builder.Property(t => t.CreateTime)
                .HasColumnName("CreateTime")
                .HasColumnType("datetime");

            // relationships
            builder.HasOne(t => t.TaskInfo)
                .WithMany(t => t.TaskUpperLogs)
                .HasForeignKey(d => d.TaskId)
                .HasConstraintName("FK_TASK_UPP_REFERENCE_TASK_INF");

            #endregion
        }

    }
}
