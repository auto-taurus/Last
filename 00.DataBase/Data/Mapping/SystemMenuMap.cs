using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Mapping
{
    public partial class SystemMenuMap
        : IEntityTypeConfiguration<AutoNews.Data.Entities.SystemMenu>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AutoNews.Data.Entities.SystemMenu> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("System_Menu", "dbo");

            // key
            builder.HasKey(t => t.MenuId);

            // properties
            builder.Property(t => t.MenuId)
                .IsRequired()
                .HasColumnName("MenuId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.SiteId)
                .HasColumnName("SiteId")
                .HasColumnType("int");

            builder.Property(t => t.MenuIcon)
                .HasColumnName("MenuIcon")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.MenuName)
                .HasColumnName("MenuName")
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.ParentId)
                .HasColumnName("ParentId")
                .HasColumnType("int");

            builder.Property(t => t.NodeValue)
                .HasColumnName("NodeValue")
                .HasColumnType("varchar(1000)")
                .HasMaxLength(1000);

            builder.Property(t => t.Areas)
                .HasColumnName("Areas")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Controller)
                .HasColumnName("Controller")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Action)
                .HasColumnName("Action")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Urls)
                .HasColumnName("Urls")
                .HasColumnType("nvarchar(500)")
                .HasMaxLength(500);

            builder.Property(t => t.RouterName)
                .HasColumnName("RouterName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.RouterPath)
                .HasColumnName("RouterPath")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Component)
                .HasColumnName("Component")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.ShowAlways)
                .HasColumnName("ShowAlways")
                .HasColumnType("int");

            builder.Property(t => t.ShowHeader)
                .HasColumnName("ShowHeader")
                .HasColumnType("int");

            builder.Property(t => t.HideInBread)
                .HasColumnName("HideInBread")
                .HasColumnType("int");

            builder.Property(t => t.HideInMenu)
                .HasColumnName("HideInMenu")
                .HasColumnType("int");

            builder.Property(t => t.NotCache)
                .HasColumnName("NotCache")
                .HasColumnType("int");

            builder.Property(t => t.BeforeCloseName)
                .HasColumnName("BeforeCloseName")
                .HasColumnType("int");

            builder.Property(t => t.Sequence)
                .HasColumnName("Sequence")
                .HasColumnType("int");

            builder.Property(t => t.IsEnable)
                .HasColumnName("IsEnable")
                .HasColumnType("int");

            builder.Property(t => t.RowVers)
                .IsRowVersion()
                .HasColumnName("RowVers")
                .HasColumnType("rowversion")
                .HasMaxLength(8)
                .ValueGeneratedOnAddOrUpdate();

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.CreateBy)
                .HasColumnName("CreateBy")
                .HasColumnType("int");

            builder.Property(t => t.CreateTime)
                .HasColumnName("CreateTime")
                .HasColumnType("datetime");

            // relationships
            #endregion
        }

    }
}
