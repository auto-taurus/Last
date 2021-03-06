using System.Composition;
using Microsoft.EntityFrameworkCore;
using Auto.Entities.Modals;

namespace Auto.Configurations.Maps
{
	[Export(typeof(IConfigurations))]
	public class MemberFansConfiguration : IConfigurations
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<MemberFans>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("Member_Fans", "dbo");
			
				// Set key for entity
				builder.HasKey(p => p.FansId);
			
				// Set identity for entity (auto increment)
				builder.Property(p => p.FansId).UseSqlServerIdentityColumn();
			
				// Set configuration for columns
				builder.Property(p => p.FansId).HasColumnType("int").IsRequired();
				builder.Property(p => p.MemberId).HasColumnType("int");
				builder.Property(p => p.MemberFansId).HasColumnType("int");
				builder.Property(p => p.MemberFansName).HasColumnType("nvarchar(100)");
				builder.Property(p => p.FollowTime).HasColumnType("datetime");
				builder.Property(p => p.IsEnable).HasColumnType("int");
				builder.Property(p => p.Remarks).HasColumnType("nvarchar(510)");
			
				// Add configuration for foreign keys
				builder
					.HasOne(p => p.MemberInfos)
					.WithMany(b => b.MemberFans)
					.HasForeignKey(p => p.MemberId)
					.HasConstraintName("FK_MEMBER_F_REFERENCE_MEMBER_I");
			
			});
		}
	}
}
