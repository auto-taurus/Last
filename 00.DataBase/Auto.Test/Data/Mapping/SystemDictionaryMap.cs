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

            builder.Property(t => t.Keys)
                .HasColumnName("Keys")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Name)
                .HasColumnName("Name")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Value)
                .HasColumnName("Value")
                .HasColumnType("nvarchar(1000)")
                .HasMaxLength(1000);

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            // relationships
            #endregion
        }

    }
}
