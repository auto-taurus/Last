using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Mapping
{
    public partial class SystemUsersInMenuMap
        : IEntityTypeConfiguration<Master.Data.Entities.SystemUsersInMenu>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Master.Data.Entities.SystemUsersInMenu> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("System_UsersInMenu", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

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

    }
}
