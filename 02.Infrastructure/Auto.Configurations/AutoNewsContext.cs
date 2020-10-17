using Auto.Commons.EfCore;
using Auto.Configurations.Maps;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Reflection;

namespace Auto.Configurations {
    public partial class AutoNewsContext : DbContext {
        public IEntityMapper _EntityMapper { get; }
        public AutoNewsContext(DbContextOptions<AutoNewsContext> options, IEntityMapper entityMapper) : base(options) {
            _EntityMapper = entityMapper;
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
            _EntityMapper.ConfigureEntities(modelBuilder);
            //this.AddEntities(modelBuilder);
            base.OnModelCreating(modelBuilder);
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
