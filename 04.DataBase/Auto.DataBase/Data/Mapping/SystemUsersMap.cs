using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Mapping
{
    /// <summary>
    /// Allows configuration for an entity type <see cref="Auto.EFCore.Entities.SystemUsers" />
    /// </summary>
    public partial class SystemUsersMap
        : IEntityTypeConfiguration<Auto.EFCore.Entities.SystemUsers>
    {
        /// <summary>
        /// Configures the entity of type <see cref="Auto.EFCore.Entities.SystemUsers" />
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity type.</param>
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Auto.EFCore.Entities.SystemUsers> builder)
        {
            #region Generated Configure
            // table
            builder.ToTable("System_Users", "dbo");

            // key
            builder.HasKey(t => t.UsersId);

            // properties
            builder.Property(t => t.UsersId)
                .IsRequired()
                .HasColumnName("UsersId")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

            builder.Property(t => t.UsersName)
                .HasColumnName("UsersName")
                .HasColumnType("nvarchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.LoginName)
                .HasColumnName("LoginName")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Password)
                .HasColumnName("Password")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.MobilePhone)
                .HasColumnName("MobilePhone")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.Email)
                .HasColumnName("Email")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(t => t.LoginIp)
                .HasColumnName("LoginIp")
                .HasColumnType("varchar(20)")
                .HasMaxLength(20);

            builder.Property(t => t.LoginTime)
                .HasColumnName("LoginTime")
                .HasColumnType("datetime");

            builder.Property(t => t.IsEnable)
                .HasColumnName("IsEnable")
                .HasColumnType("int");

            builder.Property(t => t.Remarks)
                .HasColumnName("Remarks")
                .HasColumnType("nvarchar(255)")
                .HasMaxLength(255);

            builder.Property(t => t.CreateBy)
                .HasColumnName("CreateBy")
                .HasColumnType("int");

            builder.Property(t => t.CreateTime)
                .HasColumnName("CreateTime")
                .HasColumnType("datetime");

            // relationships
            #endregion
        }

        #region Generated Constants
        public struct Table
        {
            /// <summary>Table Schema name constant for entity <see cref="Auto.EFCore.Entities.SystemUsers" /></summary>
            public const string Schema = "dbo";
            /// <summary>Table Name constant for entity <see cref="Auto.EFCore.Entities.SystemUsers" /></summary>
            public const string Name = "System_Users";
        }

        public struct Columns
        {
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemUsers.UsersId" /></summary>
            public const string UsersId = "UsersId";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemUsers.UsersName" /></summary>
            public const string UsersName = "UsersName";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemUsers.LoginName" /></summary>
            public const string LoginName = "LoginName";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemUsers.Password" /></summary>
            public const string Password = "Password";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemUsers.MobilePhone" /></summary>
            public const string MobilePhone = "MobilePhone";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemUsers.Email" /></summary>
            public const string Email = "Email";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemUsers.LoginIp" /></summary>
            public const string LoginIp = "LoginIp";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemUsers.LoginTime" /></summary>
            public const string LoginTime = "LoginTime";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemUsers.IsEnable" /></summary>
            public const string IsEnable = "IsEnable";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemUsers.Remarks" /></summary>
            public const string Remarks = "Remarks";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemUsers.CreateBy" /></summary>
            public const string CreateBy = "CreateBy";
            /// <summary>Column Name constant for property <see cref="Auto.EFCore.Entities.SystemUsers.CreateTime" /></summary>
            public const string CreateTime = "CreateTime";
        }
        #endregion
    }
}
