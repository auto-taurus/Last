using Auto.Commons.EfCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;
using System;
using System.Linq;
using System.Reflection;

namespace Auto.Configurations {
    public partial class NewsContext : DbContext {
        public static readonly LoggerFactory MyLoggerFactory = new LoggerFactory(new[] {
            new DebugLoggerProvider()
        });
        private IEntityMapper _IEntityMapper { get; }
        public NewsContext(DbContextOptions<NewsContext> options,
                           IEntityMapper entityMapper) : base(options) {
            _IEntityMapper = entityMapper;
        }
        /// <summary>
        /// EF配置
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLoggerFactory(MyLoggerFactory);
        }
        /// <summary>
        /// 实体配置
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            #region Generated Configuration
            _IEntityMapper.ConfigureEntities(modelBuilder);
            base.OnModelCreating(modelBuilder);

            //this.AddEntities(modelBuilder);
            //this.AddMappingConfigures(modelBuilder);
            //this.AddViewsConfigures(modelBuilder);
            #endregion
        }
        /// <summary>
        /// 加载实体
        /// </summary>
        /// <param name="modelBuilder"></param>
        private void AddEntities(ModelBuilder modelBuilder) {
            var entityTypes = Assembly.GetExecutingAssembly().GetTypes().Where(q => q.GetInterface(typeof(IEntity).FullName) != null);
            foreach (var type in entityTypes) {
                modelBuilder.Model.GetOrAddEntityType(type);
            }
        }
        /// <summary>
        /// 实体批量注册
        /// </summary>
        /// <param name="modelBuilder"></param>
        private void AddMappingConfigures(ModelBuilder modelBuilder) {
            var typesToRegisterEntityType = Assembly.GetExecutingAssembly().GetTypes().Where(q => q.GetInterface(typeof(IEntityTypeConfiguration<>).FullName) != null);
            foreach (var type in typesToRegisterEntityType) {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.ApplyConfiguration(configurationInstance);
            }
        }
        /// <summary>
        /// 查询或视图批量注册
        /// </summary>
        /// <param name="modelBuilder"></param>
        private void AddViewsConfigures(ModelBuilder modelBuilder) {
            var typesToRegisterEntityTypeQueryType = Assembly.GetExecutingAssembly().GetTypes().Where(q => q.GetInterface(typeof(IQueryTypeConfiguration<>).FullName) != null);
            foreach (var type in typesToRegisterEntityTypeQueryType) {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.ApplyConfiguration(configurationInstance);
            }
        }
    }
}
