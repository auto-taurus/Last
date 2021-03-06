using System.Composition;
using Microsoft.EntityFrameworkCore;
using Auto.EFCore.Entities;

namespace Auto.EFCore.Configurations.Maps
{
	[Export(typeof(IEntityTypeConfiguration))]
	public class SystemMenuConfiguration : IEntityTypeConfiguration
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<SystemMenu>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("System_Menu", "dbo");
			
				// Set key for entity
				builder.HasKey(p => p.MenuId);
			
				// Set configuration for columns
				builder.Property(p => p.MenuId).HasColumnType("int").IsRequired();
				builder.Property(p => p.SiteId).HasColumnType("int");
				builder.Property(p => p.MenuIcon).HasColumnType("varchar(20)");
				builder.Property(p => p.MenuName).HasColumnType("nvarchar(40)");
				builder.Property(p => p.ParentId).HasColumnType("int");
				builder.Property(p => p.NodeValue).HasColumnType("varchar(1000)");
				builder.Property(p => p.Areas).HasColumnType("varchar(100)");
				builder.Property(p => p.Controller).HasColumnType("varchar(100)");
				builder.Property(p => p.Action).HasColumnType("varchar(100)");
				builder.Property(p => p.Urls).HasColumnType("nvarchar(1000)");
				builder.Property(p => p.RouterName).HasColumnType("nvarchar(100)");
				builder.Property(p => p.RouterPath).HasColumnType("nvarchar(200)");
				builder.Property(p => p.Component).HasColumnType("varchar(100)");
				builder.Property(p => p.ShowAlways).HasColumnType("int");
				builder.Property(p => p.ShowHeader).HasColumnType("int");
				builder.Property(p => p.HideInBread).HasColumnType("int");
				builder.Property(p => p.HideInMenu).HasColumnType("int");
				builder.Property(p => p.NotCache).HasColumnType("int");
				builder.Property(p => p.BeforeCloseName).HasColumnType("int");
				builder.Property(p => p.Sequence).HasColumnType("int");
				builder.Property(p => p.IsEnable).HasColumnType("int");
				builder.Property(p => p.RowVers).HasColumnType("timestamp");
				builder.Property(p => p.Remarks).HasColumnType("nvarchar(510)");
				builder.Property(p => p.CreateBy).HasColumnType("int");
				builder.Property(p => p.CreateTime).HasColumnType("datetime");
			
			});
		}
	}
}
