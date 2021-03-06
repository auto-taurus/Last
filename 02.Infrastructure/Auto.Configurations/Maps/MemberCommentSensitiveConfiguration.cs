using System.Composition;
using Microsoft.EntityFrameworkCore;
using Auto.Entities.Modals;

namespace Auto.Configurations.Maps
{
	[Export(typeof(IConfigurations))]
	public class MemberCommentSensitiveConfiguration : IConfigurations
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<MemberCommentSensitive>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("Member_CommentSensitive", "dbo");
			
				// Set key for entity
				builder.HasKey(p => p.CommentSensitiveId);
			
				// Set identity for entity (auto increment)
				builder.Property(p => p.CommentSensitiveId).UseSqlServerIdentityColumn();
			
				// Set configuration for columns
				builder.Property(p => p.CommentSensitiveId).HasColumnType("int").IsRequired();
				builder.Property(p => p.SensitiveWords).HasColumnType("nvarchar(40)");
				builder.Property(p => p.ReplaceValue).HasColumnType("nvarchar(40)");
				builder.Property(p => p.IsEnable).HasColumnType("int");
				builder.Property(p => p.Remarks).HasColumnType("nvarchar(510)");
				builder.Property(p => p.CreateBy).HasColumnType("int");
				builder.Property(p => p.CreateTime).HasColumnType("datetime");
			
			});
		}
	}
}
