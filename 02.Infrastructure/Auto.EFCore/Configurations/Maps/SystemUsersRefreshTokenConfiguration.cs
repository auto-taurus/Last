using System.Composition;
using Microsoft.EntityFrameworkCore;
using Auto.EFCore.Entities;

namespace Auto.EFCore.Configurations.Maps
{
	[Export(typeof(IEntityTypeConfiguration))]
	public class SystemUsersRefreshTokenConfiguration : IEntityTypeConfiguration
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<SystemUsersRefreshToken>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("System_UsersRefreshToken", "dbo");
			
				// Set key for entity
				builder.HasKey(p => p.RefreshTokenId);
			
				// Set identity for entity (auto increment)
				builder.Property(p => p.RefreshTokenId).UseSqlServerIdentityColumn();
			
				// Set configuration for columns
				builder.Property(p => p.RefreshTokenId).HasColumnType("int").IsRequired();
				builder.Property(p => p.UsersId).HasColumnType("int");
				builder.Property(p => p.AccessToken).HasColumnType("varchar(1000)");
				builder.Property(p => p.Expires).HasColumnType("datetime");
				builder.Property(p => p.Active).HasColumnType("int");
			
			});
		}
	}
}
