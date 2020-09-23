using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Auto.EFCore.Entities.SystemUsersDictionary" />
    /// </summary>
    public partial class SystemUsersDictionaryMap
        : IEntityTypeConfiguration<Auto.EFCore.Entities.SystemUsersDictionary>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Auto.EFCore.Entities.SystemUsersDictionary" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Auto.EFCore.Entities.SystemUsersDictionary> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("System_UsersDictionary", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("UserId")
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
            builder.HasOne(t => t.UserSystemUsers)
                .WithMany(t => t.UserSystemUsersDictionaries)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_SYSTEM_U_REFERENCE_SYSTEM_UC");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="Auto.EFCore.Entities.SystemUsersDictionary" /></summary>
            public const string Schema = "dbo";
            /// <summary>Table Name constant for entity <see cref="Auto.EFCore.Entities.SystemUsersDictionary" /></summary>
            public const string Name = "System_UsersDictionary";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemUsersDictionary.Id" /></summary>
            public const string Id = "Id";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemUsersDictionary.UserId" /></summary>
            public const string UserId = "UserId";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemUsersDictionary.DictionaryKey" /></summary>
            public const string DictionaryKey = "DictionaryKey";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemUsersDictionary.DictionaryValue" /></summary>
            public const string DictionaryValue = "DictionaryValue";
        }
        #endregion
    }
}
