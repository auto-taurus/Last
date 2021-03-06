using System.Composition;
using Microsoft.EntityFrameworkCore;
using Auto.Entities.Modals;

namespace Auto.Configurations.Maps
{
	[Export(typeof(IConfigurations))]
	public class MemberWithdrawConfiguration : IConfigurations
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<MemberWithdraw>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("Member_Withdraw", "dbo");
			
				// Set key for entity
				builder.HasKey(p => p.WithdrawId);
			
				// Set configuration for columns
				builder.Property(p => p.WithdrawId).HasColumnType("bigint").IsRequired();
				builder.Property(p => p.MemberId).HasColumnType("int");
				builder.Property(p => p.Methods).HasColumnType("int");
				builder.Property(p => p.Title).HasColumnType("nvarchar(100)");
				builder.Property(p => p.Beans).HasColumnType("int");
				builder.Property(p => p.Amount).HasColumnType("decimal(18, 2)");
				builder.Property(p => p.Proportion).HasColumnType("varchar(20)");
				builder.Property(p => p.CreateTime).HasColumnType("datetime");
				builder.Property(p => p.Status).HasColumnType("int");
				builder.Property(p => p.Remarks).HasColumnType("nvarchar(510)");
				builder.Property(p => p.AuditId).HasColumnType("int");
				builder.Property(p => p.Audit).HasColumnType("nvarchar(100)");
				builder.Property(p => p.AuditTime).HasColumnType("datetime");
			
				// Add configuration for foreign keys
				builder
					.HasOne(p => p.MemberInfos)
					.WithMany(b => b.MemberWithdraws)
					.HasForeignKey(p => p.MemberId)
					.HasConstraintName("FK_MEMBER_W_REFERENCE_MEMBER_I");
			
			});
		}
	}
}
