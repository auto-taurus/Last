using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Auto.DataServices {

    public interface IRepository<TEntity> : IDisposable where TEntity : class {
        /// <summary>
        /// 检查数据是否存在
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<bool> IsExistAsync(Expression<Func<TEntity, bool>> predicate);
        /// <summary>
        /// 获取单个实体
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<TEntity> SingleAsync(Expression<Func<TEntity, bool>> predicate);
        /// <summary>
        /// 自定义条件过滤、排序、分页，请使用此方法
        /// 根据指定条件获取单个实体
        /// 根据指定条件获取列表
        /// </summary>
        /// <returns>返回查询IQueryable</returns>
        IQueryable<TEntity> Query();
        /// <summary>
        /// 根据过滤条件获取列表
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> predicate);
        /// <summary>
        /// 根据过滤条件获取列表,并进行排序
        /// </summary>
        /// <typeparam name="TSort"></typeparam>
        /// <param name="predicate"></param>
        /// <param name="expression"></param>
        /// <param name="isDesc"></param>
        /// <returns></returns>
        IQueryable<TEntity> Query<TSort>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TSort>> expression, bool isDesc = false);
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
        Task<Tuple<int, IList<TEntity>>> QueryPager<TSort>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TSort>> expression, bool isDesc = false, int pageIndex = 1, int pageSize = 10) where TSort : class;
        /// <summary>
        /// 单个实体添加，需调用CommitChanges获SaveChangesAsync保存
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        EntityEntry<TEntity> Add(TEntity entity);
        /// <summary>
        /// 单个实体添加，需调用CommitChanges获SaveChangesAsync保存
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        ValueTask<EntityEntry<TEntity>> AddAsync(TEntity entity);
        /// <summary>
        /// 批量添加实体
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        Task<bool> BatchAddAsync(IList<TEntity> entities);
        /// <summary>
        /// 单个实体更新，需调用CommitChanges获SaveChangesAsync保存
        /// </summary>
        /// <param name="entity"></param>
        void Update(TEntity entity);
        /// <summary>
        /// 批量实体更新
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        Task<bool> BatchUpdateAsync(IList<TEntity> entities);
        /// <summary>
        /// 批量实体更新
        /// </summary>
        /// <param name="predicate">过滤条件</param>
        /// <param name="entity">更新字段</param>
        /// <returns></returns>
        Task<bool> BatchUpdateAsync(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TEntity>> entity);
        /// <summary>
        /// 单个实体删除，需调用CommitChanges获SaveChangesAsync保存
        /// </summary>
        /// <param name="entity"></param>
        void Remove(TEntity entity);
        /// <summary>
        /// 批量实体删除
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        Task<bool> BatchRemoveAsync(IList<TEntity> entities);
        /// <summary>
        /// 批量实体删除
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<bool> BatchRemoveAsync(Expression<Func<TEntity, bool>> predicate);
        int SaveChanges();
        Task<int> SaveChangesAsync();
        //IDbContextTransaction Begin();
        //Task<IDbContextTransaction> BeginAsync();
        //void Rollback();
        //void Commit();
    }
}
