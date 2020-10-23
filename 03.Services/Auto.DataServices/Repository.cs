using Auto.Configurations;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Auto.DataServices {
    public class Repository<TEntity> : IDisposable where TEntity : class, new() {
        protected bool Disposed;
        protected readonly NewsContext _BaseDb;
        public Repository(NewsContext newsContext) {
            _BaseDb = newsContext;
        }
        public virtual void Dispose() {
            if (Disposed)
                return;
            _BaseDb?.Dispose();
            Disposed = true;
        }
        /// <summary>
        /// 检查数据是否存在
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public virtual async Task<bool> IsExistAsync(Expression<Func<TEntity, bool>> predicate) {
            return await this._BaseDb.Set<TEntity>().AnyAsync(predicate);
        }
        /// <summary>
        /// 获取单个实体
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public virtual async Task<TEntity> SingleAsync(Expression<Func<TEntity, bool>> predicate)
            => await _BaseDb.Set<TEntity>().AsNoTracking().SingleOrDefaultAsync(predicate);
        /// <summary>
        /// 自定义条件过滤、排序、分页，请使用此方法（不跟踪查询）
        /// 根据指定条件获取单个实体
        /// 根据指定条件获取列表
        /// </summary>
        /// <returns>返回查询IQueryable</returns>
        public virtual IQueryable<TEntity> Query()
            => _BaseDb.Set<TEntity>().AsNoTracking().AsQueryable();
        /// <summary>
        /// 根据过滤条件获取列表
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public virtual IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> predicate)
            => this.Query().Where(predicate);
        /// <summary>
        /// 根据过滤条件获取列表,并进行排序
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="expression"></param>
        /// <param name="isDesc"></param>
        /// <returns></returns>
        public virtual IQueryable<TEntity> Query<TSort>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TSort>> expression, bool isDesc = false) {
            var query = this.Query().Where(predicate);
            if (isDesc)
                query = query.OrderByDescending<TEntity, TSort>(expression);
            else
                query = query.OrderBy<TEntity, TSort>(expression);
            return query;
        }
        /// <summary>
        /// 查询分页排序
        /// </summary>
        /// <typeparam name="TSort">排序字段</typeparam>
        /// <param name="predicate">过滤条件</param>
        /// <param name="expression">排序字段</param>
        /// <param name="isDesc">是否倒序</param>
        /// <param name="pageIndex">当前页</param>
        /// <param name="pageSize">页大小</param>
        /// <returns></returns>
        public virtual async Task<Tuple<int, IList<TEntity>>> QueryPager<TSort>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TSort>> expression, bool isDesc = false, int pageIndex = 1, int pageSize = 10) where TSort : class {
            var query = this.Query().Where(predicate);
            var count = await query.CountAsync();
            if (isDesc)
                query = query.OrderByDescending<TEntity, TSort>(expression);
            else
                query = query.OrderBy<TEntity, TSort>(expression);
            var result = await query.ToPager(pageIndex, pageSize).ToListAsync();
            return new Tuple<int, IList<TEntity>>(count, result);
        }
        /// <summary>
        /// 单个实体添加，需调用CommitChanges获SaveChangesAsync保存
        /// </summary>
        /// <param name="entity"></param>
        public virtual EntityEntry<TEntity> Add(TEntity entity) {
            return this._BaseDb.Set<TEntity>().Add(entity);
        }
        /// <summary>
        /// 单个实体添加，需调用CommitChanges获SaveChangesAsync保存
        /// </summary>
        /// <param name="entity"></param>
        public virtual async ValueTask<EntityEntry<TEntity>> AddAsync(TEntity entity) {
            return await this._BaseDb.Set<TEntity>().AddAsync(entity);
        }
        /// <summary>
        /// 批量添加实体
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public virtual async Task<bool> BatchAddAsync(IList<TEntity> entities) {
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
        /// 单个实体更新，需调用CommitChanges获SaveChangesAsync保存
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
        /// 批量实体更新
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public virtual async Task<bool> BatchUpdateAsync(IList<TEntity> entities) {
            var flag = false;
            try {
                await this._BaseDb.BulkUpdateAsync(entities);
                flag = true;
            }
            catch (Exception ex) {
                flag = false;
            }
            return flag;
        }
        /// <summary>
        /// 批量实体更新
        /// </summary>
        /// <param name="predicate">实体过滤条件</param>
        /// <param name="entity">更新字段</param>
        /// <returns></returns>
        public virtual async Task<bool> BatchUpdateAsync(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TEntity>> entity) {
            var flag = false;
            try {
                await this._BaseDb.Set<TEntity>().Where(predicate).BatchUpdateAsync(entity);
                flag = true;
            }
            catch (Exception ex) {
                flag = false;
            }
            return flag;
        }
        /// <summary>
        /// 单个实体删除，需调用CommitChanges获SaveChangesAsync保存
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
        /// 批量实体删除
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public virtual async Task<bool> BatchRemoveAsync(IList<TEntity> entities) {
            var flag = false;
            try {
                await this._BaseDb.BulkDeleteAsync(entities);
                flag = true;
            }
            catch (Exception ex) {

                flag = false;
            }
            return flag;
        }
        /// <summary>
        /// 批量实体删除
        /// </summary>
        /// <param name="predicate">实体过滤条件</param>
        /// <returns></returns>
        public virtual async Task<bool> BatchRemoveAsync(Expression<Func<TEntity, bool>> predicate) {
            var flag = false;
            try {
                await this._BaseDb.Set<TEntity>().Where(predicate).BatchDeleteAsync();
                flag = true;
            }
            catch (Exception ex) {

                flag = false;
            }
            return flag;
        }
        //public IDbContextTransaction Begin() {
        //    return _BaseDb.Database.BeginTransaction();
        //}

        //public async Task<IDbContextTransaction> BeginAsync() {
        //    return await _BaseDb.Database.BeginTransactionAsync();
        //}

        //public void Commit() {
        //    _BaseDb.Database.CommitTransaction();
        //}

        //public void Rollback() {
        //    _BaseDb.Database.RollbackTransaction();
        //}

        /// <summary>
        /// 同步提交
        /// </summary>
        /// <returns></returns>
        public int SaveChanges() {
            return _BaseDb.SaveChanges();
        }
        /// <summary>
        /// 异步提交
        /// </summary>
        /// <returns></returns>
        public async Task<int> SaveChangesAsync() {
            return await _BaseDb.SaveChangesAsync();
        }
    }
}
