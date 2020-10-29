using Auto.Entities.Modals;
using Microsoft.EntityFrameworkCore;
using System.Composition;

namespace Auto.Configurations.Maps {
    [Export(typeof(IConfigurations))]
    public class TaskInfoConfiguration : IConfigurations {
        public void Configure(ModelBuilder modelBuilder) {
            modelBuilder.Entity<TaskInfo>(builder => {
                // Set configuration for entity
                builder.ToTable("Task_Info", "dbo");

                // Set key for entity
                builder.HasKey(p => p.TaskId);

                // Set identity for entity (auto increment)
                builder.Property(p => p.TaskId).UseSqlServerIdentityColumn();

                // Set configuration for columns
                builder.Property(p => p.TaskId).HasColumnType("int").IsRequired();
                builder.Property(p => p.TaskCode).HasColumnType("varchar(5)");
                builder.Property(p => p.RelatedTasks).HasColumnType("varchar(50)");
                builder.Property(p => p.TaskName).HasColumnType("nvarchar(40)");
                builder.Property(p => p.Desc).HasColumnType("nvarchar(100)");
                builder.Property(p => p.SaveDesc).HasColumnType("nvarchar(200)");
                builder.Property(p => p.CategoryDay).HasColumnType("int");
                builder.Property(p => p.CategoryFixed).HasColumnType("int");
                builder.Property(p => p.Platform).HasColumnType("nvarchar(100)");
                builder.Property(p => p.Beans).HasColumnType("bigint");
                builder.Property(p => p.BeansText).HasColumnType("nvarchar(40)");
                builder.Property(p => p.IsDisplay).HasColumnType("int");
                builder.Property(p => p.IsEnable).HasColumnType("int");
                builder.Property(p => p.Remarks).HasColumnType("nvarchar(510)");
                builder.Property(p => p.CreateBy).HasColumnType("int");
                builder.Property(p => p.CreateTime).HasColumnType("datetime");

            });
        }
    }
}
