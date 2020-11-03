using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Mapping
{
    public partial class SystemRoleDictionaryMap
        : IEntityTypeConfiguration<AutoNews.Data.Entities.SystemRoleDictionary>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AutoNews.Data.Entities.SystemRoleDictionary> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("System_RoleDictionary", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.RoleId)
                .IsRequired()
                .HasColumnName("RoleId")
                .HasColumnType("int");

            builder.Property(t => t.DictionaryKey)
                .HasColumnName("DictionaryKey")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.DictionaryValue)
                .HasColumnName("DictionaryValue")
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100);

            // relationships
            builder.HasOne(t => t.SystemRole)
                .WithMany(t => t.SystemRoleDictionaries)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_SYSTEM_R_REFERENCE_SYSTEM_RC");

            #endregion
        }

    }
}
