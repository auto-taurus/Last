using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Auto.EFCore.Entities.AutoBatchInsertNewsId" />
    /// </summary>
    public partial class AutoBatchInsertNewsIdMap
        : IEntityTypeConfiguration<Auto.EFCore.Entities.AutoBatchInsertNewsId>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Auto.EFCore.Entities.AutoBatchInsertNewsId" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Auto.EFCore.Entities.AutoBatchInsertNewsId> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Auto_BatchInsert_NewsId", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.NewsId)
                .HasColumnName("NewsId")
                .HasColumnType("int");

            builder.Property(t => t.Message)
                .HasColumnName("Message")
                .HasColumnType("nvarchar(max)");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="Auto.EFCore.Entities.AutoBatchInsertNewsId" /></summary>
            public const string Schema = "dbo";
            /// <summary>Table Name constant for entity <see cref="Auto.EFCore.Entities.AutoBatchInsertNewsId" /></summary>
            public const string Name = "Auto_BatchInsert_NewsId";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.AutoBatchInsertNewsId.Id" /></summary>
            public const string Id = "Id";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.AutoBatchInsertNewsId.NewsId" /></summary>
            public const string NewsId = "NewsId";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.AutoBatchInsertNewsId.Message" /></summary>
            public const string Message = "Message";
        }
        #endregion
    }
}
