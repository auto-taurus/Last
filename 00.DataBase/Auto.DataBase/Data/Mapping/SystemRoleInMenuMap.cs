using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Mapping
{
    public partial class SystemRoleInMenuMap
        : IEntityTypeConfiguration<Master.Data.Entities.SystemRoleInMenu>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Master.Data.Entities.SystemRoleInMenu> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("System_RoleInMenu", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

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

    }
}
