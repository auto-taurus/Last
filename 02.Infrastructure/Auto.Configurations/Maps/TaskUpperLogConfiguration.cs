using Auto.Entities.Modals;
using Microsoft.EntityFrameworkCore;
using System.Composition;

namespace Auto.Configurations.Maps {
    [Export(typeof(IConfigurations))]
    public class TaskUpperLogConfiguration : IConfigurations {
        public void Configure(ModelBuilder modelBuilder) {
            modelBuilder.Entity<TaskUpperLog>(builder => {
                #region Generated Configure
                // table
                builder.ToTable("Task_UpperLog", "dbo");

                // key
                builder.HasKey(t => t.UpperLogId);

                // properties
                builder.Property(t => t.UpperLogId)
                    .IsRequired()
                    .HasColumnName("UpperLogId")
                    .HasColumnType("int")
                    .ValueGeneratedOnAdd();

                builder.Property(t => t.TaskId)
                    .HasColumnName("TaskId")
                    .HasColumnType("int");

                builder.Property(t => t.MemberId)
                    .HasColumnName("MemberId")
                    .HasColumnType("int");

                builder.Property(t => t.NewsId)
                    .HasColumnName("NewsId")
                    .HasColumnType("varchar(50)")
                    .HasMaxLength(50);

                builder.Property(t => t.CreateTime)
                    .HasColumnName("CreateTime")
                    .HasColumnType("datetime");

                // relationships
                builder.HasOne(t => t.TaskInfo)
                    .WithMany(t => t.TaskUpperLogs)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_TASK_UPP_REFERENCE_TASK_INF");

                #endregion
            });
        }
    }
}
