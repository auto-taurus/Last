using System.Composition;
using Microsoft.EntityFrameworkCore;
using OnLineStoreCore.EntityLayer;

namespace OnLineStoreCore.DataLayer.Configurations
{
	[Export(typeof(IEntityTypeConfiguration))]
	public class TaskInfoConfiguration : IEntityTypeConfiguration
	{
		public void Configure(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<TaskInfo>(builder =>
			{
				// Set configuration for entity
				builder.ToTable("Task_Info", "dbo");
			
				// Set key for entity
				builder.HasKey(p => p.TaskId);
			
				// Set identity for entity (auto increment)
				builder.Property(p => p.TaskId).UseSqlServerIdentityColumn();
			
				// Set configuration for columns
				builder.Property(p => p.TaskId).HasColumnType("int").IsRequired();
				builder.Property(p => p.ParentId).HasColumnType("int");
				builder.Property(p => p.TaskCode).HasColumnType("varchar(5)");
				builder.Property(p => p.RelatedTasks).HasColumnType("varchar(50)");
				builder.Property(p => p.TaskName).HasColumnType("nvarchar(40)");
				builder.Property(p => p.Desc).HasColumnType("nvarchar(100)");
				builder.Property(p => p.Tips).HasColumnType("nvarchar(100)");
				builder.Property(p => p.SaveDesc).HasColumnType("nvarchar(200)");
				builder.Property(p => p.CategoryDay).HasColumnType("int");
				builder.Property(p => p.CategoryFixed).HasColumnType("int");
				builder.Property(p => p.Platform).HasColumnType("nvarchar(20)");
				builder.Property(p => p.Beans).HasColumnType("int");
				builder.Property(p => p.FirstBeans).HasColumnType("int");
				builder.Property(p => p.UpperNumber).HasColumnType("int");
				builder.Property(p => p.UpperBeans).HasColumnType("int");
				builder.Property(p => p.Seconds).HasColumnType("int");
				builder.Property(p => p.UpperSeconds).HasColumnType("int");
				builder.Property(p => p.BeansText).HasColumnType("nvarchar(40)");
				builder.Property(p => p.IsRandom).HasColumnType("int");
				builder.Property(p => p.RandomBefore).HasColumnType("int");
				builder.Property(p => p.RandomAfter).HasColumnType("int");
				builder.Property(p => p.IsSubset).HasColumnType("int");
				builder.Property(p => p.IsDisplay).HasColumnType("int");
				builder.Property(p => p.IsTime).HasColumnType("int");
				builder.Property(p => p.BeforeTime).HasColumnType("datetime");
				builder.Property(p => p.AfterTime).HasColumnType("datetime");
				builder.Property(p => p.EffectiveDay).HasColumnType("int");
				builder.Property(p => p.IconType).HasColumnType("int");
				builder.Property(p => p.JumpType).HasColumnType("int");
				builder.Property(p => p.JumpTitle).HasColumnType("nvarchar(200)");
				builder.Property(p => p.JumpUrl).HasColumnType("nvarchar(510)");
				builder.Property(p => p.Sequence).HasColumnType("int");
				builder.Property(p => p.IsEnable).HasColumnType("int");
				builder.Property(p => p.Remarks).HasColumnType("nvarchar(510)");
				builder.Property(p => p.CreateBy).HasColumnType("int");
				builder.Property(p => p.CreateTime).HasColumnType("datetime");
			
			});
		}
	}
}
