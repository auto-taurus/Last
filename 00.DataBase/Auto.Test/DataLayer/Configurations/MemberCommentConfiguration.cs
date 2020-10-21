using System.Composition;
using Microsoft.EntityFrameworkCore;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.DataLayer.Configurations
{
	[Export(typeof(IEntityTypeConfiguration))]
	public class MemberCommentConfiguration : IEntityTypeConfiguration
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<MemberComment>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("Member_Comment", "dbo");
			
				// Set key for entity
				builder.HasKey(p => p.CommentId);
			
				// Set identity for entity (auto increment)
				builder.Property(p => p.CommentId).UseSqlServerIdentityColumn();
			
				// Set configuration for columns
				builder.Property(p => p.CommentId).HasColumnType("int").IsRequired();
				builder.Property(p => p.NewsId).HasColumnType("varchar(12)");
				builder.Property(p => p.ParentId).HasColumnType("int");
				builder.Property(p => p.OCommentId).HasColumnType("int");
				builder.Property(p => p.OCommentName).HasColumnType("nvarchar(40)");
				builder.Property(p => p.OCommentBody).HasColumnType("nvarchar(510)");
				builder.Property(p => p.TCommentId).HasColumnType("int");
				builder.Property(p => p.TCommentName).HasColumnType("nvarchar(40)");
				builder.Property(p => p.TCommentBody).HasColumnType("nvarchar(510)");
				builder.Property(p => p.CommentTime).HasColumnType("datetime");
				builder.Property(p => p.QuoteId).HasColumnType("int");
				builder.Property(p => p.QuoteName).HasColumnType("nvarchar(40)");
				builder.Property(p => p.Up).HasColumnType("int");
				builder.Property(p => p.IsEnable).HasColumnType("int");
				builder.Property(p => p.Remarks).HasColumnType("nvarchar(510)");
			
				// Add configuration for foreign keys
				builder
					.HasOne(p => p.WebNewsFk)
					.WithMany(b => b.MemberComments)
					.HasForeignKey(p => p.NewsId)
					.HasConstraintName("FK_MEMBER_C_REFERENCE_WEB_NEWS");
			
			});
		}
	}
}
