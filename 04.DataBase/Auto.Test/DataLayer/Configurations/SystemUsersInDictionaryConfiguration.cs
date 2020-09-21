using System.Composition;
using Microsoft.EntityFrameworkCore;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.DataLayer.Configurations
{
	[Export(typeof(IEntityTypeConfiguration))]
	public class SystemUsersInDictionaryConfiguration : IEntityTypeConfiguration
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<SystemUsersInDictionary>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("System_UsersInDictionary", "dbo");
			
				// Set key for entity
				builder.HasKey(p => p.Id);
			
				// Set identity for entity (auto increment)
				builder.Property(p => p.Id).UseSqlServerIdentityColumn();
			
				// Set configuration for columns
				builder.Property(p => p.Id).HasColumnType("int").IsRequired();
				builder.Property(p => p.UserId).HasColumnType("int").IsRequired();
				builder.Property(p => p.DictionaryKey).HasColumnType("varchar(20)");
				builder.Property(p => p.DictionaryValue).HasColumnType("nvarchar(200)");
			
				// Add configuration for foreign keys
				builder
					.HasOne(p => p.SystemUsersFk)
					.WithMany(b => b.SystemUsersInDictionaries)
					.HasForeignKey(p => p.UserId)
					.HasConstraintName("FK_SYSTEM_U_REFERENCE_SYSTEM_UC");
			
			});
		}
	}
}
