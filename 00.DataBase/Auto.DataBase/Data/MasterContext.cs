using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Master.Data
{
    public partial class MasterContext : DbContext
    {
        public MasterContext(DbContextOptions<MasterContext> options)
            : base(options)
        {
        }

        #region Generated Properties
        public virtual DbSet<Master.Data.Entities.AutoBatchInsertNewsId> AutoBatchInsertNewsIds { get; set; }

        public virtual DbSet<Master.Data.Entities.MemberComment> MemberComments { get; set; }

        public virtual DbSet<Master.Data.Entities.MemberCommentSensitive> MemberCommentSensitives { get; set; }

        public virtual DbSet<Master.Data.Entities.MemberCommentUp> MemberCommentUps { get; set; }

        public virtual DbSet<Master.Data.Entities.MemberFans> MemberFans { get; set; }

        public virtual DbSet<Master.Data.Entities.MemberFavorites> MemberFavorites { get; set; }

        public virtual DbSet<Master.Data.Entities.MemberFollow> MemberFollows { get; set; }

        public virtual DbSet<Master.Data.Entities.MemberFootprint> MemberFootprints { get; set; }

        public virtual DbSet<Master.Data.Entities.MemberIncome> MemberIncomes { get; set; }

        public virtual DbSet<Master.Data.Entities.MemberInfos> MemberInfos { get; set; }

        public virtual DbSet<Master.Data.Entities.MemberLoginLog> MemberLoginLogs { get; set; }

        public virtual DbSet<Master.Data.Entities.MemberMessage> MemberMessages { get; set; }

        public virtual DbSet<Master.Data.Entities.MemberProblem> MemberProblems { get; set; }

        public virtual DbSet<Master.Data.Entities.MemberWithdrawConfig> MemberWithdrawConfigs { get; set; }

        public virtual DbSet<Master.Data.Entities.MemberWithdraw> MemberWithdraws { get; set; }

        public virtual DbSet<Master.Data.Entities.ReportCategoryDayAccess> ReportCategoryDayAccesses { get; set; }

        public virtual DbSet<Master.Data.Entities.ReportCategoryDayClick> ReportCategoryDayClicks { get; set; }

        public virtual DbSet<Master.Data.Entities.ReportNewsDayAccess> ReportNewsDayAccesses { get; set; }

        public virtual DbSet<Master.Data.Entities.ReportNewsDayClick> ReportNewsDayClicks { get; set; }

        public virtual DbSet<Master.Data.Entities.ReportSiteDayAccess> ReportSiteDayAccesses { get; set; }

        public virtual DbSet<Master.Data.Entities.SystemDictionary> SystemDictionaries { get; set; }

        public virtual DbSet<Master.Data.Entities.SystemLogs> SystemLogs { get; set; }

        public virtual DbSet<Master.Data.Entities.SystemMenu> SystemMenus { get; set; }

        public virtual DbSet<Master.Data.Entities.SystemRoleDictionary> SystemRoleDictionaries { get; set; }

        public virtual DbSet<Master.Data.Entities.SystemRoleInMenu> SystemRoleInMenus { get; set; }

        public virtual DbSet<Master.Data.Entities.SystemRole> SystemRoles { get; set; }

        public virtual DbSet<Master.Data.Entities.SystemUsers> SystemUsers { get; set; }

        public virtual DbSet<Master.Data.Entities.SystemUsersDictionary> SystemUsersDictionaries { get; set; }

        public virtual DbSet<Master.Data.Entities.SystemUsersInMenu> SystemUsersInMenus { get; set; }

        public virtual DbSet<Master.Data.Entities.SystemUsersInRole> SystemUsersInRoles { get; set; }

        public virtual DbSet<Master.Data.Entities.SystemUsersRefreshToken> SystemUsersRefreshTokens { get; set; }

        public virtual DbSet<Master.Data.Entities.TaskInfo> TaskInfos { get; set; }

        public virtual DbSet<Master.Data.Entities.WebCategory> WebCategories { get; set; }

        public virtual DbSet<Master.Data.Entities.WebChannel> WebChannels { get; set; }

        public virtual DbSet<Master.Data.Entities.WebNews> WebNews { get; set; }

        public virtual DbSet<Master.Data.Entities.WebNewsOperateLogs> WebNewsOperateLogs { get; set; }

        public virtual DbSet<Master.Data.Entities.WebNewsSensitive> WebNewsSensitives { get; set; }

        public virtual DbSet<Master.Data.Entities.WebSensitive> WebSensitives { get; set; }

        public virtual DbSet<Master.Data.Entities.WebSite> WebSites { get; set; }

        public virtual DbSet<Master.Data.Entities.WebSource> WebSources { get; set; }

        public virtual DbSet<Master.Data.Entities.WebSpecial> WebSpecials { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Generated Configuration
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.AutoBatchInsertNewsIdMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.MemberCommentMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.MemberCommentSensitiveMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.MemberCommentUpMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.MemberFansMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.MemberFavoritesMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.MemberFollowMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.MemberFootprintMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.MemberIncomeMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.MemberInfosMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.MemberLoginLogMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.MemberMessageMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.MemberProblemMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.MemberWithdrawConfigMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.MemberWithdrawMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.ReportCategoryDayAccessMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.ReportCategoryDayClickMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.ReportNewsDayAccessMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.ReportNewsDayClickMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.ReportSiteDayAccessMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.SystemDictionaryMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.SystemLogsMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.SystemMenuMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.SystemRoleDictionaryMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.SystemRoleInMenuMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.SystemRoleMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.SystemUsersDictionaryMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.SystemUsersInMenuMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.SystemUsersInRoleMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.SystemUsersMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.SystemUsersRefreshTokenMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.TaskInfoMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.WebCategoryMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.WebChannelMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.WebNewsMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.WebNewsOperateLogsMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.WebNewsSensitiveMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.WebSensitiveMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.WebSiteMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.WebSourceMap());
            modelBuilder.ApplyConfiguration(new Master.Data.Mapping.WebSpecialMap());
            #endregion
        }
    }
}
