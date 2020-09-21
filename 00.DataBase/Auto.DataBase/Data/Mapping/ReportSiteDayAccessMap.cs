using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Auto.EFCore.Entities.ReportSiteDayAccess" />
    /// </summary>
    public partial class ReportSiteDayAccessMap
        : IEntityTypeConfiguration<Auto.EFCore.Entities.ReportSiteDayAccess>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Auto.EFCore.Entities.ReportSiteDayAccess" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Auto.EFCore.Entities.ReportSiteDayAccess> builder)
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

            builder.Property(t => t.SiteNo)
                .HasColumnName("SiteNo")
                .HasColumnType("char(10)")
                .HasMaxLength(10);

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
            /// <summary>Table Schema name constant for entity <see cref="Auto.EFCore.Entities.ReportSiteDayAccess" /></summary>
            public const string Schema = "dbo";
            /// <summary>Table Name constant for entity <see cref="Auto.EFCore.Entities.ReportSiteDayAccess" /></summary>
            public const string Name = "Report_Site_DayAccess";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.ReportSiteDayAccess.SiteAccessId" /></summary>
            public const string SiteAccessId = "SiteAccessId";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.ReportSiteDayAccess.SiteNo" /></summary>
            public const string SiteNo = "SiteNo";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.ReportSiteDayAccess.Count" /></summary>
            public const string Count = "Count";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.ReportSiteDayAccess.Today" /></summary>
            public const string Today = "Today";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.ReportSiteDayAccess.LastUpdateTime" /></summary>
            public const string LastUpdateTime = "LastUpdateTime";
        }
        #endregion
    }
}
