using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Mapping
{
    public partial class AppInfoMap
        : IEntityTypeConfiguration<AutoNews.Data.Entities.AppInfo>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AutoNews.Data.Entities.AppInfo> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("App_Info", "dbo");

            // key
            builder.HasKey(t => t.AppId);

            // properties
            builder.Property(t => t.AppId)
                .IsRequired()
                .HasColumnName("AppId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Code)
                .HasColumnName("Code")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.LogoUrl)
                .HasColumnName("LogoUrl")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.PackageName)
                .HasColumnName("PackageName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.AppName)
                .HasColumnName("AppName")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Version)
                .IsRequired()
                .HasColumnName("Version")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.VersionSize)
                .HasColumnName("VersionSize")
                .HasColumnType("decimal(18,2)");

            builder.Property(t => t.VersionCode)
                .HasColumnName("VersionCode")
                .HasColumnType("int");

            builder.Property(t => t.AppUrl)
                .IsRequired()
                .HasColumnName("AppUrl")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Introduction)
                .HasColumnName("Introduction")
                .HasColumnType("nvarchar(500)")
                .HasMaxLength(500);

            builder.Property(t => t.UpdateLog)
                .HasColumnName("UpdateLog")
                .HasColumnType("nvarchar(500)")
                .HasMaxLength(500);

            builder.Property(t => t.Status)
                .HasColumnName("Status")
                .HasColumnType("int");

            builder.Property(t => t.IsMandatory)
                .HasColumnName("IsMandatory")
                .HasColumnType("int");

            builder.Property(t => t.IsEnable)
                .HasColumnName("IsEnable")
                .HasColumnType("int");

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.CreateTime)
                .HasColumnName("CreateTime")
                .HasColumnType("datetime");

            // relationships
            #endregion
        }

    }
}
