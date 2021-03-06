using System.Composition;
using Microsoft.EntityFrameworkCore;
using Auto.EFCore.Entities;

namespace Auto.EFCore.Configurations.Maps {
    [Export(typeof(IEntityTypeConfiguration))]
    public class WebNewsConfiguration : IEntityTypeConfiguration {
        public void Configure(ModelBuilder modelBuilder) {
            modelBuilder.Entity<WebNews>(builder => {
                // Set configuration for entity
                builder.ToTable("Web_News", "dbo");

                // Set key for entity
                builder.HasKey(p => p.NewsId);

                // Set configuration for columns
                builder.Property(p => p.NewsId).HasColumnType("varchar(12)").IsRequired();
                builder.Property(p => p.SpecialCode).HasColumnType("varchar(10)");
                builder.Property(p => p.CategoryId).HasColumnType("int");
                builder.Property(p => p.CategoryName).HasColumnType("nvarchar(100)");
                builder.Property(p => p.NewsTitle).HasColumnType("nvarchar(1000)");
                builder.Property(p => p.CustomTitle).HasColumnType("nvarchar(1000)");
                builder.Property(p => p.Source).HasColumnType("nvarchar(100)");
                builder.Property(p => p.SourceAddress).HasColumnType("nvarchar(2000)");
                builder.Property(p => p.SourceLogo).HasColumnType("nvarchar(2000)");
                builder.Property(p => p.Tags).HasColumnType("nvarchar(510)");
                builder.Property(p => p.Contents).HasColumnType("nvarchar(-1)");
                builder.Property(p => p.Controller).HasColumnType("varchar(50)");
                builder.Property(p => p.Action).HasColumnType("varchar(50)");
                builder.Property(p => p.Urls).HasColumnType("nvarchar(2000)");
                builder.Property(p => p.ImageThums).HasColumnType("nvarchar(4000)");
                builder.Property(p => p.ImagePaths).HasColumnType("nvarchar(4000)");
                builder.Property(p => p.DisplayType).HasColumnType("int");
                builder.Property(p => p.IsHot).HasColumnType("int");
                builder.Property(p => p.Title).HasColumnType("nvarchar(510)");
                builder.Property(p => p.Keywords).HasColumnType("nvarchar(510)");
                builder.Property(p => p.Description).HasColumnType("nvarchar(510)");
                builder.Property(p => p.AccessNumber).HasColumnType("int");
                builder.Property(p => p.VirtualAccessNumber).HasColumnType("int");
                builder.Property(p => p.ClickNumber).HasColumnType("int");
                builder.Property(p => p.Author).HasColumnType("varchar(50)");
                builder.Property(p => p.AuditBy).HasColumnType("int");
                builder.Property(p => p.AuditStatus).HasColumnType("int");
                builder.Property(p => p.AuditTime).HasColumnType("datetime");
                builder.Property(p => p.PushBy).HasColumnType("int");
                builder.Property(p => p.PushStatus).HasColumnType("int");
                builder.Property(p => p.PushTime).HasColumnType("datetime");
                builder.Property(p => p.OperateType).HasColumnType("int");
                builder.Property(p => p.CategorySort).HasColumnType("int");
                builder.Property(p => p.SpecialSort).HasColumnType("int");
                builder.Property(p => p.Sequence).HasColumnType("int");
                builder.Property(p => p.IsEnable).HasColumnType("int");
                builder.Property(p => p.RowVers).HasColumnType("timestamp");
                builder.Property(p => p.Remarks).HasColumnType("nvarchar(510)");
                builder.Property(p => p.CreateBy).HasColumnType("int");
                builder.Property(p => p.CreateTime).HasColumnType("datetime");

                // Add configuration for foreign keys
                builder
                    .HasOne(p => p.WebCategory)
                    .WithMany(b => b.WebNews)
                    .HasForeignKey(p => p.CategoryId)
                    .HasConstraintName("FK_WEB_NEWS_REFERENCE_WEB_CATE");

            });
        }
    }
}
