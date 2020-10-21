using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Mapping
{
    public partial class WebSensitiveMap
        : IEntityTypeConfiguration<AutoNews.Data.Entities.WebSensitive>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AutoNews.Data.Entities.WebSensitive> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Web_Sensitive", "dbo");

            // key
            builder.HasKey(t => t.SensitiveId);

            // properties
            builder.Property(t => t.SensitiveId)
                .IsRequired()
                .HasColumnName("SensitiveId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.SiteId)
                .HasColumnName("SiteId")
                .HasColumnType("int");

            builder.Property(t => t.Type)
                .HasColumnName("Type")
                .HasColumnType("int");

            builder.Property(t => t.TypeText)
                .HasColumnName("TypeText")
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.SensitiveWords)
                .HasColumnName("SensitiveWords")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Author)
                .HasColumnName("Author")
                .HasColumnType("nvarchar(1000)")
                .HasMaxLength(1000);

            builder.Property(t => t.Urls)
                .HasColumnName("Urls")
                .HasColumnType("nvarchar(4000)")
                .HasMaxLength(4000);

            builder.Property(t => t.RowVers)
                .IsRowVersion()
                .HasColumnName("RowVers")
                .HasColumnType("rowversion")
                .HasMaxLength(8)
                .ValueGeneratedOnAddOrUpdate();

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
