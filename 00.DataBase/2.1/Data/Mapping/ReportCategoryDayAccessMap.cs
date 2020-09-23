using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Mapping
{
    public partial class ReportCategoryDayAccessMap
        : IEntityTypeConfiguration<AutoNews.Data.Entities.ReportCategoryDayAccess>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AutoNews.Data.Entities.ReportCategoryDayAccess> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Report_Category_DayAccess", "dbo");

            // key
            builder.HasKey(t => t.CategoryAccessId);

            // properties
            builder.Property(t => t.CategoryAccessId)
                .IsRequired()
                .HasColumnName("CategoryAccessId")
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
