using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Auto.EFCore.Entities.SystemRoleInMenu" />
    /// </summary>
    public partial class SystemRoleInMenuMap
        : IEntityTypeConfiguration<Auto.EFCore.Entities.SystemRoleInMenu>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Auto.EFCore.Entities.SystemRoleInMenu" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Auto.EFCore.Entities.SystemRoleInMenu> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("System_RoleInMenu", "dbo");

            // key
            builder.HasNoKey();

            // properties
            builder.Property(t => t.RoleId)
                .HasColumnName("RoleId")
                .HasColumnType("int");

            builder.Property(t => t.MenuId)
                .HasColumnName("MenuId")
                .HasColumnType("int");

            // relationships
            builder.HasOne(t => t.SystemMenu)
                .WithMany(t => t.SystemRoleInMenus)
                .HasForeignKey(d => d.MenuId)
                .HasConstraintName("FK_SYSTEM_R_REFERENCE_SYSTEM_M");

            builder.HasOne(t => t.SystemRole)
                .WithMany(t => t.SystemRoleInMenus)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_SYSTEM_R_REFERENCE_SYSTEM_R");

            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="Auto.EFCore.Entities.SystemRoleInMenu" /></summary>
            public const string Schema = "dbo";
            /// <summary>Table Name constant for entity <see cref="Auto.EFCore.Entities.SystemRoleInMenu" /></summary>
            public const string Name = "System_RoleInMenu";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemRoleInMenu.RoleId" /></summary>
            public const string RoleId = "RoleId";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemRoleInMenu.MenuId" /></summary>
            public const string MenuId = "MenuId";
        }
        #endregion
    }
}
