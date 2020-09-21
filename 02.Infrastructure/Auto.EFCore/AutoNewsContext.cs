using Auto.EFCore.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Auto.EFCore {
    public partial class AutoNewsContext : DbContext {
        public AutoNewsContext(DbContextOptions<AutoNewsContext> options) : base(options) {

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
            this.AddEntities(modelBuilder);
            base.OnModelCreating(modelBuilder);
            this.AddMappingConfigures(modelBuilder);
            this.AddViewsConfigures(modelBuilder);
            #endregion
        }
        /// <summary>
        /// 加载实体
        /// </summary>
        /// <param name="modelBuilder"></param>
        private void AddEntities(ModelBuilder modelBuilder) {
            var entityTypes = Assembly.GetEntryAssembly()
                                      .GetTypes()
                                      .Where(type => typeof(IEntity).IsAssignableFrom(type));
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
