using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Auto.EFCore.Entities.WebNewsOperateLogs" />
    /// </summary>
    public partial class WebNewsOperateLogsMap
        : IEntityTypeConfiguration<Auto.EFCore.Entities.WebNewsOperateLogs>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Auto.EFCore.Entities.WebNewsOperateLogs" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Auto.EFCore.Entities.WebNewsOperateLogs> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Web_NewsOperate_Logs", "dbo");

            // key
            builder.HasKey(t => t.NewsOperateId);

            // properties
            builder.Property(t => t.NewsOperateId)
                .IsRequired()
                .HasColumnName("NewsOperateId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.NewsId)
                .HasColumnName("NewsId")
                .HasColumnType("int");

            builder.Property(t => t.OperateType)
                .HasColumnName("OperateType")
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.OperateStatus)
                .HasColumnName("OperateStatus")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.CreateBy)
                .HasColumnName("CreateBy")
                .HasColumnType("int");

            builder.Property(t => t.CreateName)
                .HasColumnName("CreateName")
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.CreateTime)
                .HasColumnName("CreateTime")
                .HasColumnType("datetime");

            // relationships
            builder.HasOne(t => t.WebNews)
                .WithMany(t => t.WebNewsOperateLogs)
                .HasForeignKey(d => d.NewsId)
                .HasConstraintName("FK_WEB_NEWS_REFERENCE_WEB_NEWS");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="Auto.EFCore.Entities.WebNewsOperateLogs" /></summary>
            public const string Schema = "dbo";
            /// <summary>Table Name constant for entity <see cref="Auto.EFCore.Entities.WebNewsOperateLogs" /></summary>
            public const string Name = "Web_NewsOperate_Logs";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNewsOperateLogs.NewsOperateId" /></summary>
            public const string NewsOperateId = "NewsOperateId";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNewsOperateLogs.NewsId" /></summary>
            public const string NewsId = "NewsId";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNewsOperateLogs.OperateType" /></summary>
            public const string OperateType = "OperateType";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNewsOperateLogs.OperateStatus" /></summary>
            public const string OperateStatus = "OperateStatus";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNewsOperateLogs.Remarks" /></summary>
            public const string Remarks = "Remarks";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNewsOperateLogs.CreateBy" /></summary>
            public const string CreateBy = "CreateBy";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNewsOperateLogs.CreateName" /></summary>
            public const string CreateName = "CreateName";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebNewsOperateLogs.CreateTime" /></summary>
            public const string CreateTime = "CreateTime";
        }
        #endregion
    }
}
