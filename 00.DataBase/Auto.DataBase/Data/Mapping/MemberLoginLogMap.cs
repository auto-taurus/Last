using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Mapping
{
    public partial class MemberLoginLogMap
        : IEntityTypeConfiguration<Master.Data.Entities.MemberLoginLog>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Master.Data.Entities.MemberLoginLog> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Member_LoginLog", "dbo");

            // key
            builder.HasKey(t => t.LoginLogId);

            // properties
            builder.Property(t => t.LoginLogId)
                .IsRequired()
                .HasColumnName("LoginLogId")
                .HasColumnType("numeric(18,0)")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Source)
                .HasColumnName("Source")
                .HasColumnType("char(10)")
                .HasMaxLength(10);

            builder.Property(t => t.Column3)
                .HasColumnName("Column_3")
                .HasColumnType("char(10)")
                .HasMaxLength(10);

            builder.Property(t => t.Column4)
                .HasColumnName("Column_4")
                .HasColumnType("char(10)")
                .HasMaxLength(10);

            // relationships
            #endregion
        }

    }
}
