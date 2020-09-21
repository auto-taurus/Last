using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Auto.EFCore.Entities.SystemUsersInMenu" />
    /// </summary>
    public partial class SystemUsersInMenuMap
        : IEntityTypeConfiguration<Auto.EFCore.Entities.SystemUsersInMenu>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Auto.EFCore.Entities.SystemUsersInMenu" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Auto.EFCore.Entities.SystemUsersInMenu> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("System_UsersInMenu", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.UserId)
                .HasColumnName("UserId")
                .HasColumnType("int");

            builder.Property(t => t.MenuId)
                .HasColumnName("MenuId")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.SystemMenu)
                .WithMany(t => t.SystemUsersInMenus)
                .HasForeignKey(d => d.MenuId)
                .HasConstraintName("FK_SYSTEM_U_REFERENCE_SYSTEM_M");

            builder.HasOne(t => t.UserSystemUsers)
                .WithMany(t => t.UserSystemUsersInMenus)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_SYSTEM_U_REFERENCE_SYSTEM_UM");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="Auto.EFCore.Entities.SystemUsersInMenu" /></summary>
            public const string Schema = "dbo";
            /// <summary>Table Name constant for entity <see cref="Auto.EFCore.Entities.SystemUsersInMenu" /></summary>
            public const string Name = "System_UsersInMenu";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemUsersInMenu.UserId" /></summary>
            public const string UserId = "UserId";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemUsersInMenu.MenuId" /></summary>
            public const string MenuId = "MenuId";
        }
        #endregion
    }
}
