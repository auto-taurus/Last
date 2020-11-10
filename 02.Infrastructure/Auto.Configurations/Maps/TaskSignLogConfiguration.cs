using Auto.Entities.Modals;
using Microsoft.EntityFrameworkCore;
using System.Composition;

namespace Auto.Configurations.Maps {
    [Export(typeof(IConfigurations))]
    public class TaskSignLogConfiguration : IConfigurations {
        public void Configure(ModelBuilder modelBuilder) {
            modelBuilder.Entity<TaskSignLog>(builder => {
                #region Generated Configure
                // table
                builder.ToTable("Task_SignLog", "dbo");

                // key
                builder.HasKey(t => t.SignLogId);

                // properties
                builder.Property(t => t.SignLogId)
                    .IsRequired()
                    .HasColumnName("SignLogId")
                    .HasColumnType("int")
                    .ValueGeneratedOnAdd();

                builder.Property(t => t.TaskId)
                    .HasColumnName("TaskId")
                    .HasColumnType("int");

                builder.Property(t => t.MemberId)
                    .HasColumnName("MemberId")
                    .HasColumnType("int");

                builder.Property(t => t.SignNumber)
                    .HasColumnName("SignNumber")
                    .HasColumnType("int");

                builder.Property(t => t.CreateTime)
                    .HasColumnName("CreateTime")
                    .HasColumnType("datetime");

                // relationships
                builder.HasOne(t => t.TaskInfo)
                    .WithMany(t => t.TaskSignLogs)
                    .HasForeignKey(d => d.TaskId)
                    .HasConstraintName("FK_TASK_SIG_REFERENCE_TASK_INF");

                #endregion
            });
        }
    }
}
