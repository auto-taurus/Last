using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Company.AutoNews.Data
{
    public partial class AutoNewsContext : DbContext
    {
        public AutoNewsContext(DbContextOptions<AutoNewsContext> options)
            : base(options)
        {
        }

        #region Generated Properties
        public virtual DbSet<Auto.EFCore.Entities.AutoBatchInsertNewsId> AutoBatchInsertNewsIds { get; set; }

        public virtual DbSet<Auto.EFCore.Entities.ReportCategoryDayAccess> ReportCategoryDayAccesses { get; set; }

        public virtual DbSet<Auto.EFCore.Entities.ReportCategoryDayClick> ReportCategoryDayClicks { get; set; }

        public virtual DbSet<Auto.EFCore.Entities.ReportNewsDayAccess> ReportNewsDayAccesses { get; set; }

        public virtual DbSet<Auto.EFCore.Entities.ReportNewsDayClick> ReportNewsDayClicks { get; set; }

        public virtual DbSet<Auto.EFCore.Entities.ReportSiteDayAccess> ReportSiteDayAccesses { get; set; }

        public virtual DbSet<Auto.EFCore.Entities.SystemDictionary> SystemDictionaries { get; set; }

        public virtual DbSet<Auto.EFCore.Entities.SystemLogs> SystemLogs { get; set; }

        public virtual DbSet<Auto.EFCore.Entities.SystemMenu> SystemMenus { get; set; }

        public virtual DbSet<Auto.EFCore.Entities.SystemRoleInDictionary> SystemRoleInDictionaries { get; set; }

        public virtual DbSet<Auto.EFCore.Entities.SystemRoleInMenu> SystemRoleInMenus { get; set; }

        public virtual DbSet<Auto.EFCore.Entities.SystemRole> SystemRoles { get; set; }

        public virtual DbSet<Auto.EFCore.Entities.SystemUsers> SystemUsers { get; set; }

        public virtual DbSet<Auto.EFCore.Entities.SystemUsersInDictionary> SystemUsersInDictionaries { get; set; }

        public virtual DbSet<Auto.EFCore.Entities.SystemUsersInMenu> SystemUsersInMenus { get; set; }

        public virtual DbSet<Auto.EFCore.Entities.SystemUsersInRole> SystemUsersInRoles { get; set; }

        public virtual DbSet<Auto.EFCore.Entities.SystemUsersRefreshToken> SystemUsersRefreshTokens { get; set; }

        public virtual DbSet<Auto.EFCore.Entities.WebCategory> WebCategories { get; set; }

        public virtual DbSet<Auto.EFCore.Entities.WebChannel> WebChannels { get; set; }

        public virtual DbSet<Auto.EFCore.Entities.WebNews> WebNews { get; set; }

        public virtual DbSet<Auto.EFCore.Entities.WebNewsOperateLogs> WebNewsOperateLogs { get; set; }

        public virtual DbSet<Auto.EFCore.Entities.WebNewsSensitive> WebNewsSensitives { get; set; }

        public virtual DbSet<Auto.EFCore.Entities.WebSensitive> WebSensitives { get; set; }

        public virtual DbSet<Auto.EFCore.Entities.WebSite> WebSites { get; set; }

        public virtual DbSet<Auto.EFCore.Entities.WebSpecial> WebSpecials { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Generated Configuration
            modelBuilder.ApplyConfiguration(new Company.AutoNews.Data.Mapping.AutoBatchInsertNewsIdMap());
            modelBuilder.ApplyConfiguration(new Company.AutoNews.Data.Mapping.ReportCategoryDayAccessMap());
            modelBuilder.ApplyConfiguration(new Company.AutoNews.Data.Mapping.ReportCategoryDayClickMap());
            modelBuilder.ApplyConfiguration(new Company.AutoNews.Data.Mapping.ReportNewsDayAccessMap());
            modelBuilder.ApplyConfiguration(new Company.AutoNews.Data.Mapping.ReportNewsDayClickMap());
            modelBuilder.ApplyConfiguration(new Company.AutoNews.Data.Mapping.ReportSiteDayAccessMap());
            modelBuilder.ApplyConfiguration(new Company.AutoNews.Data.Mapping.SystemDictionaryMap());
            modelBuilder.ApplyConfiguration(new Company.AutoNews.Data.Mapping.SystemLogsMap());
            modelBuilder.ApplyConfiguration(new Company.AutoNews.Data.Mapping.SystemMenuMap());
            modelBuilder.ApplyConfiguration(new Company.AutoNews.Data.Mapping.SystemRoleInDictionaryMap());
            modelBuilder.ApplyConfiguration(new Company.AutoNews.Data.Mapping.SystemRoleInMenuMap());
            modelBuilder.ApplyConfiguration(new Company.AutoNews.Data.Mapping.SystemRoleMap());
            modelBuilder.ApplyConfiguration(new Company.AutoNews.Data.Mapping.SystemUsersInDictionaryMap());
            modelBuilder.ApplyConfiguration(new Company.AutoNews.Data.Mapping.SystemUsersInMenuMap());
            modelBuilder.ApplyConfiguration(new Company.AutoNews.Data.Mapping.SystemUsersInRoleMap());
            modelBuilder.ApplyConfiguration(new Company.AutoNews.Data.Mapping.SystemUsersMap());
            modelBuilder.ApplyConfiguration(new Company.AutoNews.Data.Mapping.SystemUsersRefreshTokenMap());
            modelBuilder.ApplyConfiguration(new Company.AutoNews.Data.Mapping.WebCategoryMap());
            modelBuilder.ApplyConfiguration(new Company.AutoNews.Data.Mapping.WebChannelMap());
            modelBuilder.ApplyConfiguration(new Company.AutoNews.Data.Mapping.WebNewsMap());
            modelBuilder.ApplyConfiguration(new Company.AutoNews.Data.Mapping.WebNewsOperateLogsMap());
            modelBuilder.ApplyConfiguration(new Company.AutoNews.Data.Mapping.WebNewsSensitiveMap());
            modelBuilder.ApplyConfiguration(new Company.AutoNews.Data.Mapping.WebSensitiveMap());
            modelBuilder.ApplyConfiguration(new Company.AutoNews.Data.Mapping.WebSiteMap());
            modelBuilder.ApplyConfiguration(new Company.AutoNews.Data.Mapping.WebSpecialMap());
            #endregion
        }
    }
}
