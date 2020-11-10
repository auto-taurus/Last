using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Mapping
{
    public partial class SystemDictionaryMap
        : IEntityTypeConfiguration<AutoNews.Data.Entities.SystemDictionary>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AutoNews.Data.Entities.SystemDictionary> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("System_Dictionary", "dbo");

            // key
            builder.HasKey(t => t.DictionaryId);

            // properties
            builder.Property(t => t.DictionaryId)
                .IsRequired()
                .HasColumnName("DictionaryId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.TypeKey)
                .HasColumnName("TypeKey")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.DistKey)
                .HasColumnName("DistKey")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.DistName)
                .HasColumnName("DistName")
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.DistValue)
                .HasColumnName("DistValue")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Sequence)
                .HasColumnName("Sequence")
                .HasColumnType("int");

            builder.Property(t => t.IsEnable)
                .HasColumnName("IsEnable")
                .HasColumnType("int");

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            // relationships
            #endregion
        }

    }
}
