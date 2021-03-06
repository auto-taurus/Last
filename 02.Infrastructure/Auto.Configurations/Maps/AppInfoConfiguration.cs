using System.Composition;
using Microsoft.EntityFrameworkCore;
using Auto.Entities.Modals;

namespace Auto.Configurations.Maps {
    [Export(typeof(IConfigurations))]
    public class AppInfoConfiguration : IConfigurations {
        public void Configure(ModelBuilder modelBuilder) {
            modelBuilder.Entity<AppInfo>(builder => {
                #region Generated Configure
                // table
                builder.ToTable("App_Info", "dbo");

                // key
                builder.HasKey(t => t.AppId);

                // properties
                builder.Property(t => t.AppId)
                    .IsRequired()
                    .HasColumnName("AppId")
                    .HasColumnType("int")
                    .ValueGeneratedOnAdd();

                builder.Property(t => t.Code)
                    .HasColumnName("Code")
                    .HasColumnType("varchar(10)")
                    .HasMaxLength(10);

                builder.Property(t => t.LogoUrl)
                    .HasColumnName("LogoUrl")
                    .HasColumnType("nvarchar(255)")
                    .HasMaxLength(255);

                builder.Property(t => t.PackageName)
                    .HasColumnName("PackageName")
                    .HasColumnType("nvarchar(50)")
                    .HasMaxLength(50);

                builder.Property(t => t.AppName)
                    .HasColumnName("AppName")
                    .HasColumnType("nvarchar(50)")
                    .HasMaxLength(50);

                builder.Property(t => t.Version)
                    .HasColumnName("Version")
                     .HasColumnType("nvarchar(50)")
                    .HasMaxLength(50);

                builder.Property(t => t.VersionCode)
                    .HasColumnName("VersionCode")
                     .HasColumnType("int");

                builder.Property(t => t.VersionSize)
                    .IsRequired()
                    .HasColumnName("VersionSize")
                    .HasColumnType("decimal(18, 2)");

                builder.Property(t => t.AppUrl)
                    .HasColumnName("AppUrl")
                    .HasColumnType("nvarchar(255)")
                    .HasMaxLength(255);

                builder.Property(t => t.Introduction)
                    .HasColumnName("Introduction")
                    .HasColumnType("nvarchar(500)")
                    .HasMaxLength(500);

                builder.Property(t => t.UpdateLog)
                    .HasColumnName("UpdateLog")
                    .HasColumnType("nvarchar(500)")
                    .HasMaxLength(500);

                builder.Property(t => t.IsMandatory)
                    .HasColumnName("IsMandatory")
                    .HasColumnType("int");

                builder.Property(t => t.Status)
                    .HasColumnName("Status")
                    .HasColumnType("int");

                builder.Property(t => t.IsEnable)
                    .HasColumnName("IsEnable")
                    .HasColumnType("int");

                builder.Property(t => t.Remarks)
                    .HasColumnName("Remarks")
                    .HasColumnType("nvarchar(255)")
                    .HasMaxLength(255);

                builder.Property(t => t.CreateTime)
                    .HasColumnName("CreateTime")
                    .HasColumnType("datetime");

                // relationships
                #endregion
            });
        }
    }
}
