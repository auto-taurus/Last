using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Mapping
{
    public partial class TaskDetailsMap
        : IEntityTypeConfiguration<AutoNews.Data.Entities.TaskDetails>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AutoNews.Data.Entities.TaskDetails> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Task_Details", "dbo");

            // key
            builder.HasKey(t => t.TaskDetailsId);

            // properties
            builder.Property(t => t.TaskDetailsId)
                .IsRequired()
                .HasColumnName("TaskDetailsId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.TaskId)
                .HasColumnName("TaskId")
                .HasColumnType("int");

            builder.Property(t => t.ShowDesc)
                .HasColumnName("ShowDesc")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Beans)
                .HasColumnName("Beans")
                .HasColumnType("int");

            builder.Property(t => t.ExtraBeans)
                .HasColumnName("ExtraBeans")
                .HasColumnType("int");

            builder.Property(t => t.SaveDesc)
                .HasColumnName("SaveDesc")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Sequence)
                .HasColumnName("Sequence")
                .HasColumnType("int");

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
            builder.HasOne(t => t.TaskInfo)
                .WithMany(t => t.TaskDetails)
                .HasForeignKey(d => d.TaskId)
                .HasConstraintName("FK_TASK_DET_REFERENCE_TASK_INF");

            #endregion
        }

    }
}
