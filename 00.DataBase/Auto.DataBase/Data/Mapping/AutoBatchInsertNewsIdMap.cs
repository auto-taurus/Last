using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Mapping
{
    public partial class AutoBatchInsertNewsIdMap
        : IEntityTypeConfiguration<Master.Data.Entities.AutoBatchInsertNewsId>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Master.Data.Entities.AutoBatchInsertNewsId> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Auto_BatchInsert_NewsId", "dbo");

            // key
            builder.HasKey(t => t.Id);

            // properties
            builder.Property(t => t.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.NewsId)
                .HasColumnName("NewsId")
                .HasColumnType("int");

            builder.Property(t => t.Message)
                .HasColumnName("Message")
                .HasColumnType("nvarchar(max)");

            // relationships
            #endregion
        }

    }
}
