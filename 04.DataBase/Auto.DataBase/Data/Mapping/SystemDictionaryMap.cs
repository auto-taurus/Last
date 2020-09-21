using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Auto.EFCore.Entities.SystemDictionary" />
    /// </summary>
    public partial class SystemDictionaryMap
        : IEntityTypeConfiguration<Auto.EFCore.Entities.SystemDictionary>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Auto.EFCore.Entities.SystemDictionary" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Auto.EFCore.Entities.SystemDictionary> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("System_Dictionary", "dbo");

            // key
            builder.HasKey(t => t.DictionaryId);

            // properties
            builder.Property(t => t.DictionaryId)
                .IsRequired()
                .HasColumnName("DictionaryId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Keys)
                .HasColumnName("Keys")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Name)
                .HasColumnName("Name")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Value)
                .HasColumnName("Value")
                .HasColumnType("nvarchar(1000)")
                .HasMaxLength(1000);

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="Auto.EFCore.Entities.SystemDictionary" /></summary>
            public const string Schema = "dbo";
            /// <summary>Table Name constant for entity <see cref="Auto.EFCore.Entities.SystemDictionary" /></summary>
            public const string Name = "System_Dictionary";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemDictionary.DictionaryId" /></summary>
            public const string DictionaryId = "DictionaryId";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemDictionary.Keys" /></summary>
            public const string Keys = "Keys";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemDictionary.Name" /></summary>
            public const string Name = "Name";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemDictionary.Value" /></summary>
            public const string Value = "Value";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemDictionary.Remarks" /></summary>
            public const string Remarks = "Remarks";
        }
        #endregion
    }
}
