using Auto.Entities.Modals;
using Microsoft.EntityFrameworkCore;
using System.Composition;

namespace Auto.Configurations.Maps {
    [Export(typeof(IConfigurations))]
    public class TaskNoviceLogConfiguration : IConfigurations {
        public void Configure(ModelBuilder modelBuilder) {
            modelBuilder.Entity<TaskNoviceLog>(builder => {
                #region Generated Configure
                // table
                builder.ToTable("Task_NoviceLog", "dbo");

                // key
                builder.HasKey(t => t.NoviceLogId);

                // properties
                builder.Property(t => t.NoviceLogId)
                    .IsRequired()
                    .HasColumnName("NoviceLogId")
                    .HasColumnType("int")
                    .ValueGeneratedOnAdd();

                builder.Property(t => t.TaskId)
                    .HasColumnName("TaskId")
                    .HasColumnType("int");

                builder.Property(t => t.MemberId)
                    .HasColumnName("MemberId")
                    .HasColumnType("int");

                builder.Property(t => t.CategoryDay)
                    .HasColumnName("CategoryDay")
                    .HasColumnType("int");

                builder.Property(t => t.CategoryFixed)
                    .HasColumnName("CategoryFixed")
                    .HasColumnType("int");

                builder.Property(t => t.IsEnable)
                    .HasColumnName("IsEnable")
                    .HasColumnType("int");

                // relationships
                #endregion
            });
        }
    }
}
