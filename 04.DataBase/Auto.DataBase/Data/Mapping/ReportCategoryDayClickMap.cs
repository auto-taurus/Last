using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Auto.EFCore.Entities.ReportCategoryDayClick" />
    /// </summary>
    public partial class ReportCategoryDayClickMap
        : IEntityTypeConfiguration<Auto.EFCore.Entities.ReportCategoryDayClick>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Auto.EFCore.Entities.ReportCategoryDayClick" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Auto.EFCore.Entities.ReportCategoryDayClick> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Report_Category_DayClick", "dbo");

            // key
            builder.HasKey(t => t.CategoryClickId);

            // properties
            builder.Property(t => t.CategoryClickId)
                .IsRequired()
                .HasColumnName("CategoryClickId")
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

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="Auto.EFCore.Entities.ReportCategoryDayClick" /></summary>
            public const string Schema = "dbo";
            /// <summary>Table Name constant for entity <see cref="Auto.EFCore.Entities.ReportCategoryDayClick" /></summary>
            public const string Name = "Report_Category_DayClick";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.ReportCategoryDayClick.CategoryClickId" /></summary>
            public const string CategoryClickId = "CategoryClickId";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.ReportCategoryDayClick.CategoryId" /></summary>
            public const string CategoryId = "CategoryId";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.ReportCategoryDayClick.CategoryName" /></summary>
            public const string CategoryName = "CategoryName";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.ReportCategoryDayClick.Count" /></summary>
            public const string Count = "Count";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.ReportCategoryDayClick.Today" /></summary>
            public const string Today = "Today";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.ReportCategoryDayClick.LastUpdateTime" /></summary>
            public const string LastUpdateTime = "LastUpdateTime";
        }
        #endregion
    }
}
