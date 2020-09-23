using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Mapping
{
    public partial class WebSiteMap
        : IEntityTypeConfiguration<AutoNews.Data.Entities.WebSite>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AutoNews.Data.Entities.WebSite> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Web_Site", "dbo");

            // key
            builder.HasKey(t => t.SiteId);

            // properties
            builder.Property(t => t.SiteId)
                .IsRequired()
                .HasColumnName("SiteId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.SiteNo)
                .HasColumnName("SiteNo")
                .HasColumnType("int");

            builder.Property(t => t.SiteName)
                .HasColumnName("SiteName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.SiteUrls)
                .HasColumnName("SiteUrls")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.LogoUrls)
                .HasColumnName("LogoUrls")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Count)
                .HasColumnName("Count")
                .HasColumnType("int");

            builder.Property(t => t.Title)
                .HasColumnName("Title")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Keywords)
                .HasColumnName("Keywords")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Description)
                .HasColumnName("Description")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

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
