using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Mapping
{
    public partial class WebNewsMap
        : IEntityTypeConfiguration<AutoNews.Data.Entities.WebNews>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AutoNews.Data.Entities.WebNews> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Web_News", "dbo");

            // key
            builder.HasKey(t => t.NewsId);

            // properties
            builder.Property(t => t.NewsId)
                .IsRequired()
                .HasColumnName("NewsId")
                .HasColumnType("varchar(12)")
                .HasMaxLength(12);

            builder.Property(t => t.SiteId)
                .HasColumnName("SiteId")
                .HasColumnType("int");

            builder.Property(t => t.SpecialCode)
                .HasColumnName("SpecialCode")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.CategoryId)
                .HasColumnName("CategoryId")
                .HasColumnType("int");

            builder.Property(t => t.CategoryName)
                .HasColumnName("CategoryName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.NewsTitle)
                .HasColumnName("NewsTitle")
                .HasColumnType("nvarchar(500)")
                .HasMaxLength(500);

            builder.Property(t => t.CustomTitle)
                .HasColumnName("CustomTitle")
                .HasColumnType("nvarchar(500)")
                .HasMaxLength(500);

            builder.Property(t => t.Source)
                .HasColumnName("Source")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.SourceAddress)
                .HasColumnName("SourceAddress")
                .HasColumnType("nvarchar(1000)")
                .HasMaxLength(1000);

            builder.Property(t => t.SourceLogo)
                .HasColumnName("SourceLogo")
                .HasColumnType("nvarchar(1000)")
                .HasMaxLength(1000);

            builder.Property(t => t.Tags)
                .HasColumnName("Tags")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Contents)
                .HasColumnName("Contents")
                .HasColumnType("nvarchar(max)");

            builder.Property(t => t.Controller)
                .HasColumnName("Controller")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Action)
                .HasColumnName("Action")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Urls)
                .HasColumnName("Urls")
                .HasColumnType("nvarchar(1000)")
                .HasMaxLength(1000);

            builder.Property(t => t.ImageThums)
                .HasColumnName("ImageThums")
                .HasColumnType("nvarchar(2000)")
                .HasMaxLength(2000);

            builder.Property(t => t.ImagePaths)
                .HasColumnName("ImagePaths")
                .HasColumnType("nvarchar(2000)")
                .HasMaxLength(2000);

            builder.Property(t => t.DisplayType)
                .HasColumnName("DisplayType")
                .HasColumnType("int");

            builder.Property(t => t.IsHot)
                .HasColumnName("IsHot")
                .HasColumnType("int");

            builder.Property(t => t.Title)
                .HasColumnName("Title")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Keywords)
                .HasColumnName("Keywords")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Description)
                .HasColumnName("Description")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.AccessNumber)
                .HasColumnName("AccessNumber")
                .HasColumnType("int");

            builder.Property(t => t.VirtualAccessNumber)
                .HasColumnName("VirtualAccessNumber")
                .HasColumnType("int");

            builder.Property(t => t.ClickNumber)
                .HasColumnName("ClickNumber")
                .HasColumnType("int");

            builder.Property(t => t.Author)
                .HasColumnName("Author")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.AuditBy)
                .HasColumnName("AuditBy")
                .HasColumnType("int");

            builder.Property(t => t.AuditStatus)
                .HasColumnName("AuditStatus")
                .HasColumnType("int");

            builder.Property(t => t.AuditTime)
                .HasColumnName("AuditTime")
                .HasColumnType("datetime");

            builder.Property(t => t.PushBy)
                .HasColumnName("PushBy")
                .HasColumnType("int");

            builder.Property(t => t.PushStatus)
                .HasColumnName("PushStatus")
                .HasColumnType("int");

            builder.Property(t => t.PushTime)
                .HasColumnName("PushTime")
                .HasColumnType("datetime");

            builder.Property(t => t.OperateType)
                .HasColumnName("OperateType")
                .HasColumnType("int");

            builder.Property(t => t.CategorySort)
                .HasColumnName("CategorySort")
                .HasColumnType("int")
                .HasDefaultValueSql("((255))");

            builder.Property(t => t.SpecialSort)
                .HasColumnName("SpecialSort")
                .HasColumnType("int")
                .HasDefaultValueSql("((255))");

            builder.Property(t => t.Sequence)
                .HasColumnName("Sequence")
                .HasColumnType("int")
                .HasDefaultValueSql("((255))");

            builder.Property(t => t.IsEnable)
                .HasColumnName("IsEnable")
                .HasColumnType("int");

            builder.Property(t => t.RowVers)
                .IsRowVersion()
                .HasColumnName("RowVers")
                .HasColumnType("rowversion")
                .HasMaxLength(8)
                .ValueGeneratedOnAddOrUpdate();

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
            builder.HasOne(t => t.WebCategory)
                .WithMany(t => t.WebNews)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_WEB_NEWS_REFERENCE_WEB_CATE");

            #endregion
        }

    }
}
