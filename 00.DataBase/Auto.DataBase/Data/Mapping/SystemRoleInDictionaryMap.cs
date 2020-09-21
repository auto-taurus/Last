using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Auto.EFCore.Entities.SystemRoleInDictionary" />
    /// </summary>
    public partial class SystemRoleInDictionaryMap
        : IEntityTypeConfiguration<Auto.EFCore.Entities.SystemRoleInDictionary>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Auto.EFCore.Entities.SystemRoleInDictionary" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Auto.EFCore.Entities.SystemRoleInDictionary> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("System_RoleInDictionary", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.RoleId)
                .IsRequired()
                .HasColumnName("RoleId")
                .HasColumnType("int");

            builder.Property(t => t.DictionaryKey)
                .HasColumnName("DictionaryKey")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.DictionaryValue)
                .HasColumnName("DictionaryValue")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            // relationships
            builder.HasOne(t => t.SystemRole)
                .WithMany(t => t.SystemRoleInDictionaries)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_SYSTEM_R_REFERENCE_SYSTEM_RC");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="Auto.EFCore.Entities.SystemRoleInDictionary" /></summary>
            public const string Schema = "dbo";
            /// <summary>Table Name constant for entity <see cref="Auto.EFCore.Entities.SystemRoleInDictionary" /></summary>
            public const string Name = "System_RoleInDictionary";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemRoleInDictionary.Id" /></summary>
            public const string Id = "Id";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemRoleInDictionary.RoleId" /></summary>
            public const string RoleId = "RoleId";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemRoleInDictionary.DictionaryKey" /></summary>
            public const string DictionaryKey = "DictionaryKey";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemRoleInDictionary.DictionaryValue" /></summary>
            public const string DictionaryValue = "DictionaryValue";
        }
        #endregion
    }
}
