using System.Composition;
using Microsoft.EntityFrameworkCore;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.DataLayer.Configurations
{
	[Export(typeof(IEntityTypeConfiguration))]
	public class SystemUsersInMenuConfiguration : IEntityTypeConfiguration
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<SystemUsersInMenu>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("System_UsersInMenu", "dbo");
			
			#warning Add configuration for entity's key
			
				// Set configuration for columns
				builder.Property(p => p.UserId).HasColumnType("int");
				builder.Property(p => p.MenuId).HasColumnType("int");
			
			});
		}
	}
}
