using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Auto.EFCore.Entities.WebSensitive" />
    /// </summary>
    public partial class WebSensitiveMap
        : IEntityTypeConfiguration<Auto.EFCore.Entities.WebSensitive>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Auto.EFCore.Entities.WebSensitive" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Auto.EFCore.Entities.WebSensitive> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Web_Sensitive", "dbo");

            // key
            builder.HasKey(t => t.SensitiveId);

            // properties
            builder.Property(t => t.SensitiveId)
                .IsRequired()
                .HasColumnName("SensitiveId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.SiteNo)
                .HasColumnName("SiteNo")
                .HasColumnType("int");

            builder.Property(t => t.Type)
                .HasColumnName("Type")
                .HasColumnType("int");

            builder.Property(t => t.TypeText)
                .HasColumnName("TypeText")
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.SensitiveWords)
                .HasColumnName("SensitiveWords")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Author)
                .HasColumnName("Author")
                .HasColumnType("nvarchar(1000)")
                .HasMaxLength(1000);

            builder.Property(t => t.Urls)
                .HasColumnName("Urls")
                .HasColumnType("nvarchar(4000)")
                .HasMaxLength(4000);

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
            /// <summary>Table Schema name constant for entity <see cref="Auto.EFCore.Entities.WebSensitive" /></summary>
            public const string Schema = "dbo";
            /// <summary>Table Name constant for entity <see cref="Auto.EFCore.Entities.WebSensitive" /></summary>
            public const string Name = "Web_Sensitive";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebSensitive.SensitiveId" /></summary>
            public const string SensitiveId = "SensitiveId";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebSensitive.SiteNo" /></summary>
            public const string SiteNo = "SiteNo";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebSensitive.Type" /></summary>
            public const string Type = "Type";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebSensitive.TypeText" /></summary>
            public const string TypeText = "TypeText";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebSensitive.SensitiveWords" /></summary>
            public const string SensitiveWords = "SensitiveWords";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebSensitive.Author" /></summary>
            public const string Author = "Author";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebSensitive.Urls" /></summary>
            public const string Urls = "Urls";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebSensitive.RowVers" /></summary>
            public const string RowVers = "RowVers";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebSensitive.IsEnable" /></summary>
            public const string IsEnable = "IsEnable";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebSensitive.Remarks" /></summary>
            public const string Remarks = "Remarks";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebSensitive.CreateBy" /></summary>
            public const string CreateBy = "CreateBy";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebSensitive.CreateTime" /></summary>
            public const string CreateTime = "CreateTime";
        }
        #endregion
    }
}
