using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Mapping
{
    public partial class SystemUsersDictionaryMap
        : IEntityTypeConfiguration<Master.Data.Entities.SystemUsersDictionary>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Master.Data.Entities.SystemUsersDictionary> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("System_UsersDictionary", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.UserId)
                .IsRequired()
                .HasColumnName("UserId")
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
            builder.HasOne(t => t.UserSystemUsers)
                .WithMany(t => t.UserSystemUsersDictionaries)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_SYSTEM_U_REFERENCE_SYSTEM_UC");

            #endregion
        }

    }
}
