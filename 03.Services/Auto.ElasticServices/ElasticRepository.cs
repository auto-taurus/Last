﻿using Elasticsearch.Net;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auto.ElasticServices {
    /// <summary>
    /// 
    /// </summary>
    public class ElasticRepository<TEntity> where TEntity : class {
        /// <summary>
        /// Linq查询的官方Client
        /// </summary>
        public IElasticClient Client { get; set; }
        protected readonly String Prefix;
        private IMemoryCache _IMemoryCache { get; set; }
        public ElasticRepository(IElasticClient elasticClient, IConfiguration configuration, IMemoryCache memoryCache) {
            this.Client = elasticClient;
            this.Prefix = configuration["ElasticConfig:Prefix"];
            this._IMemoryCache = memoryCache;
        }
        /// <summary>
        /// 检测索引是否已经存在
        /// </summary>
        /// <param name="indexName"></param>
        /// <returns></returns>
        public async Task<bool> IsExsitIndex(string indexName) {
            bool flag = false;
            try {
                var result = await Client.Indices.ExistsAsync(indexName);
                if (result.ApiCall.HttpStatusCode == 200) {
                    flag = true;
                }
            }
            catch (Exception) {

            }
            return flag;
        }
        /// <summary>
        /// 封装后的linq的查询方式
        /// </summary>
        /// <typeparam name="T">要查询和返回的Json</typeparam>
        /// <param name="indexName">index的名称</param>
        /// <param name="selector">linq内容</param>
        /// <returns></returns>
        public async Task<List<TEntity>> QueryAsync(string indexName, Func<QueryContainerDescriptor<TEntity>, QueryContainer> selector = null) {
            var list = await Client.SearchAsync<TEntity>(
                option => option.Index(indexName.ToLower())
                                .SearchType(SearchType.QueryThenFetch)
                                .Query(selector));


            return list.Documents.ToList();
        }
        /// <summary>
        /// 封装后的创建index
        /// </summary>
        /// <param name="indexName"></param>
        /// <param name="shards">分片数量，即数据块最小单元</param>
        /// <returns></returns>
        public async Task<bool> AddIndexAsync(string indexName, int shards = 5) {
            try {
                var isHaveIndex = await IsExsitIndex(indexName.ToLower());
                if (!isHaveIndex) {
                    var setting = new IndexState() {
                        Settings = new IndexSettings() {
                            NumberOfReplicas = 0, //副本数
                            NumberOfShards = shards, //分片数
                            RefreshInterval = -1
                        }
                    };
                    var response = await Client.Indices
                                               .CreateAsync(indexName, x => x.InitializeUsing(setting)
                                                                             .Map<TEntity>(y => y.AutoMap()));
                    return response.Acknowledged;
                }
            }
            catch (Exception ex) {
                throw;
            }
            return true;
        }
        /// <summary>
        /// 封装后的删除index
        /// </summary>
        /// <param name="indexName"></param>
        /// <returns></returns>
        public async Task<bool> RemoveIndexAsync(string indexName) {
            var response = await Client.Indices.DeleteAsync(indexName.ToLower());
            return response.Acknowledged;
        }
        /// <summary>
        /// 优化索引文档写入性能
        /// </summary>
        /// <param name="indexName">索引名称</param>
        /// <param name="refresh"></param>
        /// <returns></returns>
        public async Task<bool> SetIndexRar(string indexName, string refresh = "60s") {
            var flag = false;
            try {
                var response = new PutMappingResponse();
                if (_IMemoryCache.TryGetValue("isRar", out bool isRefresh)) {
                    if (!isRefresh) {
                        response = await Client.Indices.PutMappingAsync<TEntity>(x => x.Index(indexName.ToLower()).Timeout(refresh));
                        if (response.Acknowledged) {
                            flag = true;
                            _IMemoryCache.Set("isRar", true);
                        }
                    }
                }
                else {
                    response = await Client.Indices.PutMappingAsync<TEntity>(x => x.Index(indexName.ToLower()).Timeout(refresh));
                    if (response.Acknowledged) {
                        flag = true;
                        _IMemoryCache.Set("isRar", true);
                    }
                }

            }
            catch (Exception) {
            }
            return flag;
        }
        /// <summary>
        /// 插入单个文档
        /// </summary>
        /// <param name="entity">文档</param>
        /// <param name="indexName">索引名称</param>
        /// <param name="_id">自定义编号</param>
        /// <returns></returns>
        public async Task<bool> AddDocumentAsync(string indexName, string _id, TEntity entity) {
            var response = new IndexResponse();
            if (_id.Length > 0)
                response = await Client.IndexAsync(entity, x => x.Index(indexName.ToLower()).Id(_id));
            else
                response = await Client.IndexAsync(entity, x => x.Index(indexName.ToLower()));
            if (response.Shards.Successful > 0) {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 批量插入文档
        /// </summary>
        /// <param name="indexName">索引名称</param>
        /// <param name="typeName"></param>
        /// <param name="listDocment">数据集合</param>
        /// <returns></returns>
        public async Task<bool> BatchAddDocumentAsync(string indexName, List<TEntity> entities) {
            var isRefresh = await SetIndexRar(indexName.ToLower());
            if (isRefresh) {
                try {
                    var response = Client.BulkAll(entities, b => b.Index(indexName)
                                                                  .BackOffTime("60s")
                                                                  .BackOffRetries(2)
                                                                  .RefreshOnCompleted()
                                                                  .MaxDegreeOfParallelism(Environment.ProcessorCount)
                                                                  .Size(10000)
                                                                )
                                                                .Wait(TimeSpan.FromMinutes(15), next => {
                                                                    var d = next;
                                                                    // do something e.g. write number of pages to console
                                                                });
                    //var response = await Client.BulkAsync(x => x.Index(indexName).IndexMany(entities));
                    if (response.TotalNumberOfFailedBuffers <= 0 || response.TotalNumberOfRetries <= 0) {
                        _IMemoryCache.Set("isRar", false);
                        return true;
                    }
                }
                catch (Exception ex) {
                    _IMemoryCache.Set("isRar", false);
                }
            }

            return false;
        }
        /// <summary>
        /// 删除一个文档
        /// </summary>
        /// <param name="indexName">索引名称</param>
        /// <param name="_id">elasticsearch的id</param>
        /// <returns></returns>
        public async Task<bool> RemoveDocumentAsync(string indexName, string _id) {
            try {
                var response = await Client.DeleteAsync<TEntity>(_id, x => x.Index(indexName.ToLower()));
                return response.Shards.Successful > 0 || response.Shards.Total == 0;

            }
            catch (Exception) {

            }
            return false;
        }
        /// <summary>
        /// 更新文档  
        /// </summary>
        /// <param name="entity">单条数据的所有内容</param>
        /// <param name="indexName">索引名称</param>
        /// <param name="_id">elasticsearch的id</param>
        /// <returns></returns>
        public async Task<bool> UpdateDocumentAsync(string indexName, string _id, TEntity entity) {
            try {
                var response = await Client.UpdateAsync<TEntity>(_id, x => x.Index(indexName).Doc(entity));
                return response.Shards.Successful > 0;
            }
            catch {

            }
            return false;
        }
        /// <summary>
        /// 批量更新文档
        /// </summary>
        /// <param name="indexName">索引名称</param>
        /// <param name="typeName">类别名称</param>
        /// <param name="listDocment">数据集合，注：docment 里要有_id,否则更新不进去</param>
        /// <returns></returns>
        public async Task<bool> BatchUpdateDocumentAsync(string indexName, List<TEntity> entities) {
            bool flag = false;
            try {
                var bulkIndexResponse = await Client.BulkAsync(x => x.Index(indexName)
                                                               .UpdateMany(entities, (descriptor, docs) => {
                                                                   return descriptor;
                                                               }));
            }
            catch {

            }
            return flag;
        }

    }
}
