using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Mapping
{
    public partial class MemberFavoritesMap
        : IEntityTypeConfiguration<AutoNews.Data.Entities.MemberFavorites>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AutoNews.Data.Entities.MemberFavorites> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Member_Favorites", "dbo");

            // key
            builder.HasKey(t => t.FavoritesId);

            // properties
            builder.Property(t => t.FavoritesId)
                .IsRequired()
                .HasColumnName("FavoritesId")
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

            builder.Property(t => t.FavoritesTime)
                .HasColumnName("FavoritesTime")
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
                .WithMany(t => t.MemberFavorites)
                .HasForeignKey(d => d.MemberId)
                .HasConstraintName("FK_MEMBER_F_REFERENCE_MEMBER_I3");

            #endregion
        }

    }
}
