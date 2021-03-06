using System.Composition;
using Microsoft.EntityFrameworkCore;
using Auto.Entities.Modals;

namespace Auto.Configurations.Maps
{
	[Export(typeof(IConfigurations))]
	public class AutoBatchInsertNewsIdConfiguration : IConfigurations
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<AutoBatchInsertNewsId>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("Auto_BatchInsert_NewsId", "dbo");
			
				// Set key for entity
				builder.HasKey(p => p.Id);
			
				// Set identity for entity (auto increment)
				builder.Property(p => p.Id).UseSqlServerIdentityColumn();
			
				// Set configuration for columns
				builder.Property(p => p.Id).HasColumnType("int").IsRequired();
				builder.Property(p => p.NewsId).HasColumnType("int");
				builder.Property(p => p.Message).HasColumnType("nvarchar(-1)");
			
			});
		}
	}
}
