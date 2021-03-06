using System.Composition;
using Microsoft.EntityFrameworkCore;
using Auto.Entities.Modals;

namespace Auto.Configurations.Maps
{
	[Export(typeof(IConfigurations))]
	public class MemberFootprintConfiguration : IConfigurations
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<MemberFootprint>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("Member_Footprint", "dbo");
			
				// Set key for entity
				builder.HasKey(p => p.FootprintId);
			
				// Set identity for entity (auto increment)
				builder.Property(p => p.FootprintId).UseSqlServerIdentityColumn();
			
				// Set configuration for columns
				builder.Property(p => p.FootprintId).HasColumnType("int").IsRequired();
				builder.Property(p => p.MemberId).HasColumnType("int");
				builder.Property(p => p.SourceId).HasColumnType("varchar(20)");
				builder.Property(p => p.SourceTable).HasColumnType("varchar(50)");
				builder.Property(p => p.BrowseTime).HasColumnType("datetime");
				builder.Property(p => p.IsEnable).HasColumnType("int");
				builder.Property(p => p.Remarks).HasColumnType("nvarchar(510)");
			
				// Add configuration for foreign keys
				builder
					.HasOne(p => p.MemberInfos)
					.WithMany(b => b.MemberFootprints)
					.HasForeignKey(p => p.MemberId)
					.HasConstraintName("FK_MEMBER_F_REFERENCE_MEMBER_I4");
			
			});
		}
	}
}
