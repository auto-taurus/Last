using System.Composition;
using Microsoft.EntityFrameworkCore;
using Auto.EFCore.Entities;

namespace Auto.EFCore.Configurations.Maps
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
				builder.Property(p => p.Keys).HasColumnType("varchar(50)");
				builder.Property(p => p.Name).HasColumnType("nvarchar(510)");
				builder.Property(p => p.Value).HasColumnType("nvarchar(2000)");
				builder.Property(p => p.Remarks).HasColumnType("nvarchar(510)");
			
			});
		}
	}
}
