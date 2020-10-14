using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Mapping
{
    public partial class ReportCategoryDayClickMap
        : IEntityTypeConfiguration<AutoNews.Data.Entities.ReportCategoryDayClick>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AutoNews.Data.Entities.ReportCategoryDayClick> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Report_Category_DayClick", "dbo");

            // key
            builder.HasKey(t => t.CategoryClickId);

            // properties
            builder.Property(t => t.CategoryClickId)
                .IsRequired()
                .HasColumnName("CategoryClickId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.CategoryId)
                .HasColumnName("CategoryId")
                .HasColumnType("int");

            builder.Property(t => t.CategoryName)
                .HasColumnName("CategoryName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Count)
                .HasColumnName("Count")
                .HasColumnType("int");

            builder.Property(t => t.Today)
                .HasColumnName("Today")
                .HasColumnType("date");

            builder.Property(t => t.LastUpdateTime)
                .HasColumnName("LastUpdateTime")
                .HasColumnType("datetime");

            // relationships
            #endregion
        }

    }
}
