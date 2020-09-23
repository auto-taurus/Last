using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Mapping
{
    public partial class WebChannelMap
        : IEntityTypeConfiguration<AutoNews.Data.Entities.WebChannel>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AutoNews.Data.Entities.WebChannel> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Web_Channel", "dbo");

            // key
            builder.HasKey(t => t.ChannelId);

            // properties
            builder.Property(t => t.ChannelId)
                .IsRequired()
                .HasColumnName("ChannelId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.SiteNo)
                .HasColumnName("SiteNo")
                .HasColumnType("int");

            builder.Property(t => t.ChannelName)
                .HasColumnName("ChannelName")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.ChannelAddress)
                .HasColumnName("ChannelAddress")
                .HasColumnType("varchar(1000)")
                .HasMaxLength(1000);

            builder.Property(t => t.ChannelJs)
                .HasColumnName("ChannelJs")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

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
