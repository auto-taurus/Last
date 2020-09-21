using System.Composition;
using Microsoft.EntityFrameworkCore;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.DataLayer.Configurations
{
	[Export(typeof(IEntityTypeConfiguration))]
	public class SystemUsersInRoleConfiguration : IEntityTypeConfiguration
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<SystemUsersInRole>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("System_UsersInRole", "dbo");
			
			#warning Add configuration for entity's key
			
				// Set configuration for columns
				builder.Property(p => p.UsersId).HasColumnType("int");
				builder.Property(p => p.RoleId).HasColumnType("int");
			
			});
		}
	}
}
