using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Auto.DataServices {

    public interface IRepository<TEntity> : IDisposable where TEntity : class {
        /// <summary>
        /// 自定义条件过滤、排序、分页，请使用此方法
        /// 根据指定条件获取单个实体
        /// 根据指定条件获取列表
        /// </summary>
        /// <returns>返回查询IQueryable</returns>
        IQueryable<TEntity> Query();
        /// <summary>
        /// 查询分页排序
        /// </summary>
        /// <typeparam name="TSort"></typeparam>
        /// <param name="predicate">过滤条件</param>
        /// <param name="expression">排序字段</param>
        /// <param name="isDesc">是否倒序</param>
        /// <param name="pageIndex">当前页</param>
        /// <param name="pageSize">页大小</param>
        /// <returns></returns>
        Task<Tuple<int, List<TEntity>>> QueryPager<TSort>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TSort>> expression, bool isDesc = false, int pageIndex = 1, int pageSize = 10);
        /// <summary>
        /// 单个实体添加
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        ValueTask<EntityEntry<TEntity>> Add(TEntity entity);
        /// <summary>
        /// 批量添加实体
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        Task<bool> BatchAddAsync(List<TEntity> entities);
        /// <summary>
        /// 单个实体更新
        /// </summary>
        /// <param name="entity"></param>
        void Update(TEntity entity);
        /// <summary>
        /// 批量更新实体
        /// </summary>
        /// <param name="predicate">过滤条件</param>
        /// <param name="entity">更新字段</param>
        /// <returns></returns>
        Task BatchUpdateAsync(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TEntity>> entity);


        void Remove(TEntity entity);

        int CommitChanges();

        Task<int> CommitChangesAsync();
    }
}
