using Elasticsearch.Net;
using Nest;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Auto.ElasticServices {
    public interface IElasticRepository<TEntity> where TEntity : class {
        /// <summary>
        /// 索引名称
        /// </summary>
        string IndexName { get; }
        /// <summary>
        /// 检测索引是否已经存在
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        Task<bool> IsExsitIndex(string index);
        /// <summary>
        /// 封装后的linq的查询方式
        /// </summary>
        /// <typeparam name="T">要查询和返回的Json</typeparam>
        /// <param name="indexName">index的名称</param>
        /// <param name="selector">linq内容</param>
        /// <returns></returns>
        Task<List<TEntity>> SearchAsync(string indexName, Func<QueryContainerDescriptor<TEntity>, QueryContainer> selector = null);
        /// <summary>
        /// 封装后的创建index
        /// </summary>
        /// <param name="indexName"></param>
        /// <param name="shards">分片数量，即数据块最小单元</param>
        /// <returns></returns>
        Task<bool> CreateIndexAsync(string indexName, int shards = 5);
        /// <summary>
        /// 封装后的删除index
        /// </summary>
        /// <param name="indexName"></param>
        /// <returns></returns>
        Task<bool> DeleteIndexAsync(string indexName);
        /// <summary>
        /// 插入文档
        /// </summary>
        /// <param name="indexName">索引名称</param>
        /// <param name="typeName">文档名称</param>
        /// <param name="objectDocment">文档内容</param>
        /// <param name="_id">自定义_id</param>
        /// <returns></returns>
        Task<bool> InsertDocumentAsync(string indexName, string typeName, object objectDocment, string _id = "");
        /// <summary>
        /// 批量插入文档
        /// </summary>
        /// <typeparam name="T">文档格式</typeparam>
        /// <param name="indexName">索引名称</param>
        /// <param name="typeName"></param>
        /// <param name="listDocment">数据集合</param>
        /// <returns></returns>
        Task<bool> InsertListDocumentAsync(string indexName, string typeName, List<object> listDocment);
        /// <summary>
        /// 删除一个文档
        /// </summary>
        /// <param name="indexName">索引名称</param>
        /// <param name="typeName">类别名称</param>
        /// <param name="_id">elasticsearch的id</param>
        /// <returns></returns>
        Task<bool> DeleteDocumentAsync(string indexName, string typeName, string _id);
        /// <summary>
        /// 更新文档
        /// </summary>
        /// <param name="indexName">索引名称</param>
        /// <param name="typeName">类别名称</param>
        /// <param name="_id">elasticsearch的id</param>
        /// <param name="objectDocment">单条数据的所有内容</param>
        /// <returns></returns>
        Task<bool> UpdateDocumentAsync(string indexName, string typeName, string _id, object objectDocment);
        /// <summary>
        /// 批量更新文档
        /// </summary>
        /// <param name="indexName">索引名称</param>
        /// <param name="typeName">类别名称</param>
        /// <param name="listDocment">数据集合，注：docment 里要有_id</param>
        /// <returns></returns>
        Task<bool> UpdateListDocumentAsync(string indexName, string typeName, List<object> listDocment);
    }
}
