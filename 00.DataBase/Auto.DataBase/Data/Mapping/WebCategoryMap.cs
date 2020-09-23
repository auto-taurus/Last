using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Auto.EFCore.Entities.WebCategory" />
    /// </summary>
    public partial class WebCategoryMap
        : IEntityTypeConfiguration<Auto.EFCore.Entities.WebCategory>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Auto.EFCore.Entities.WebCategory" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Auto.EFCore.Entities.WebCategory> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Web_Category", "dbo");

            // key
            builder.HasKey(t => t.CategoryId);

            // properties
            builder.Property(t => t.CategoryId)
                .IsRequired()
                .HasColumnName("CategoryId")
                .HasColumnType("int");

            builder.Property(t => t.SiteNo)
                .HasColumnName("SiteNo")
                .HasColumnType("int");

            builder.Property(t => t.CategoryName)
                .HasColumnName("CategoryName")
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.ParentId)
                .HasColumnName("ParentId")
                .HasColumnType("int");

            builder.Property(t => t.NodeValue)
                .HasColumnName("NodeValue")
                .HasColumnType("varchar(1000)")
                .HasMaxLength(1000);

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
                .HasColumnType("varchar(500)")
                .HasMaxLength(500);

            builder.Property(t => t.DocumentNumber)
                .HasColumnName("DocumentNumber")
                .HasColumnType("int");

            builder.Property(t => t.VirtualAccessNumber)
                .HasColumnName("VirtualAccessNumber")
                .HasColumnType("int");

            builder.Property(t => t.AccessNumber)
                .HasColumnName("AccessNumber")
                .HasColumnType("int");

            builder.Property(t => t.ClickNumber)
                .HasColumnName("ClickNumber")
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
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="Auto.EFCore.Entities.WebCategory" /></summary>
            public const string Schema = "dbo";
            /// <summary>Table Name constant for entity <see cref="Auto.EFCore.Entities.WebCategory" /></summary>
            public const string Name = "Web_Category";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebCategory.CategoryId" /></summary>
            public const string CategoryId = "CategoryId";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebCategory.SiteNo" /></summary>
            public const string SiteNo = "SiteNo";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebCategory.CategoryName" /></summary>
            public const string CategoryName = "CategoryName";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebCategory.ParentId" /></summary>
            public const string ParentId = "ParentId";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebCategory.NodeValue" /></summary>
            public const string NodeValue = "NodeValue";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebCategory.Controller" /></summary>
            public const string Controller = "Controller";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebCategory.Action" /></summary>
            public const string Action = "Action";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebCategory.Urls" /></summary>
            public const string Urls = "Urls";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebCategory.DocumentNumber" /></summary>
            public const string DocumentNumber = "DocumentNumber";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebCategory.VirtualAccessNumber" /></summary>
            public const string VirtualAccessNumber = "VirtualAccessNumber";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebCategory.AccessNumber" /></summary>
            public const string AccessNumber = "AccessNumber";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebCategory.ClickNumber" /></summary>
            public const string ClickNumber = "ClickNumber";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebCategory.Title" /></summary>
            public const string Title = "Title";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebCategory.Keywords" /></summary>
            public const string Keywords = "Keywords";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebCategory.Description" /></summary>
            public const string Description = "Description";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebCategory.Sequence" /></summary>
            public const string Sequence = "Sequence";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebCategory.IsEnable" /></summary>
            public const string IsEnable = "IsEnable";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebCategory.RowVers" /></summary>
            public const string RowVers = "RowVers";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebCategory.Remarks" /></summary>
            public const string Remarks = "Remarks";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebCategory.CreateBy" /></summary>
            public const string CreateBy = "CreateBy";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebCategory.CreateTime" /></summary>
            public const string CreateTime = "CreateTime";
        }
        #endregion
    }
}
