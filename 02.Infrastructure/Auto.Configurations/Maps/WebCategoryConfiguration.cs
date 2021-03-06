using System.Composition;
using Microsoft.EntityFrameworkCore;
using Auto.Entities.Modals;

namespace Auto.Configurations.Maps
{
	[Export(typeof(IConfigurations))]
	public class WebCategoryConfiguration : IConfigurations
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<WebCategory>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("Web_Category", "dbo");
			
				// Set key for entity
				builder.HasKey(p => p.CategoryId);
			
				// Set configuration for columns
				builder.Property(p => p.CategoryId).HasColumnType("int").IsRequired();
				builder.Property(p => p.SiteId).HasColumnType("int");
				builder.Property(p => p.CategoryName).HasColumnType("nvarchar(40)");
				builder.Property(p => p.ParentId).HasColumnType("int");
				builder.Property(p => p.NodeValue).HasColumnType("varchar(1000)");
				builder.Property(p => p.Controller).HasColumnType("varchar(50)");
				builder.Property(p => p.Action).HasColumnType("varchar(50)");
				builder.Property(p => p.Urls).HasColumnType("varchar(500)");
				builder.Property(p => p.DocumentNumber).HasColumnType("int");
				builder.Property(p => p.AccessNumber).HasColumnType("int");
				builder.Property(p => p.ClickNumber).HasColumnType("int");
				builder.Property(p => p.Title).HasColumnType("varchar(255)");
				builder.Property(p => p.Keywords).HasColumnType("varchar(255)");
				builder.Property(p => p.Description).HasColumnType("varchar(255)");
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
