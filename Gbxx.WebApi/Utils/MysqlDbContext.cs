using Auto.Dto.ElasticDoc;
using Microsoft.EntityFrameworkCore;

namespace Gbxx.WebApi.Utils {
    public class MysqlDbContext : DbContext {
        public MysqlDbContext(DbContextOptions<MysqlDbContext> options) : base(options) {
        }
        /// <summary>
        /// EF配置
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            base.OnConfiguring(optionsBuilder);
        }
        /// <summary>
        /// 实体配置
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            #region Generated Configuration
            //modelBuilder.Query<NewsDoc>().ToView("NewsDoc");
            modelBuilder.Entity<NewsDoc>().HasKey(e => e.NewsId);
            #endregion
        }
        public DbSet<NewsDoc> NewsDoc { get; set; }
    }
}
