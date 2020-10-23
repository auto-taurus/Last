using System.Composition;
using Microsoft.EntityFrameworkCore;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.DataLayer.Configurations
{
	[Export(typeof(IEntityTypeConfiguration))]
	public class SptValuesConfiguration : IEntityTypeConfiguration
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<SptValues>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("spt_values", "dbo");
			
				// Add configuration for entity's key
				builder.HasKey(p => new { p.Number, p.Type });
			
				// Set configuration for columns
				builder.Property(p => p.Name).HasColumnName("name").HasColumnType("nvarchar(70)");
				builder.Property(p => p.Number).HasColumnName("number").HasColumnType("int");
				builder.Property(p => p.Type).HasColumnName("type").HasColumnType("nchar(6)");
				builder.Property(p => p.Low).HasColumnName("low").HasColumnType("int");
				builder.Property(p => p.High).HasColumnName("high").HasColumnType("int");
				builder.Property(p => p.Status).HasColumnName("status").HasColumnType("int");
			});
		}
	}
}
