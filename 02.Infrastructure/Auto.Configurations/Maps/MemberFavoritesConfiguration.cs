using System.Composition;
using Microsoft.EntityFrameworkCore;
using Auto.Entities.Modals;

namespace Auto.Configurations.Maps
{
	[Export(typeof(IConfigurations))]
	public class MemberFavoritesConfiguration : IConfigurations
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<MemberFavorites>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("Member_Favorites", "dbo");
			
				// Set key for entity
				builder.HasKey(p => p.FavoritesId);
			
				// Set identity for entity (auto increment)
				builder.Property(p => p.FavoritesId).UseSqlServerIdentityColumn();
			
				// Set configuration for columns
				builder.Property(p => p.FavoritesId).HasColumnType("int").IsRequired();
				builder.Property(p => p.MemberId).HasColumnType("int");
				builder.Property(p => p.SourceId).HasColumnType("varchar(20)");
				builder.Property(p => p.SourceTable).HasColumnType("varchar(50)");
				builder.Property(p => p.FavoritesTime).HasColumnType("datetime");
				builder.Property(p => p.IsEnable).HasColumnType("int");
				builder.Property(p => p.Remarks).HasColumnType("nvarchar(510)");
			
				// Add configuration for foreign keys
				builder
					.HasOne(p => p.MemberInfos)
					.WithMany(b => b.MemberFavorites)
					.HasForeignKey(p => p.MemberId)
					.HasConstraintName("FK_MEMBER_F_REFERENCE_MEMBER_I3");
			
			});
		}
	}
}
