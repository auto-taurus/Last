using System.Composition;
using Microsoft.EntityFrameworkCore;
using Auto.Entities.Modals;

namespace Auto.Configurations.Maps
{
	[Export(typeof(IConfigurations))]
	public class MemberWithdrawConfigConfiguration : IConfigurations
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<MemberWithdrawConfig>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("Member_WithdrawConfig", "dbo");
			
				// Set key for entity
				builder.HasKey(p => p.WithdrawConfigId);
			
				// Set identity for entity (auto increment)
				builder.Property(p => p.WithdrawConfigId).UseSqlServerIdentityColumn();
			
				// Set configuration for columns
				builder.Property(p => p.WithdrawConfigId).HasColumnType("int").IsRequired();
				builder.Property(p => p.Methods).HasColumnType("int");
				builder.Property(p => p.Tips).HasColumnType("varchar(20)");
				builder.Property(p => p.WithdrawTask).HasColumnType("varchar(5)");
				builder.Property(p => p.Amount).HasColumnType("decimal(18, 2)");
				builder.Property(p => p.AmountTips).HasColumnType("varchar(20)");
				builder.Property(p => p.AmountDesc).HasColumnType("nvarchar(510)");
				builder.Property(p => p.AmountTask).HasColumnType("varchar(5)");
				builder.Property(p => p.Desc).HasColumnType("nvarchar(510)");
				builder.Property(p => p.IsEnable).HasColumnType("int");
				builder.Property(p => p.Remarks).HasColumnType("varchar(255)");
				builder.Property(p => p.CreateBy).HasColumnType("int");
				builder.Property(p => p.CreateTime).HasColumnType("datetime");
			
			});
		}
	}
}
