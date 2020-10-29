using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Mapping
{
    public partial class WebSpecialMap
        : IEntityTypeConfiguration<Master.Data.Entities.WebSpecial>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Master.Data.Entities.WebSpecial> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Web_Special", "dbo");

            // key
            builder.HasKey(t => t.SpecialId);

            // properties
            builder.Property(t => t.SpecialId)
                .IsRequired()
                .HasColumnName("SpecialId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.SiteId)
                .HasColumnName("SiteId")
                .HasColumnType("int");

            builder.Property(t => t.SpecialCode)
                .HasColumnName("SpecialCode")
                .HasColumnType("varchar(10)")
                .HasMaxLength(10);

            builder.Property(t => t.Name)
                .HasColumnName("Name")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.DisplayType)
                .HasColumnName("DisplayType")
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
