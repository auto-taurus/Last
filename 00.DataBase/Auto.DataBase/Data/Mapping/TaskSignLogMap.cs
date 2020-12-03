using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Mapping
{
    public partial class TaskSignLogMap
        : IEntityTypeConfiguration<AutoNews.Data.Entities.TaskSignLog>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AutoNews.Data.Entities.TaskSignLog> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Task_SignLog", "dbo");

            // key
            builder.HasKey(t => t.SignLogId);

            // properties
            builder.Property(t => t.SignLogId)
                .IsRequired()
                .HasColumnName("SignLogId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.TaskId)
                .HasColumnName("TaskId")
                .HasColumnType("int");

            builder.Property(t => t.MemberId)
                .HasColumnName("MemberId")
                .HasColumnType("int");

            builder.Property(t => t.SignNumber)
                .HasColumnName("SignNumber")
                .HasColumnType("int");

            builder.Property(t => t.CreateTime)
                .HasColumnName("CreateTime")
                .HasColumnType("datetime");

            // relationships
            builder.HasOne(t => t.TaskInfo)
                .WithMany(t => t.TaskSignLogs)
                .HasForeignKey(d => d.TaskId)
                .HasConstraintName("FK_TASK_SIG_REFERENCE_TASK_INF");

            #endregion
        }

    }
}
