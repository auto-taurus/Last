using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Auto.EFCore.Entities.SystemUsersInRole" />
    /// </summary>
    public partial class SystemUsersInRoleMap
        : IEntityTypeConfiguration<Auto.EFCore.Entities.SystemUsersInRole>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Auto.EFCore.Entities.SystemUsersInRole" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Auto.EFCore.Entities.SystemUsersInRole> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("System_UsersInRole", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.UsersId)
                .HasColumnName("UsersId")
                .HasColumnType("int");

            builder.Property(t => t.RoleId)
                .HasColumnName("RoleId")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.SystemRole)
                .WithMany(t => t.SystemUsersInRoles)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_SYSTEM_U_REFERENCE_SYSTEM_RU");

            builder.HasOne(t => t.SystemUsers)
                .WithMany(t => t.SystemUsersInRoles)
                .HasForeignKey(d => d.UsersId)
                .HasConstraintName("FK_SYSTEM_U_REFERENCE_SYSTEM_UU");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="Auto.EFCore.Entities.SystemUsersInRole" /></summary>
            public const string Schema = "dbo";
            /// <summary>Table Name constant for entity <see cref="Auto.EFCore.Entities.SystemUsersInRole" /></summary>
            public const string Name = "System_UsersInRole";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemUsersInRole.UsersId" /></summary>
            public const string UsersId = "UsersId";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemUsersInRole.RoleId" /></summary>
            public const string RoleId = "RoleId";
        }
        #endregion
    }
}
