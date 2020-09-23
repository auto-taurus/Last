using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Mapping
{
    public partial class WebNewsSensitiveMap
        : IEntityTypeConfiguration<AutoNews.Data.Entities.WebNewsSensitive>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AutoNews.Data.Entities.WebNewsSensitive> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Web_NewsSensitive", "dbo");

            // key
            builder.HasKey(t => t.NewsSensitiveId);

            // properties
            builder.Property(t => t.NewsSensitiveId)
                .IsRequired()
                .HasColumnName("NewsSensitiveId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.SiteMark)
                .HasColumnName("SiteMark")
                .HasColumnType("int");

            builder.Property(t => t.NewId)
                .HasColumnName("NewId")
                .HasColumnType("int");

            builder.Property(t => t.NewTitleRecords)
                .HasColumnName("NewTitleRecords")
                .HasColumnType("nvarchar(1000)")
                .HasMaxLength(1000);

            builder.Property(t => t.CustomTitleRecords)
                .HasColumnName("CustomTitleRecords")
                .HasColumnType("nvarchar(1000)")
                .HasMaxLength(1000);

            builder.Property(t => t.ContentsRecords)
                .HasColumnName("ContentsRecords")
                .HasColumnType("nvarchar(1000)")
                .HasMaxLength(1000);

            builder.Property(t => t.IsEnable)
                .HasColumnName("IsEnable")
                .HasColumnType("int");

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("nvarchar(1000)")
                .HasMaxLength(1000);

            builder.Property(t => t.CreateBy)
                .HasColumnName("CreateBy")
                .HasColumnType("int");

            builder.Property(t => t.CreateTime)
                .HasColumnName("CreateTime")
                .HasColumnType("smalldatetime");

            // relationships
            #endregion
        }

    }
}
