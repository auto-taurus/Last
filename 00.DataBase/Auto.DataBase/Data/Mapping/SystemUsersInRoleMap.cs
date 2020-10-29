using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Mapping
{
    public partial class SystemUsersInRoleMap
        : IEntityTypeConfiguration<Master.Data.Entities.SystemUsersInRole>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Master.Data.Entities.SystemUsersInRole> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("System_UsersInRole", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

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
