using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Mapping
{
    public partial class TaskInfoMap
        : IEntityTypeConfiguration<Master.Data.Entities.TaskInfo>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Master.Data.Entities.TaskInfo> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Task_Info", "dbo");

            // key
            builder.HasKey(t => t.TaskId);

            // properties
            builder.Property(t => t.TaskId)
                .IsRequired()
                .HasColumnName("TaskId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.TaskCode)
                .HasColumnName("TaskCode")
                .HasColumnType("varchar(5)")
                .HasMaxLength(5);

            builder.Property(t => t.RelatedTasks)
                .HasColumnName("RelatedTasks")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.TaskName)
                .HasColumnName("TaskName")
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.Desc)
                .HasColumnName("Desc")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.SaveDesc)
                .HasColumnName("SaveDesc")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.CategoryDay)
                .HasColumnName("CategoryDay")
                .HasColumnType("int");

            builder.Property(t => t.CategoryFixed)
                .HasColumnName("CategoryFixed")
                .HasColumnType("int");

            builder.Property(t => t.Platform)
                .HasColumnName("Platform")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Beans)
                .HasColumnName("Beans")
                .HasColumnType("bigint");

            builder.Property(t => t.BeansText)
                .HasColumnName("BeansText")
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.IsDisplay)
                .HasColumnName("IsDisplay")
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
            #endregion
        }

    }
}
