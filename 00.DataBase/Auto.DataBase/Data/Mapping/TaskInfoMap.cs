using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Mapping
{
    public partial class TaskInfoMap
        : IEntityTypeConfiguration<AutoNews.Data.Entities.TaskInfo>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AutoNews.Data.Entities.TaskInfo> builder)
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

            builder.Property(t => t.ShowDesc)
                .HasColumnName("ShowDesc")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.BeansText)
                .HasColumnName("BeansText")
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.Tips)
                .HasColumnName("Tips")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.IconType)
                .HasColumnName("IconType")
                .HasColumnType("int");

            builder.Property(t => t.JumpType)
                .HasColumnName("JumpType")
                .HasColumnType("int");

            builder.Property(t => t.JumpTitle)
                .HasColumnName("JumpTitle")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.JumpUrl)
                .HasColumnName("JumpUrl")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.CategoryDay)
                .HasColumnName("CategoryDay")
                .HasColumnType("int");

            builder.Property(t => t.CategoryFixed)
                .HasColumnName("CategoryFixed")
                .HasColumnType("int");

            builder.Property(t => t.Platform)
                .HasColumnName("Platform")
                .HasColumnType("nvarchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.IsNoviceTask)
                .HasColumnName("IsNoviceTask")
                .HasColumnType("int");

            builder.Property(t => t.IsDisplay)
                .HasColumnName("IsDisplay")
                .HasColumnType("int");

            builder.Property(t => t.MaxBeans)
                .HasColumnName("MaxBeans")
                .HasColumnType("int");

            builder.Property(t => t.MaxBeansDesc)
                .HasColumnName("MaxBeansDesc")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.IsRandom)
                .HasColumnName("IsRandom")
                .HasColumnType("int");

            builder.Property(t => t.FirstBeans)
                .HasColumnName("FirstBeans")
                .HasColumnType("int");

            builder.Property(t => t.RandomBefore)
                .HasColumnName("RandomBefore")
                .HasColumnType("int");

            builder.Property(t => t.RandomAfter)
                .HasColumnName("RandomAfter")
                .HasColumnType("int");

            builder.Property(t => t.FixedBeans)
                .HasColumnName("FixedBeans")
                .HasColumnType("int");

            builder.Property(t => t.Seconds)
                .HasColumnName("Seconds")
                .HasColumnType("int");

            builder.Property(t => t.UpperSeconds)
                .HasColumnName("UpperSeconds")
                .HasColumnType("int");

            builder.Property(t => t.UpperSecondsBeans)
                .HasColumnName("UpperSecondsBeans")
                .HasColumnType("int");

            builder.Property(t => t.UpperSecondsDesc)
                .HasColumnName("UpperSecondsDesc")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.UpperCount)
                .HasColumnName("UpperCount")
                .HasColumnType("int");

            builder.Property(t => t.UpperNumber)
                .HasColumnName("UpperNumber")
                .HasColumnType("int");

            builder.Property(t => t.UpperBeans)
                .HasColumnName("UpperBeans")
                .HasColumnType("int");

            builder.Property(t => t.UpperBeansDesc)
                .HasColumnName("UpperBeansDesc")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.IsTimeLimit)
                .HasColumnName("IsTimeLimit")
                .HasColumnType("int");

            builder.Property(t => t.BeforeTime)
                .HasColumnName("BeforeTime")
                .HasColumnType("datetime");

            builder.Property(t => t.AfterTime)
                .HasColumnName("AfterTime")
                .HasColumnType("datetime");

            builder.Property(t => t.IsDisposable)
                .HasColumnName("IsDisposable")
                .HasColumnType("int");

            builder.Property(t => t.Sequence)
                .HasColumnName("Sequence")
                .HasColumnType("int");

            builder.Property(t => t.IsRelatedTasks)
                .HasColumnName("IsRelatedTasks")
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
