using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Auto.EFCore.Entities.WebSite" />
    /// </summary>
    public partial class WebSiteMap
        : IEntityTypeConfiguration<Auto.EFCore.Entities.WebSite>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Auto.EFCore.Entities.WebSite" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Auto.EFCore.Entities.WebSite> builder)
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

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="Auto.EFCore.Entities.WebSite" /></summary>
            public const string Schema = "dbo";
            /// <summary>Table Name constant for entity <see cref="Auto.EFCore.Entities.WebSite" /></summary>
            public const string Name = "Web_Site";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebSite.SiteId" /></summary>
            public const string SiteId = "SiteId";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebSite.SiteNo" /></summary>
            public const string SiteNo = "SiteNo";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebSite.SiteName" /></summary>
            public const string SiteName = "SiteName";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebSite.SiteUrls" /></summary>
            public const string SiteUrls = "SiteUrls";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebSite.LogoUrls" /></summary>
            public const string LogoUrls = "LogoUrls";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebSite.Count" /></summary>
            public const string Count = "Count";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebSite.Title" /></summary>
            public const string Title = "Title";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebSite.Keywords" /></summary>
            public const string Keywords = "Keywords";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebSite.Description" /></summary>
            public const string Description = "Description";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebSite.RowVers" /></summary>
            public const string RowVers = "RowVers";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebSite.IsEnable" /></summary>
            public const string IsEnable = "IsEnable";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebSite.Remarks" /></summary>
            public const string Remarks = "Remarks";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebSite.CreateBy" /></summary>
            public const string CreateBy = "CreateBy";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebSite.CreateTime" /></summary>
            public const string CreateTime = "CreateTime";
        }
        #endregion
    }
}
