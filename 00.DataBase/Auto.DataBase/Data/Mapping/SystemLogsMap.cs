using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Mapping
{
    public partial class SystemLogsMap
        : IEntityTypeConfiguration<AutoNews.Data.Entities.SystemLogs>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AutoNews.Data.Entities.SystemLogs> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("System_Logs", "dbo");

            // key
            builder.HasKey(t => t.LogsId);

            // properties
            builder.Property(t => t.LogsId)
                .IsRequired()
                .HasColumnName("LogsId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Methods)
                .HasColumnName("Methods")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Grade)
                .HasColumnName("Grade")
                .HasColumnType("int");

            builder.Property(t => t.Source)
                .HasColumnName("Source")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Args)
                .HasColumnName("Args")
                .HasColumnType("nvarchar(2000)")
                .HasMaxLength(2000);

            builder.Property(t => t.Errors)
                .HasColumnName("Errors")
                .HasColumnType("nvarchar(2000)")
                .HasMaxLength(2000);

            builder.Property(t => t.CreateBy)
                .HasColumnName("CreateBy")
                .HasColumnType("int");

            builder.Property(t => t.CreateTime)
                .IsRequired()
                .HasColumnName("CreateTime")
                .HasColumnType("datetime");

            // relationships
            #endregion
        }

    }
}
