using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Mapping
{
    public partial class TaskNoviceLogMap
        : IEntityTypeConfiguration<AutoNews.Data.Entities.TaskNoviceLog>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AutoNews.Data.Entities.TaskNoviceLog> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Task_NoviceLog", "dbo");

            // key
            builder.HasKey(t => t.NoviceLogId);

            // properties
            builder.Property(t => t.NoviceLogId)
                .IsRequired()
                .HasColumnName("NoviceLogId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.TaskId)
                .HasColumnName("TaskId")
                .HasColumnType("int");

            builder.Property(t => t.MemberId)
                .HasColumnName("MemberId")
                .HasColumnType("int");

            builder.Property(t => t.IsEnable)
                .HasColumnName("IsEnable")
                .HasColumnType("int");

            // relationships
            #endregion
        }

    }
}
