using Auto.ElasticServices.Entities;
using Auto.Entities.Modals;
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
            modelBuilder.Query<WebNews>().ToView("WebNews");


            #endregion
        }
    }
}
