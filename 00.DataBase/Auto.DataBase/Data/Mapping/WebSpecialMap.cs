using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Auto.EFCore.Entities.WebSpecial" />
    /// </summary>
    public partial class WebSpecialMap
        : IEntityTypeConfiguration<Auto.EFCore.Entities.WebSpecial>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Auto.EFCore.Entities.WebSpecial" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Auto.EFCore.Entities.WebSpecial> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Web_Special", "dbo");

            // key
            builder.HasKey(t => new { t.SpecialId, t.SpecialCode });

            // properties
            builder.Property(t => t.SpecialId)
                .IsRequired()
                .HasColumnName("SpecialId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.SiteNo)
                .HasColumnName("SiteNo")
                .HasColumnType("int");

            builder.Property(t => t.SpecialCode)
                .IsRequired()
                .HasColumnName("SpecialCode")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.Name)
                .HasColumnName("Name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.DisplayType)
                .HasColumnName("DisplayType")
                .HasColumnType("int");

            builder.Property(t => t.IsEnable)
                .HasColumnName("IsEnable")
                .HasColumnType("int");

            builder.Property(t => t.Timestamp)
                .IsRowVersion()
                .HasColumnName("Timestamp")
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
            /// <summary>Table Schema name constant for entity <see cref="Auto.EFCore.Entities.WebSpecial" /></summary>
            public const string Schema = "dbo";
            /// <summary>Table Name constant for entity <see cref="Auto.EFCore.Entities.WebSpecial" /></summary>
            public const string Name = "Web_Special";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebSpecial.SpecialId" /></summary>
            public const string SpecialId = "SpecialId";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebSpecial.SiteNo" /></summary>
            public const string SiteNo = "SiteNo";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebSpecial.SpecialCode" /></summary>
            public const string SpecialCode = "SpecialCode";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebSpecial.Name" /></summary>
            public const string Name = "Name";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebSpecial.DisplayType" /></summary>
            public const string DisplayType = "DisplayType";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebSpecial.IsEnable" /></summary>
            public const string IsEnable = "IsEnable";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebSpecial.Timestamp" /></summary>
            public const string Timestamp = "Timestamp";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebSpecial.Remarks" /></summary>
            public const string Remarks = "Remarks";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebSpecial.CreateBy" /></summary>
            public const string CreateBy = "CreateBy";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebSpecial.CreateTime" /></summary>
            public const string CreateTime = "CreateTime";
        }
        #endregion
    }
}
