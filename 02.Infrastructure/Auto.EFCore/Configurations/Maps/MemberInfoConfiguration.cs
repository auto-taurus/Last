using Auto.EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using System.Composition;

namespace Auto.EFCore.Configurations.Maps {
    [Export(typeof(IEntityTypeConfiguration))]
    public class MemberInfoConfiguration : IEntityTypeConfiguration {
        public void Configure(ModelBuilder modelBuilder) {
            modelBuilder.Entity<MemberInfo>(builder => {
                // Set configuration for entity
                builder.ToTable("Member_Info", "dbo");

                // Set key for entity
                builder.HasKey(p => p.MemberId);

                // Set identity for entity (auto increment)
                builder.Property(p => p.MemberId).UseSqlServerIdentityColumn();

                // Set configuration for columns
                builder.Property(p => p.MemberId).HasColumnType("int").IsRequired();
                builder.Property(p => p.NickName).HasColumnType("nvarchar(40)");
                builder.Property(p => p.Name).HasColumnType("nvarchar(40)");
                builder.Property(p => p.Sex).HasColumnType("int");
                builder.Property(p => p.Phone).HasColumnType("varchar(15)");
                builder.Property(p => p.Alipay).HasColumnType("varchar(20)");
                builder.Property(p => p.Wechat).HasColumnType("varchar(50)");
                builder.Property(p => p.Password).HasColumnType("varchar(100)");
                builder.Property(p => p.Avatar).HasColumnType("varchar(255)");
                builder.Property(p => p.Beans).HasColumnType("int");
                builder.Property(p => p.BeansTotals).HasColumnType("int");
                builder.Property(p => p.LastLoginTime).HasColumnType("datetime");
                builder.Property(p => p.IsEnbale).HasColumnType("int");
                builder.Property(p => p.Remarks).HasColumnType("nvarchar(510)");
                builder.Property(p => p.CreateTime).HasColumnType("datetime");
            });
        }
    }
}
