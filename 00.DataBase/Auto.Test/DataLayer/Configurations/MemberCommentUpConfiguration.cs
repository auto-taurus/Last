using System.Composition;
using Microsoft.EntityFrameworkCore;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.DataLayer.Configurations
{
	[Export(typeof(IEntityTypeConfiguration))]
	public class MemberCommentUpConfiguration : IEntityTypeConfiguration
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<MemberCommentUp>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("Member_CommentUp", "dbo");
			
				// Set key for entity
				builder.HasKey(p => p.CommentUpId);
			
				// Set identity for entity (auto increment)
				builder.Property(p => p.CommentUpId).UseSqlServerIdentityColumn();
			
				// Set configuration for columns
				builder.Property(p => p.CommentUpId).HasColumnType("int").IsRequired();
				builder.Property(p => p.CommentId).HasColumnType("int");
				builder.Property(p => p.MemberId).HasColumnType("int");
			
				// Add configuration for foreign keys
				builder
					.HasOne(p => p.MemberCommentFk)
					.WithMany(b => b.MemberCommentUps)
					.HasForeignKey(p => p.CommentId)
					.HasConstraintName("FK_MEMBER_C_REFERENCE_MEMBER_C");
			
			});
		}
	}
}
