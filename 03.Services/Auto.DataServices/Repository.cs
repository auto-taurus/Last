using Auto.EFCore;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Auto.DataServices {
    public class Repository<TEntity> : IDisposable where TEntity : class, new() {
        protected bool Disposed;
        protected readonly AutoNewsContext _BaseDb;
        public Repository(AutoNewsContext autoNewsContext) {
            _BaseDb = autoNewsContext;
        }
        public virtual void Dispose() {
            if (Disposed)
                return;
            _BaseDb?.Dispose();
            Disposed = true;
        }
        public virtual IQueryable<TEntity> Query() => _BaseDb.Set<TEntity>().AsNoTracking().AsQueryable();
        public virtual IQueryable<TEntity> Querys<T>() => _BaseDb.Set<TEntity>().AsNoTracking().AsQueryable();
        public virtual async Task<Tuple<int, List<TEntity>>> QueryPager<TSort>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TSort>> expression, bool isDesc = false, int pageIndex = 1, int pageSize = 10) {
            var query = this.Query().Where(predicate);
            var count = await query.CountAsync();
            if (isDesc)
                query = query.OrderByDescending<TEntity, TSort>(expression);
            else
                query = query.OrderBy<TEntity, TSort>(expression);
            var result = await query.Paging(pageIndex, pageSize).ToListAsync();
            return new Tuple<int, List<TEntity>>(count, result);
        }
        /// <summary>
        /// 单个实体添加，并调用CommitChanges或CommitChangesAsync保存
        /// </summary>
        /// <param name="entity"></param>
        public virtual async ValueTask<EntityEntry<TEntity>> Add(TEntity entity) {
            return await this._BaseDb.Set<TEntity>().AddAsync(entity);
        }
        /// <summary>
        /// 批量添加实体
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public virtual async Task<bool> BatchAddAsync(List<TEntity> entities) {
            var flag = false;
            try {
                var config = new BulkConfig();
                config.SqlBulkCopyOptions = SqlBulkCopyOptions.FireTriggers;
                await _BaseDb.BulkInsertAsync(entities, config);
                flag = true;
            }
            catch (Exception ex) {
                flag = false;
            }
            return flag;
        }
        /// <summary>
        /// 单个实体更新，并调用CommitChanges或CommitChangesAsync保存
        /// </summary>
        /// <param name="entity">实体</param>
        public virtual void Update(TEntity entity) {
            // Get entity's entry
            var entry = _BaseDb.Entry(entity);
            if (entry.State == EntityState.Detached) {
                // 将实体追加到上下文中，并跟踪实体
                _BaseDb.Set<TEntity>().Attach(entity);
            }
            entry.State = EntityState.Modified;
        }
        /// <summary>
        /// 批量实体更新，并调用CommitChanges或CommitChangesAsync保存
        /// </summary>
        /// <param name="predicate">实体过滤条件</param>
        /// <param name="entity">实体，须实例化后传入</param>
        /// <returns></returns>
        public virtual async Task BatchUpdateAsync(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TEntity>> entity) {
            await this._BaseDb.Set<TEntity>().Where(predicate).BatchUpdateAsync(entity);
        }
        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public virtual async Task BatchUpdate(List<TEntity> entities) {
            await this._BaseDb.BulkUpdateAsync(entities);
        }
        /// <summary>
        /// 单个实体删除，并调用CommitChanges或CommitChangesAsync保存
        /// </summary>
        /// <param name="entity">实体</param>
        public virtual void Remove(TEntity entity) {
            // Get entity's entry
            var entry = _BaseDb.Entry(entity);

            if (entry.State == EntityState.Deleted) {
                // Create set for entity
                var dbSet = _BaseDb.Set<TEntity>();
                // 将实体追加到上下文中，并跟踪实体
                dbSet.Attach(entity);
                dbSet.Remove(entity);
            }
            else {
                // Set state for entity to 'Deleted'
                entry.State = EntityState.Deleted;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public virtual async Task BatchRemove(List<TEntity> entities) {
            await this._BaseDb.BulkDeleteAsync(entities);
        }
        /// <summary>
        /// 批量实体删除，并调用CommitChanges或CommitChangesAsync保存
        /// </summary>
        /// <param name="predicate">实体过滤条件</param>
        /// <returns></returns>
        public virtual async Task BatchRemove(Expression<Func<TEntity, bool>> predicate) {
            await this._BaseDb.Set<TEntity>().Where(predicate).BatchDeleteAsync();
        }
        /// <summary>
        /// 同步提交
        /// </summary>
        /// <returns></returns>
        public int CommitChanges() {
            return _BaseDb.SaveChanges();
        }
        /// <summary>
        /// 异步提交
        /// </summary>
        /// <returns></returns>
        public async Task<int> CommitChangesAsync() {
            return await _BaseDb.SaveChangesAsync();
        }
    }
}
