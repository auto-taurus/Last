using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Mapping
{
    public partial class MemberProblemMap
        : IEntityTypeConfiguration<Master.Data.Entities.MemberProblem>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Master.Data.Entities.MemberProblem> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("Member_Problem", "dbo");

            // key
            builder.HasKey(t => t.ProblemId);

            // properties
            builder.Property(t => t.ProblemId)
                .IsRequired()
                .HasColumnName("ProblemId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.Title)
                .HasColumnName("Title")
                .HasColumnType("nvarchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Desc)
                .HasColumnName("Desc")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.Type)
                .HasColumnName("Type")
                .HasColumnType("int");

            builder.Property(t => t.Urls)
                .HasColumnName("Urls")
                .HasColumnType("nvarchar(500)")
                .HasMaxLength(500);

            builder.Property(t => t.IsHot)
                .HasColumnName("IsHot")
                .HasColumnType("int");

            builder.Property(t => t.Sequence)
                .HasColumnName("Sequence")
                .HasColumnType("int");

            builder.Property(t => t.IsEnable)
                .HasColumnName("IsEnable")
                .HasColumnType("int");

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("nvarchar(500)")
                .HasMaxLength(500);

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
