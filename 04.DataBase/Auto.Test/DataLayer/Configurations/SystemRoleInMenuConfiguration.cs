using System.Composition;
using Microsoft.EntityFrameworkCore;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.DataLayer.Configurations
{
	[Export(typeof(IEntityTypeConfiguration))]
	public class SystemRoleInMenuConfiguration : IEntityTypeConfiguration
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<SystemRoleInMenu>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("System_RoleInMenu", "dbo");
			
			#warning Add configuration for entity's key
			
				// Set configuration for columns
				builder.Property(p => p.RoleId).HasColumnType("int");
				builder.Property(p => p.MenuId).HasColumnType("int");
			
			});
		}
	}
}
