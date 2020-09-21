using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Auto.EFCore.Entities.SystemUsersRefreshToken" />
    /// </summary>
    public partial class SystemUsersRefreshTokenMap
        : IEntityTypeConfiguration<Auto.EFCore.Entities.SystemUsersRefreshToken>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Auto.EFCore.Entities.SystemUsersRefreshToken" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Auto.EFCore.Entities.SystemUsersRefreshToken> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("System_UsersRefreshToken", "dbo");

            // key
            builder.HasKey(t => t.RefreshTokenId);

            // properties
            builder.Property(t => t.RefreshTokenId)
                .IsRequired()
                .HasColumnName("RefreshTokenId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.UsersId)
                .HasColumnName("UsersId")
                .HasColumnType("int");

            builder.Property(t => t.AccessToken)
                .HasColumnName("AccessToken")
                .HasColumnType("varchar(1000)")
                .HasMaxLength(1000);

            builder.Property(t => t.Expires)
                .HasColumnName("Expires")
                .HasColumnType("datetime");

            builder.Property(t => t.Active)
                .HasColumnName("Active")
                .HasColumnType("int");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="Auto.EFCore.Entities.SystemUsersRefreshToken" /></summary>
            public const string Schema = "dbo";
            /// <summary>Table Name constant for entity <see cref="Auto.EFCore.Entities.SystemUsersRefreshToken" /></summary>
            public const string Name = "System_UsersRefreshToken";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemUsersRefreshToken.RefreshTokenId" /></summary>
            public const string RefreshTokenId = "RefreshTokenId";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemUsersRefreshToken.UsersId" /></summary>
            public const string UsersId = "UsersId";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemUsersRefreshToken.AccessToken" /></summary>
            public const string AccessToken = "AccessToken";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemUsersRefreshToken.Expires" /></summary>
            public const string Expires = "Expires";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemUsersRefreshToken.Active" /></summary>
            public const string Active = "Active";
        }
        #endregion
    }
}
