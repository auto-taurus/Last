using Elasticsearch.Net;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Nest;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
        public IElasticClient EsLinqClient { get; set; }
        /// <summary>
        /// Js查询的官方Client
        /// </summary>
        public IElasticLowLevelClient EsJsonClient { get; set; }
        public IMemoryCache MemoryCache { get; set; }
        public ElasticRepository(IConfiguration configuration, IMemoryCache memoryCache) {
            MemoryCache = memoryCache;
            var uris = configuration["ElasticConfig:Host"].Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries).ToList().ConvertAll(x => new Uri(x));
            var connectionPool = new StaticConnectionPool(uris);
            var settings = new ConnectionSettings(connectionPool).RequestTimeout(TimeSpan.FromSeconds(30));
            //.BasicAuthentication("a", "b")
            this.EsJsonClient = new ElasticLowLevelClient(settings);
            this.EsLinqClient = new ElasticClient(settings);
        }
        /// <summary>
        /// 检测索引是否已经存在
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public async Task<bool> IsExsitIndex(string index) {
            bool flag = false;
            StringResponse resStr = null;
            try {
                resStr = await EsJsonClient.Indices.ExistsAsync<StringResponse>(index);
                if (resStr.HttpStatusCode == 200) {
                    flag = true;
                } 
            }
            catch (Exception ex) {
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
        public async Task<List<TEntity>> SearchAsync(string indexName, Func<QueryContainerDescriptor<TEntity>, QueryContainer> selector = null) {

            var list = await EsLinqClient.SearchAsync<TEntity>(option => option.Index(indexName.ToLower()).SearchType(SearchType.QueryThenFetch).Query(selector).Scroll());
            return list.Documents.ToList();
        }
        /// <summary>
        /// 封装后的创建index
        /// </summary>
        /// <param name="indexName"></param>
        /// <param name="shards">分片数量，即数据块最小单元</param>
        /// <returns></returns>
        public async Task<bool> CreateIndexAsync(string indexName, int shards = 5) {
            var isHaveIndex = await IsExsitIndex(indexName.ToLower());
            if (!isHaveIndex) {
                var setting = new IndexState() {
                    Settings = new IndexSettings() {
                        NumberOfReplicas = 0, //副本数
                        NumberOfShards = shards, //分片数
                        RefreshInterval = -1
                    }
                };
                var result = await EsLinqClient.Indices.CreateAsync(indexName, x => x.InitializeUsing(setting).Map<TEntity>(y => y.AutoMap()));
                //var resObj = JObject.Parse(result.);
                return true;
                //if (!(bool)resObj["acknowledged"]) {
                //return false;
                //}
            }
            return true;
        }
        /// <summary>
        /// 封装后的删除index
        /// </summary>
        /// <param name="indexName"></param>
        /// <returns></returns>
        public async Task<bool> DeleteIndexAsync(string indexName) {
            var stringRespones = await EsJsonClient.Indices.DeleteAsync<StringResponse>(indexName.ToLower());
            var resObj = JObject.Parse(stringRespones.Body);
            if ((bool)resObj["acknowledged"]) {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 插入单个文档
        /// </summary>
        /// <param name="indexName">索引名称</param>
        /// <param name="typeName">文档名称</param>
        /// <param name="objectDocment">文档内容</param>
        /// <param name="_id">自定义_id</param>
        /// <returns></returns>
        public async Task<bool> InsertDocumentAsync(string indexName, string typeName, object objectDocment, string _id = "") {
            var stringRespones = new StringResponse();
            if (_id.Length > 0)
                stringRespones = await EsJsonClient.IndexAsync<StringResponse>(indexName.ToLower(), _id, PostData.String(JsonConvert.SerializeObject(objectDocment)));
            else
                stringRespones = await EsJsonClient.IndexAsync<StringResponse>(indexName.ToLower(), typeName, PostData.String(JsonConvert.SerializeObject(objectDocment)));
            var resObj = JObject.Parse(stringRespones.Body);
            if ((int)resObj["_shards"]["successful"] > 0) {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 优化写入性能
        /// </summary>
        /// <param name="index"></param>
        /// <param name="refresh"></param>
        /// <param name="replia">是数据备份数，如果只有一台机器，设置为0</param>
        /// <returns></returns>
        public async Task<bool> SetIndexRefreshAndReplia(string index, string refresh = "30s", int replia = 1) {
            bool flag = false;
            StringResponse resStr = null;
            try {
                if (MemoryCache.TryGetValue("isRefreshAndReplia", out bool isrefresh)) {
                    if (!isrefresh) {
                        resStr = await EsJsonClient.Indices.PutMappingAsync<StringResponse>(index.ToLower(),
                     PostData.String($"{{\"index\" : {{\"number_of_replicas\" : {replia},\"refresh_interval\":\"{refresh}\"}}}}"));
                        var resObj = JObject.Parse(resStr.Body);
                        if ((bool)resObj["acknowledged"]) {
                            flag = true;
                            MemoryCache.Set("isRefreshAndReplia", true);
                        }
                    }
                }
                else {
                    resStr = await EsJsonClient.Indices.PutMappingAsync<StringResponse>(index.ToLower(),
                    PostData.String($"{{\"index\" : {{\"number_of_replicas\" : {replia},\"refresh_interval\":\"{refresh}\"}}}}"));
                    var resObj = JObject.Parse(resStr.Body);
                    if ((bool)resObj["acknowledged"]) {
                        flag = true;
                        MemoryCache.Set("isRefreshAndReplia", true);
                    }
                }

            }
            catch (Exception ex) {
            }
            return flag;
        }
        /// <summary>
        /// 批量插入文档
        /// </summary>
        /// <param name="indexName">索引名称</param>
        /// <param name="typeName"></param>
        /// <param name="listDocment">数据集合</param>
        /// <returns></returns>
        public async Task<bool> InsertListDocumentAsync(string indexName, string typeName, List<object> listDocment) {
            var isRefresh = await SetIndexRefreshAndReplia(indexName.ToLower());
            if (isRefresh) {
                List<string> list = new List<string>();
                foreach (var ob in listDocment) {
                    //{"index":{"_index":"meterdata","_type":"autoData"}}
                    var indexJsonStr = new { index = new { _index = indexName.ToLower(), _type = typeName } };
                    list.Add(JsonConvert.SerializeObject(indexJsonStr));
                    list.Add(JsonConvert.SerializeObject(ob));
                }

                var stringRespones = await EsJsonClient.BulkAsync<StringResponse>(indexName.ToLower(), PostData.MultiJson(list));
                var resObj = JObject.Parse(stringRespones.Body);
                if (!(bool)resObj["errors"]) {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// 删除一个文档
        /// </summary>
        /// <param name="indexName">索引名称</param>
        /// <param name="typeName">类别名称</param>
        /// <param name="_id">elasticsearch的id</param>
        /// <returns></returns>
        public async Task<bool> DeleteDocumentAsync(string indexName, string typeName, string _id) {
            bool flag = false;
            StringResponse resStr = null;
            try {
                resStr = await EsJsonClient.DeleteAsync<StringResponse>(indexName.ToLower(), _id);
                var resObj = JObject.Parse(resStr.Body);
                if ((int)resObj["_shards"]["total"] == 0 || (int)resObj["_shards"]["successful"] > 0) {
                    flag = true;
                }
            }
            catch (Exception ex) {
            }

            return flag;
        }
        /// <summary>
        /// 更新文档  
        /// </summary>
        /// <param name="indexName">索引名称</param>
        /// <param name="typeName">类别名称</param>
        /// <param name="_id">elasticsearch的id</param>
        /// <param name="objectDocment">单条数据的所有内容</param>
        /// <returns></returns>
        public async Task<bool> UpdateDocumentAsync(string indexName, string typeName, string _id, object objectDocment) {
            bool flag = false;
            try {
                string json = JsonConvert.SerializeObject(objectDocment);
                if (json.IndexOf("[") == 0) {
                    var objectDocmentOne = JToken.Parse(json);
                    json = JsonConvert.SerializeObject(objectDocmentOne[0]);
                }
                int idInt = json.IndexOf("\"_id");
                if (idInt > 0) {
                    string idJson = json.Substring(idInt, json.IndexOf(_id) + _id.Length + 1);
                    json = json.Replace(idJson, "");
                }
                //{ "update" : { "_id" : "5cc2d9cf6d2d99ce58007201" } }
                //{ "doc" : { "Sex" : "王五111" } }
                List<string> list = new List<string>();
                list.Add("{\"update\":{\"_id\":\"" + _id + "\"}}");
                list.Add("{\"doc\":" + json + "}");
                var stringRespones = await EsJsonClient.BulkAsync<StringResponse>(indexName.ToLower(), PostData.MultiJson(list));
                var resObj = JObject.Parse(stringRespones.Body);
                if (!(bool)resObj["errors"]) {
                    return true;
                }
            }
            catch { }
            return flag;
        }
        /// <summary>
        /// 批量更新文档
        /// </summary>
        /// <param name="indexName">索引名称</param>
        /// <param name="typeName">类别名称</param>
        /// <param name="listDocment">数据集合，注：docment 里要有_id,否则更新不进去</param>
        /// <returns></returns>
        public async Task<bool> UpdateListDocumentAsync(string indexName, string typeName, List<object> listDocment) {
            bool flag = false;
            try {
                List<string> list = new List<string>();
                foreach (var objectDocment in listDocment) {
                    string json = JsonConvert.SerializeObject(objectDocment);
                    JToken docment = null;
                    var objectDocmentOne = JToken.Parse(json);
                    docment = objectDocmentOne;
                    if (json.IndexOf("[") == 0) {
                        json = JsonConvert.SerializeObject(objectDocmentOne[0]);
                        docment = objectDocmentOne[0];
                    }
                    string _id = docment["_id"].ToString();
                    int idInt = json.IndexOf("\"_id");
                    if (idInt > 0) {
                        string idJson = json.Substring(idInt, json.IndexOf(_id) + _id.Length + 1);
                        json = json.Replace(idJson, "");
                    }
                    //{ "update" : { "_id" : "5cc2d9cf6d2d99ce58007201" } }
                    //{ "doc" : { "Sex" : "王五111" } }
                    list.Add("{\"update\":{\"_id\":\"" + _id + "\"}}");
                    list.Add("{\"doc\":" + json + "}");
                }

                var stringRespones = await EsJsonClient.BulkAsync<StringResponse>(indexName.ToLower(), PostData.MultiJson(list));
                var resObj = JObject.Parse(stringRespones.Body);
                if (!(bool)resObj["errors"]) {
                    return true;
                }
            }
            catch { }
            return flag;
        }

    }
}
