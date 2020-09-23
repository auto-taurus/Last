using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Auto.EFCore.Entities.SystemMenu" />
    /// </summary>
    public partial class SystemMenuMap
        : IEntityTypeConfiguration<Auto.EFCore.Entities.SystemMenu>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Auto.EFCore.Entities.SystemMenu" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Auto.EFCore.Entities.SystemMenu> builder)
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
                .HasColumnType("int");

            builder.Property(t => t.SiteNo)
                .HasColumnName("SiteNo")
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

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="Auto.EFCore.Entities.SystemMenu" /></summary>
            public const string Schema = "dbo";
            /// <summary>Table Name constant for entity <see cref="Auto.EFCore.Entities.SystemMenu" /></summary>
            public const string Name = "System_Menu";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemMenu.MenuId" /></summary>
            public const string MenuId = "MenuId";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemMenu.SiteNo" /></summary>
            public const string SiteNo = "SiteNo";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemMenu.MenuIcon" /></summary>
            public const string MenuIcon = "MenuIcon";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemMenu.MenuName" /></summary>
            public const string MenuName = "MenuName";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemMenu.ParentId" /></summary>
            public const string ParentId = "ParentId";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemMenu.NodeValue" /></summary>
            public const string NodeValue = "NodeValue";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemMenu.Areas" /></summary>
            public const string Areas = "Areas";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemMenu.Controller" /></summary>
            public const string Controller = "Controller";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemMenu.Action" /></summary>
            public const string Action = "Action";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemMenu.Urls" /></summary>
            public const string Urls = "Urls";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemMenu.RouterName" /></summary>
            public const string RouterName = "RouterName";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemMenu.RouterPath" /></summary>
            public const string RouterPath = "RouterPath";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemMenu.Component" /></summary>
            public const string Component = "Component";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemMenu.ShowAlways" /></summary>
            public const string ShowAlways = "ShowAlways";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemMenu.ShowHeader" /></summary>
            public const string ShowHeader = "ShowHeader";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemMenu.HideInBread" /></summary>
            public const string HideInBread = "HideInBread";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemMenu.HideInMenu" /></summary>
            public const string HideInMenu = "HideInMenu";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemMenu.NotCache" /></summary>
            public const string NotCache = "NotCache";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemMenu.BeforeCloseName" /></summary>
            public const string BeforeCloseName = "BeforeCloseName";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemMenu.Sequence" /></summary>
            public const string Sequence = "Sequence";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemMenu.IsEnable" /></summary>
            public const string IsEnable = "IsEnable";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemMenu.RowVers" /></summary>
            public const string RowVers = "RowVers";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemMenu.Remarks" /></summary>
            public const string Remarks = "Remarks";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemMenu.CreateBy" /></summary>
            public const string CreateBy = "CreateBy";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemMenu.CreateTime" /></summary>
            public const string CreateTime = "CreateTime";
        }
        #endregion
    }
}
