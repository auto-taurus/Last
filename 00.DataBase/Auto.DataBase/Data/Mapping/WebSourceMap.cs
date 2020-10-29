using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Mapping
{
    public partial class WebSourceMap
        : IEntityTypeConfiguration<Master.Data.Entities.WebSource>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Master.Data.Entities.WebSource> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Web_Source", "dbo");

            // key
            builder.HasKey(t => t.SourceId);

            // properties
            builder.Property(t => t.SourceId)
                .IsRequired()
                .HasColumnName("SourceId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.CategoryId)
                .HasColumnName("CategoryId")
                .HasColumnType("int");

            builder.Property(t => t.SourceName)
                .HasColumnName("SourceName")
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.SourceLogo)
                .HasColumnName("SourceLogo")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.FollowNumber)
                .HasColumnName("FollowNumber")
                .HasColumnType("int");

            builder.Property(t => t.Sequence)
                .HasColumnName("Sequence")
                .HasColumnType("int");

            builder.Property(t => t.IsEnable)
                .HasColumnName("IsEnable")
                .HasColumnType("int");

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("datetime");

            // relationships
            builder.HasOne(t => t.WebCategory)
                .WithMany(t => t.WebSources)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK_WEB_SOUR_REFERENCE_WEB_CATE");

            #endregion
        }

    }
}
