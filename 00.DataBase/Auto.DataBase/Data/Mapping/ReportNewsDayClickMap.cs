using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Auto.EFCore.Entities.ReportNewsDayClick" />
    /// </summary>
    public partial class ReportNewsDayClickMap
        : IEntityTypeConfiguration<Auto.EFCore.Entities.ReportNewsDayClick>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Auto.EFCore.Entities.ReportNewsDayClick" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Auto.EFCore.Entities.ReportNewsDayClick> builder)
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

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="Auto.EFCore.Entities.ReportNewsDayClick" /></summary>
            public const string Schema = "dbo";
            /// <summary>Table Name constant for entity <see cref="Auto.EFCore.Entities.ReportNewsDayClick" /></summary>
            public const string Name = "Report_News_DayClick";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.ReportNewsDayClick.NewsClickId" /></summary>
            public const string NewsClickId = "NewsClickId";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.ReportNewsDayClick.NewsId" /></summary>
            public const string NewsId = "NewsId";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.ReportNewsDayClick.CategoryId" /></summary>
            public const string CategoryId = "CategoryId";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.ReportNewsDayClick.CategoryName" /></summary>
            public const string CategoryName = "CategoryName";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.ReportNewsDayClick.SpecialCode" /></summary>
            public const string SpecialCode = "SpecialCode";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.ReportNewsDayClick.SpecialName" /></summary>
            public const string SpecialName = "SpecialName";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.ReportNewsDayClick.Count" /></summary>
            public const string Count = "Count";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.ReportNewsDayClick.Today" /></summary>
            public const string Today = "Today";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.ReportNewsDayClick.LastUpdateTime" /></summary>
            public const string LastUpdateTime = "LastUpdateTime";
        }
        #endregion
    }
}
