using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Mapping
{
    public partial class ReportNewsDayClickMap
        : IEntityTypeConfiguration<Master.Data.Entities.ReportNewsDayClick>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Master.Data.Entities.ReportNewsDayClick> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Report_News_DayClick", "dbo");

            // key
            builder.HasKey(t => t.NewsClickId);

            // properties
            builder.Property(t => t.NewsClickId)
                .IsRequired()
                .HasColumnName("NewsClickId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.NewsId)
                .HasColumnName("NewsId")
                .HasColumnType("int");

            builder.Property(t => t.CategoryId)
                .HasColumnName("CategoryId")
                .HasColumnType("int");

            builder.Property(t => t.CategoryName)
                .HasColumnName("CategoryName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.SpecialCode)
                .HasColumnName("SpecialCode")
                .HasColumnType("int");

            builder.Property(t => t.SpecialName)
                .HasColumnName("SpecialName")
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
