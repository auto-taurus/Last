using System.Composition;
using Microsoft.EntityFrameworkCore;
using Auto.EFCore.Entities;

namespace Auto.EFCore.Configurations.Maps
{
	[Export(typeof(IEntityTypeConfiguration))]
	public class SystemRoleDictionaryConfiguration : IEntityTypeConfiguration
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<SystemRoleDictionary>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("System_RoleDictionary", "dbo");
			
				// Set key for entity
				builder.HasKey(p => p.Id);
			
				// Set identity for entity (auto increment)
				builder.Property(p => p.Id).UseSqlServerIdentityColumn();
			
				// Set configuration for columns
				builder.Property(p => p.Id).HasColumnType("int").IsRequired();
				builder.Property(p => p.RoleId).HasColumnType("int").IsRequired();
				builder.Property(p => p.DictionaryKey).HasColumnType("varchar(20)");
				builder.Property(p => p.DictionaryValue).HasColumnType("nvarchar(200)");
			
				// Add configuration for foreign keys
				builder
					.HasOne(p => p.SystemRole)
					.WithMany(b => b.SystemRoleDictionaries)
					.HasForeignKey(p => p.RoleId)
					.HasConstraintName("FK_SYSTEM_R_REFERENCE_SYSTEM_RC");
			
			});
		}
	}
}
