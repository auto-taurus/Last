using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Mapping
{
    public partial class SystemUsersMap
        : IEntityTypeConfiguration<AutoNews.Data.Entities.SystemUsers>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AutoNews.Data.Entities.SystemUsers> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("System_Users", "dbo");

            // key
            builder.HasKey(t => t.UsersId);

            // properties
            builder.Property(t => t.UsersId)
                .IsRequired()
                .HasColumnName("UsersId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.UsersName)
                .HasColumnName("UsersName")
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.LoginName)
                .HasColumnName("LoginName")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Password)
                .HasColumnName("Password")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.MobilePhone)
                .HasColumnName("MobilePhone")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Email)
                .HasColumnName("Email")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.LoginIp)
                .HasColumnName("LoginIp")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.LoginTime)
                .HasColumnName("LoginTime")
                .HasColumnType("datetime");

            builder.Property(t => t.IsEnable)
                .HasColumnName("IsEnable")
                .HasColumnType("int");

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
