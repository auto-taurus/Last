using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Mapping
{
    public partial class SystemUsersRefreshTokenMap
        : IEntityTypeConfiguration<Master.Data.Entities.SystemUsersRefreshToken>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Master.Data.Entities.SystemUsersRefreshToken> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("System_UsersRefreshToken", "dbo");

            // key
            builder.HasKey(t => t.RefreshTokenId);

            // properties
            builder.Property(t => t.RefreshTokenId)
                .IsRequired()
                .HasColumnName("RefreshTokenId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.UsersId)
                .HasColumnName("UsersId")
                .HasColumnType("int");

            builder.Property(t => t.AccessToken)
                .HasColumnName("AccessToken")
                .HasColumnType("varchar(1000)")
                .HasMaxLength(1000);

            builder.Property(t => t.Expires)
                .HasColumnName("Expires")
                .HasColumnType("datetime");

            builder.Property(t => t.Active)
                .HasColumnName("Active")
                .HasColumnType("int");

            // relationships
            #endregion
        }

    }
}
