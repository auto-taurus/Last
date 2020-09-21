using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Auto.EFCore.Entities.WebChannel" />
    /// </summary>
    public partial class WebChannelMap
        : IEntityTypeConfiguration<Auto.EFCore.Entities.WebChannel>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Auto.EFCore.Entities.WebChannel" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Auto.EFCore.Entities.WebChannel> builder)
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

            builder.Property(t => t.Timestamp)
                .IsRowVersion()
                .HasColumnName("Timestamp")
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

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="Auto.EFCore.Entities.WebChannel" /></summary>
            public const string Schema = "dbo";
            /// <summary>Table Name constant for entity <see cref="Auto.EFCore.Entities.WebChannel" /></summary>
            public const string Name = "Web_Channel";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebChannel.ChannelId" /></summary>
            public const string ChannelId = "ChannelId";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebChannel.SiteNo" /></summary>
            public const string SiteNo = "SiteNo";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebChannel.ChannelName" /></summary>
            public const string ChannelName = "ChannelName";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebChannel.ChannelAddress" /></summary>
            public const string ChannelAddress = "ChannelAddress";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebChannel.ChannelJs" /></summary>
            public const string ChannelJs = "ChannelJs";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebChannel.IsEnable" /></summary>
            public const string IsEnable = "IsEnable";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebChannel.Timestamp" /></summary>
            public const string Timestamp = "Timestamp";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebChannel.Remarks" /></summary>
            public const string Remarks = "Remarks";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebChannel.CreateBy" /></summary>
            public const string CreateBy = "CreateBy";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.WebChannel.CreateTime" /></summary>
            public const string CreateTime = "CreateTime";
        }
        #endregion
    }
}
