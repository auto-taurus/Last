using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Auto.EFCore.Entities.WebNews" />
    /// </summary>
    public partial class WebNewsMap
        : IEntityTypeConfiguration<Auto.EFCore.Entities.WebNews>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Auto.EFCore.Entities.WebNews" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Auto.EFCore.Entities.WebNews> builder)
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
                .HasColumnType("int");

            builder.Property(t => t.SiteNo)
                .HasColumnName("SiteNo")
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

            builder.Property(t => t.ClickNumber)
                .HasColumnName("ClickNumber")
                .HasColumnType("int");

            builder.Property(t => t.AuditName)
                .HasColumnName("AuditName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.AuditStatus)
                .HasColumnName("AuditStatus")
                .HasColumnType("int");

            builder.Property(t => t.AuditTime)
                .HasColumnName("AuditTime")
                .HasColumnType("datetime");

            builder.Property(t => t.PushStatus)
                .HasColumnName("PushStatus")
                .HasColumnType("int");

            builder.Property(t => t.PushName)
                .HasColumnName("PushName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

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

            builder.Property(t => t.SingleSort)
                .HasColumnName("SingleSort")
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

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="Auto.EFCore.Entities.WebNews" /></summary>
            public const string Schema = "dbo";
            /// <summary>Table Name constant for entity <see cref="Auto.EFCore.Entities.WebNews" /></summary>
            public const string Name = "Web_News";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNews.NewsId" /></summary>
            public const string NewsId = "NewsId";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNews.SiteNo" /></summary>
            public const string SiteNo = "SiteNo";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNews.SpecialCode" /></summary>
            public const string SpecialCode = "SpecialCode";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNews.CategoryId" /></summary>
            public const string CategoryId = "CategoryId";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNews.CategoryName" /></summary>
            public const string CategoryName = "CategoryName";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNews.NewsTitle" /></summary>
            public const string NewsTitle = "NewsTitle";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNews.CustomTitle" /></summary>
            public const string CustomTitle = "CustomTitle";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNews.Source" /></summary>
            public const string Source = "Source";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNews.SourceAddress" /></summary>
            public const string SourceAddress = "SourceAddress";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNews.SourceLogo" /></summary>
            public const string SourceLogo = "SourceLogo";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNews.Tags" /></summary>
            public const string Tags = "Tags";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNews.Contents" /></summary>
            public const string Contents = "Contents";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNews.Controller" /></summary>
            public const string Controller = "Controller";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNews.Action" /></summary>
            public const string Action = "Action";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNews.Urls" /></summary>
            public const string Urls = "Urls";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNews.ImageThums" /></summary>
            public const string ImageThums = "ImageThums";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNews.ImagePaths" /></summary>
            public const string ImagePaths = "ImagePaths";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNews.DisplayType" /></summary>
            public const string DisplayType = "DisplayType";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNews.IsHot" /></summary>
            public const string IsHot = "IsHot";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNews.Title" /></summary>
            public const string Title = "Title";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNews.Keywords" /></summary>
            public const string Keywords = "Keywords";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNews.Description" /></summary>
            public const string Description = "Description";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNews.AccessNumber" /></summary>
            public const string AccessNumber = "AccessNumber";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNews.ClickNumber" /></summary>
            public const string ClickNumber = "ClickNumber";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNews.AuditName" /></summary>
            public const string AuditName = "AuditName";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNews.AuditStatus" /></summary>
            public const string AuditStatus = "AuditStatus";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNews.AuditTime" /></summary>
            public const string AuditTime = "AuditTime";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNews.PushStatus" /></summary>
            public const string PushStatus = "PushStatus";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNews.PushName" /></summary>
            public const string PushName = "PushName";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNews.PushTime" /></summary>
            public const string PushTime = "PushTime";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNews.OperateType" /></summary>
            public const string OperateType = "OperateType";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNews.CategorySort" /></summary>
            public const string CategorySort = "CategorySort";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNews.SingleSort" /></summary>
            public const string SingleSort = "SingleSort";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNews.Sequence" /></summary>
            public const string Sequence = "Sequence";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNews.IsEnable" /></summary>
            public const string IsEnable = "IsEnable";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNews.RowVers" /></summary>
            public const string RowVers = "RowVers";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNews.Remarks" /></summary>
            public const string Remarks = "Remarks";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNews.CreateBy" /></summary>
            public const string CreateBy = "CreateBy";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNews.CreateTime" /></summary>
            public const string CreateTime = "CreateTime";
        }
        #endregion
    }
}
