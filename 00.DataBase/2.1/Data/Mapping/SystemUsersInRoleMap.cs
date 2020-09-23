using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Mapping
{
    public partial class SystemUsersInRoleMap
        : IEntityTypeConfiguration<AutoNews.Data.Entities.SystemUsersInRole>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AutoNews.Data.Entities.SystemUsersInRole> builder)
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

    }
}
