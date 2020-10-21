using System.Composition;
using Microsoft.EntityFrameworkCore;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.DataLayer.Configurations
{
	[Export(typeof(IEntityTypeConfiguration))]
	public class SystemDictionaryConfiguration : IEntityTypeConfiguration
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<SystemDictionary>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("System_Dictionary", "dbo");
			
				// Set key for entity
				builder.HasKey(p => p.DictionaryId);
			
				// Set identity for entity (auto increment)
				builder.Property(p => p.DictionaryId).UseSqlServerIdentityColumn();
			
				// Set configuration for columns
				builder.Property(p => p.DictionaryId).HasColumnType("int").IsRequired();
				builder.Property(p => p.TypeKey).HasColumnType("varchar(20)");
				builder.Property(p => p.DistKey).HasColumnType("varchar(20)");
				builder.Property(p => p.DistName).HasColumnType("nvarchar(40)");
				builder.Property(p => p.DistValue).HasColumnType("nvarchar(510)");
				builder.Property(p => p.Sequence).HasColumnType("int");
				builder.Property(p => p.IsEnable).HasColumnType("int");
				builder.Property(p => p.Remarks).HasColumnType("nvarchar(510)");
			
			});
		}
	}
}
