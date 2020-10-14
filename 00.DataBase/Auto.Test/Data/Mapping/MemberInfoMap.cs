using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Mapping
{
    public partial class MemberInfoMap
        : IEntityTypeConfiguration<AutoNews.Data.Entities.MemberInfo>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AutoNews.Data.Entities.MemberInfo> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Member_Info", "dbo");

            // key
            builder.HasKey(t => t.MemberId);

            // properties
            builder.Property(t => t.MemberId)
                .IsRequired()
                .HasColumnName("MemberId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.NickName)
                .HasColumnName("NickName")
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.Name)
                .HasColumnName("Name")
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.Sex)
                .HasColumnName("Sex")
                .HasColumnType("int");

            builder.Property(t => t.Phone)
                .HasColumnName("Phone")
                .HasColumnType("varchar(15)")
                .HasMaxLength(15);

            builder.Property(t => t.Alipay)
                .HasColumnName("Alipay")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.Wechat)
                .HasColumnName("Wechat")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Password)
                .HasColumnName("Password")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.Property(t => t.Avatar)
                .HasColumnName("Avatar")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Beans)
                .HasColumnName("Beans")
                .HasColumnType("int");

            builder.Property(t => t.BeansTotals)
                .HasColumnName("BeansTotals")
                .HasColumnType("int");

            builder.Property(t => t.LastLoginTime)
                .HasColumnName("LastLoginTime")
                .HasColumnType("datetime");

            builder.Property(t => t.IsEnbale)
                .HasColumnName("IsEnbale")
                .HasColumnType("int");

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.CreateTime)
                .HasColumnName("CreateTime")
                .HasColumnType("datetime");

            // relationships
            #endregion
        }

    }
}
