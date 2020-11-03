using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Mapping
{
    public partial class ReportSiteDayAccessMap
        : IEntityTypeConfiguration<AutoNews.Data.Entities.ReportSiteDayAccess>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AutoNews.Data.Entities.ReportSiteDayAccess> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Report_Site_DayAccess", "dbo");

            // key
            builder.HasKey(t => t.SiteAccessId);

            // properties
            builder.Property(t => t.SiteAccessId)
                .IsRequired()
                .HasColumnName("SiteAccessId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.SiteId)
                .HasColumnName("SiteId")
                .HasColumnType("int");

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
