using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Mapping
{
    public partial class WebCategoryMap
        : IEntityTypeConfiguration<Master.Data.Entities.WebCategory>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Master.Data.Entities.WebCategory> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Web_Category", "dbo");

            // key
            builder.HasKey(t => t.CategoryId);

            // properties
            builder.Property(t => t.CategoryId)
                .IsRequired()
                .HasColumnName("CategoryId")
                .HasColumnType("int");

            builder.Property(t => t.SiteId)
                .HasColumnName("SiteId")
                .HasColumnType("int");

            builder.Property(t => t.CategoryName)
                .HasColumnName("CategoryName")
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.ParentId)
                .HasColumnName("ParentId")
                .HasColumnType("int");

            builder.Property(t => t.NodeValue)
                .HasColumnName("NodeValue")
                .HasColumnType("varchar(1000)")
                .HasMaxLength(1000);

            builder.Property(t => t.Controller)
                .HasColumnName("Controller")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Action)
                .HasColumnName("Action")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Urls)
                .HasColumnName("Urls")
                .HasColumnType("varchar(500)")
                .HasMaxLength(500);

            builder.Property(t => t.DocumentNumber)
                .HasColumnName("DocumentNumber")
                .HasColumnType("int");

            builder.Property(t => t.AccessNumber)
                .HasColumnName("AccessNumber")
                .HasColumnType("int");

            builder.Property(t => t.ClickNumber)
                .HasColumnName("ClickNumber")
                .HasColumnType("int");

            builder.Property(t => t.Title)
                .HasColumnName("Title")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Keywords)
                .HasColumnName("Keywords")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Description)
                .HasColumnName("Description")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Sequence)
                .HasColumnName("Sequence")
                .HasColumnType("int")
                .HasDefaultValueSql("((255))");

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
