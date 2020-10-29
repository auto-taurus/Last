using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Mapping
{
    public partial class MemberFootprintMap
        : IEntityTypeConfiguration<Master.Data.Entities.MemberFootprint>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Master.Data.Entities.MemberFootprint> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Member_Footprint", "dbo");

            // key
            builder.HasKey(t => t.FootprintId);

            // properties
            builder.Property(t => t.FootprintId)
                .IsRequired()
                .HasColumnName("FootprintId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.MemberId)
                .HasColumnName("MemberId")
                .HasColumnType("int");

            builder.Property(t => t.SourceId)
                .HasColumnName("SourceId")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.SourceTable)
                .HasColumnName("SourceTable")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.BrowseTime)
                .HasColumnName("BrowseTime")
                .HasColumnType("datetime");

            builder.Property(t => t.IsEnable)
                .HasColumnName("IsEnable")
                .HasColumnType("int");

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            // relationships
            builder.HasOne(t => t.MemberInfos)
                .WithMany(t => t.MemberFootprints)
                .HasForeignKey(d => d.MemberId)
                .HasConstraintName("FK_MEMBER_F_REFERENCE_MEMBER_I4");

            #endregion
        }

    }
}
