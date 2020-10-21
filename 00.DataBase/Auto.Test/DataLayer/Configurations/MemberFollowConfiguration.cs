using System.Composition;
using Microsoft.EntityFrameworkCore;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.DataLayer.Configurations
{
	[Export(typeof(IEntityTypeConfiguration))]
	public class MemberFollowConfiguration : IEntityTypeConfiguration
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<MemberFollow>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("Member_Follow", "dbo");
			
				// Set key for entity
				builder.HasKey(p => p.FollowId);
			
				// Set identity for entity (auto increment)
				builder.Property(p => p.FollowId).UseSqlServerIdentityColumn();
			
				// Set configuration for columns
				builder.Property(p => p.FollowId).HasColumnType("int").IsRequired();
				builder.Property(p => p.MemberId).HasColumnType("int");
				builder.Property(p => p.SourceId).HasColumnType("int");
				builder.Property(p => p.SourceTable).HasColumnType("varchar(20)");
				builder.Property(p => p.FollowTime).HasColumnType("datetime");
				builder.Property(p => p.IsEnable).HasColumnType("int");
				builder.Property(p => p.Remarks).HasColumnType("nvarchar(510)");
			
				// Add configuration for foreign keys
				builder
					.HasOne(p => p.MemberInfosFk)
					.WithMany(b => b.MemberFollows)
					.HasForeignKey(p => p.MemberId)
					.HasConstraintName("FK_MEMBER_F_REFERENCE_MEMBER_I2");
			
			});
		}
	}
}
