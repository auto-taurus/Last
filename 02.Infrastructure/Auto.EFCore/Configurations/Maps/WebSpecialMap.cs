using Auto.EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Composition;

namespace Auto.EFCore.Configurations {
    internal class WebSpecialMap : IEntityTypeConfiguration<WebSpecial> {
        public void Configure(EntityTypeBuilder<WebSpecial> builder) {
            // Set configuration for entity
            builder.ToTable("Web_Special", "dbo");
            // Set key for entity
            builder.HasKey(p => new { p.SpecialId, p.SpecialCode });
            // Set identity for entity (auto increment)
            builder.Property(p => p.SpecialId).UseSqlServerIdentityColumn();
            // Set configuration for columns
            builder
                .Property(p => p.SpecialId)
                .HasColumnType("int")
                .IsRequired()
                ;

            builder
                .Property(p => p.SiteNo)
                .HasColumnType("int")
                ;

            builder
                .Property(p => p.SpecialCode)
                .HasColumnType("varchar")
                .HasMaxLength(10)
                .IsRequired()
                ;

            builder
                .Property(p => p.Name)
                .HasColumnType("nvarchar")
                .HasMaxLength(100)
                ;

            builder
                .Property(p => p.DisplayType)
                .HasColumnType("int")
                ;

            builder
                .Property(p => p.IsEnable)
                .HasColumnType("int")
                ;

            builder
                .Property(p => p.Timestamp)
                .HasColumnType("timestamp(8)")
                ;

            builder
                .Property(p => p.Remarks)
                .HasColumnType("nvarchar")
                .HasMaxLength(510)
                ;

            builder
                .Property(p => p.CreateBy)
                .HasColumnType("int")
                ;

            builder
                .Property(p => p.CreateTime)
                .HasColumnType("datetime")
                ;

            // Set concurrency token for entity
            builder
                .Property(p => p.Timestamp)
                .ValueGeneratedOnAddOrUpdate()
                .IsConcurrencyToken();

        }
    }
}
