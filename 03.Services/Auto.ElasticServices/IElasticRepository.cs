using Nest;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Auto.ElasticServices {
    public interface IElasticRepository<TEntity> where TEntity : class {
        /// <summary>
        /// 索引名称
        /// </summary>
        string IndexName { get; }
        /// <summary>
        /// ES客户端，已集成，任何地方都可以调用
        /// </summary>
        IElasticClient Client { get; set; }
        /// <summary>
        /// 检测索引是否已经存在
        /// </summary>
        /// <param name="indexName"></param>
        /// <returns></returns>
        Task<bool> IsExsitIndex(string indexName);
        /// <summary>
        /// 封装后的linq的查询方式
        /// </summary>
        /// <typeparam name="T">要查询和返回的Json</typeparam>
        /// <param name="indexName">index的名称</param>
        /// <param name="selector">linq内容</param>
        /// <returns></returns>
        Task<List<TEntity>> QueryAsync(string indexName, Func<QueryContainerDescriptor<TEntity>, QueryContainer> selector = null);
        /// <summary>
        /// 封装后的创建index
        /// </summary>
        /// <param name="indexName"></param>
        /// <param name="shards">分片数量，即数据块最小单元</param>
        /// <returns></returns>
        Task<bool> AddIndexAsync(string indexName, int shards = 5);
        /// <summary>
        /// 封装后的删除index
        /// </summary>
        /// <param name="indexName"></param>
        /// <returns></returns>
        Task<bool> RemoveIndexAsync(string indexName);
        /// <summary>
        /// 插入文档
        /// </summary>
        /// <param name="indexName">索引名称</param>
        /// <param name="typeName">文档名称</param>
        /// <param name="objectDocment">文档内容</param>
        /// <param name="_id">自定义_id</param>
        /// <returns></returns>
        Task<bool> AddDocumentAsync(string indexName, string _id, TEntity entity);
        /// <summary>
        /// 批量插入文档
        /// </summary>
        /// <typeparam name="T">文档格式</typeparam>
        /// <param name="indexName">索引名称</param>
        /// <param name="typeName"></param>
        /// <param name="listDocment">数据集合</param>
        /// <returns></returns>
        Task<bool> BatchAddDocumentAsync(string indexName, List<TEntity> entities);
        /// <summary>
        /// 删除一个文档
        /// </summary>
        /// <param name="indexName">索引名称</param>
        /// <param name="typeName">类别名称</param>
        /// <param name="_id">elasticsearch的id</param>
        /// <returns></returns>
        Task<bool> RemoveDocumentAsync(string indexName, string _id);
        /// <summary>
        /// 更新文档
        /// </summary>
        /// <param name="indexName">索引名称</param>
        /// <param name="typeName">类别名称</param>
        /// <param name="_id">elasticsearch的id</param>
        /// <param name="objectDocment">单条数据的所有内容</param>
        /// <returns></returns>
        Task<bool> UpdateDocumentAsync(string indexName, string _id, TEntity entity);
        /// <summary>
        /// 批量更新文档
        /// </summary>
        /// <param name="indexName">索引名称</param>
        /// <param name="typeName">类别名称</param>
        /// <param name="listDocment">数据集合，注：docment 里要有_id</param>
        /// <returns></returns>
        Task<bool> BatchUpdateDocumentAsync(string indexName, List<TEntity> entities);
    }
}
