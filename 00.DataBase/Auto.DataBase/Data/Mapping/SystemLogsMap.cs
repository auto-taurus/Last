using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Auto.EFCore.Entities.SystemLogs" />
    /// </summary>
    public partial class SystemLogsMap
        : IEntityTypeConfiguration<Auto.EFCore.Entities.SystemLogs>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Auto.EFCore.Entities.SystemLogs" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Auto.EFCore.Entities.SystemLogs> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("System_Logs", "dbo");

            // key
            builder.HasKey(t => t.LogsId);

            // properties
            builder.Property(t => t.LogsId)
                .IsRequired()
                .HasColumnName("LogsId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Methods)
                .HasColumnName("Methods")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Grade)
                .HasColumnName("Grade")
                .HasColumnType("int");

            builder.Property(t => t.Source)
                .HasColumnName("Source")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Args)
                .HasColumnName("Args")
                .HasColumnType("nvarchar(2000)")
                .HasMaxLength(2000);

            builder.Property(t => t.Errors)
                .HasColumnName("Errors")
                .HasColumnType("nvarchar(2000)")
                .HasMaxLength(2000);

            builder.Property(t => t.CreateBy)
                .HasColumnName("CreateBy")
                .HasColumnType("int");

            builder.Property(t => t.CreateTime)
                .IsRequired()
                .HasColumnName("CreateTime")
                .HasColumnType("datetime");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="Auto.EFCore.Entities.SystemLogs" /></summary>
            public const string Schema = "dbo";
            /// <summary>Table Name constant for entity <see cref="Auto.EFCore.Entities.SystemLogs" /></summary>
            public const string Name = "System_Logs";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemLogs.LogsId" /></summary>
            public const string LogsId = "LogsId";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemLogs.Methods" /></summary>
            public const string Methods = "Methods";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemLogs.Grade" /></summary>
            public const string Grade = "Grade";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemLogs.Source" /></summary>
            public const string Source = "Source";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemLogs.Args" /></summary>
            public const string Args = "Args";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemLogs.Errors" /></summary>
            public const string Errors = "Errors";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemLogs.CreateBy" /></summary>
            public const string CreateBy = "CreateBy";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemLogs.CreateTime" /></summary>
            public const string CreateTime = "CreateTime";
        }
        #endregion
    }
}
