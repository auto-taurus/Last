using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Auto.EFCore.Entities.WebNewsSensitive" />
    /// </summary>
    public partial class WebNewsSensitiveMap
        : IEntityTypeConfiguration<Auto.EFCore.Entities.WebNewsSensitive>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Auto.EFCore.Entities.WebNewsSensitive" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Auto.EFCore.Entities.WebNewsSensitive> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Web_NewsSensitive", "dbo");

            // key
            builder.HasKey(t => t.NewsSensitiveId);

            // properties
            builder.Property(t => t.NewsSensitiveId)
                .IsRequired()
                .HasColumnName("NewsSensitiveId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.SiteMark)
                .HasColumnName("SiteMark")
                .HasColumnType("int");

            builder.Property(t => t.NewId)
                .HasColumnName("NewId")
                .HasColumnType("int");

            builder.Property(t => t.NewTitleRecords)
                .HasColumnName("NewTitleRecords")
                .HasColumnType("nvarchar(1000)")
                .HasMaxLength(1000);

            builder.Property(t => t.CustomTitleRecords)
                .HasColumnName("CustomTitleRecords")
                .HasColumnType("nvarchar(1000)")
                .HasMaxLength(1000);

            builder.Property(t => t.ContentsRecords)
                .HasColumnName("ContentsRecords")
                .HasColumnType("nvarchar(1000)")
                .HasMaxLength(1000);

            builder.Property(t => t.IsEnable)
                .HasColumnName("IsEnable")
                .HasColumnType("int");

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("nvarchar(1000)")
                .HasMaxLength(1000);

            builder.Property(t => t.CreateBy)
                .HasColumnName("CreateBy")
                .HasColumnType("int");

            builder.Property(t => t.CreateTime)
                .HasColumnName("CreateTime")
                .HasColumnType("smalldatetime");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="Auto.EFCore.Entities.WebNewsSensitive" /></summary>
            public const string Schema = "dbo";
            /// <summary>Table Name constant for entity <see cref="Auto.EFCore.Entities.WebNewsSensitive" /></summary>
            public const string Name = "Web_NewsSensitive";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNewsSensitive.NewsSensitiveId" /></summary>
            public const string NewsSensitiveId = "NewsSensitiveId";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNewsSensitive.SiteMark" /></summary>
            public const string SiteMark = "SiteMark";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNewsSensitive.NewId" /></summary>
            public const string NewId = "NewId";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNewsSensitive.NewTitleRecords" /></summary>
            public const string NewTitleRecords = "NewTitleRecords";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNewsSensitive.CustomTitleRecords" /></summary>
            public const string CustomTitleRecords = "CustomTitleRecords";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNewsSensitive.ContentsRecords" /></summary>
            public const string ContentsRecords = "ContentsRecords";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNewsSensitive.IsEnable" /></summary>
            public const string IsEnable = "IsEnable";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNewsSensitive.Remarks" /></summary>
            public const string Remarks = "Remarks";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNewsSensitive.CreateBy" /></summary>
            public const string CreateBy = "CreateBy";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNewsSensitive.CreateTime" /></summary>
            public const string CreateTime = "CreateTime";
        }
        #endregion
    }
}
