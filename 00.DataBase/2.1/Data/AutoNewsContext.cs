using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AutoNews.Data
{
    public partial class AutoNewsContext : DbContext
    {
        public AutoNewsContext(DbContextOptions<AutoNewsContext> options)
            : base(options)
        {
        }

        #region Generated Properties
        public virtual DbSet<AutoNews.Data.Entities.AutoBatchInsertNewsId> AutoBatchInsertNewsIds { get; set; }

        public virtual DbSet<AutoNews.Data.Entities.ReportCategoryDayAccess> ReportCategoryDayAccesses { get; set; }

        public virtual DbSet<AutoNews.Data.Entities.ReportCategoryDayClick> ReportCategoryDayClicks { get; set; }

        public virtual DbSet<AutoNews.Data.Entities.ReportNewsDayAccess> ReportNewsDayAccesses { get; set; }

        public virtual DbSet<AutoNews.Data.Entities.ReportNewsDayClick> ReportNewsDayClicks { get; set; }

        public virtual DbSet<AutoNews.Data.Entities.ReportSiteDayAccess> ReportSiteDayAccesses { get; set; }

        public virtual DbSet<AutoNews.Data.Entities.SystemDictionary> SystemDictionaries { get; set; }

        public virtual DbSet<AutoNews.Data.Entities.SystemLogs> SystemLogs { get; set; }

        public virtual DbSet<AutoNews.Data.Entities.SystemMenu> SystemMenus { get; set; }

        public virtual DbSet<AutoNews.Data.Entities.SystemRoleDictionary> SystemRoleDictionaries { get; set; }

        public virtual DbSet<AutoNews.Data.Entities.SystemRoleInMenu> SystemRoleInMenus { get; set; }

        public virtual DbSet<AutoNews.Data.Entities.SystemRole> SystemRoles { get; set; }

        public virtual DbSet<AutoNews.Data.Entities.SystemUsers> SystemUsers { get; set; }

        public virtual DbSet<AutoNews.Data.Entities.SystemUsersDictionary> SystemUsersDictionaries { get; set; }

        public virtual DbSet<AutoNews.Data.Entities.SystemUsersInMenu> SystemUsersInMenus { get; set; }

        public virtual DbSet<AutoNews.Data.Entities.SystemUsersInRole> SystemUsersInRoles { get; set; }

        public virtual DbSet<AutoNews.Data.Entities.SystemUsersRefreshToken> SystemUsersRefreshTokens { get; set; }

        public virtual DbSet<AutoNews.Data.Entities.WebCategory> WebCategories { get; set; }

        public virtual DbSet<AutoNews.Data.Entities.WebChannel> WebChannels { get; set; }

        public virtual DbSet<AutoNews.Data.Entities.WebNews> WebNews { get; set; }

        public virtual DbSet<AutoNews.Data.Entities.WebNewsOperateLogs> WebNewsOperateLogs { get; set; }

        public virtual DbSet<AutoNews.Data.Entities.WebNewsSensitive> WebNewsSensitives { get; set; }

        public virtual DbSet<AutoNews.Data.Entities.WebSensitive> WebSensitives { get; set; }

        public virtual DbSet<AutoNews.Data.Entities.WebSite> WebSites { get; set; }

        public virtual DbSet<AutoNews.Data.Entities.WebSpecial> WebSpecials { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Generated Configuration
            modelBuilder.ApplyConfiguration(new AutoNews.Data.Mapping.AutoBatchInsertNewsIdMap());
            modelBuilder.ApplyConfiguration(new AutoNews.Data.Mapping.ReportCategoryDayAccessMap());
            modelBuilder.ApplyConfiguration(new AutoNews.Data.Mapping.ReportCategoryDayClickMap());
            modelBuilder.ApplyConfiguration(new AutoNews.Data.Mapping.ReportNewsDayAccessMap());
            modelBuilder.ApplyConfiguration(new AutoNews.Data.Mapping.ReportNewsDayClickMap());
            modelBuilder.ApplyConfiguration(new AutoNews.Data.Mapping.ReportSiteDayAccessMap());
            modelBuilder.ApplyConfiguration(new AutoNews.Data.Mapping.SystemDictionaryMap());
            modelBuilder.ApplyConfiguration(new AutoNews.Data.Mapping.SystemLogsMap());
            modelBuilder.ApplyConfiguration(new AutoNews.Data.Mapping.SystemMenuMap());
            modelBuilder.ApplyConfiguration(new AutoNews.Data.Mapping.SystemRoleDictionaryMap());
            modelBuilder.ApplyConfiguration(new AutoNews.Data.Mapping.SystemRoleInMenuMap());
            modelBuilder.ApplyConfiguration(new AutoNews.Data.Mapping.SystemRoleMap());
            modelBuilder.ApplyConfiguration(new AutoNews.Data.Mapping.SystemUsersDictionaryMap());
            modelBuilder.ApplyConfiguration(new AutoNews.Data.Mapping.SystemUsersInMenuMap());
            modelBuilder.ApplyConfiguration(new AutoNews.Data.Mapping.SystemUsersInRoleMap());
            modelBuilder.ApplyConfiguration(new AutoNews.Data.Mapping.SystemUsersMap());
            modelBuilder.ApplyConfiguration(new AutoNews.Data.Mapping.SystemUsersRefreshTokenMap());
            modelBuilder.ApplyConfiguration(new AutoNews.Data.Mapping.WebCategoryMap());
            modelBuilder.ApplyConfiguration(new AutoNews.Data.Mapping.WebChannelMap());
            modelBuilder.ApplyConfiguration(new AutoNews.Data.Mapping.WebNewsMap());
            modelBuilder.ApplyConfiguration(new AutoNews.Data.Mapping.WebNewsOperateLogsMap());
            modelBuilder.ApplyConfiguration(new AutoNews.Data.Mapping.WebNewsSensitiveMap());
            modelBuilder.ApplyConfiguration(new AutoNews.Data.Mapping.WebSensitiveMap());
            modelBuilder.ApplyConfiguration(new AutoNews.Data.Mapping.WebSiteMap());
            modelBuilder.ApplyConfiguration(new AutoNews.Data.Mapping.WebSpecialMap());
            #endregion
        }
    }
}
