using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Auto.Commons.Extensions.Redis {
    public partial class RedisRepository {
        private static readonly object Locker = new object();
        private static readonly string _RedisRootNode = "Redis";
        private static string _NodeServer = "default";
        private static IConfiguration _IConfiguration;
        private static readonly ConcurrentDictionary<string, ConnectionMultiplexer>
            _ConcurrentDictionary = new ConcurrentDictionary<string, ConnectionMultiplexer>();
        private ConnectionMultiplexer _instance;
        public RedisRepository(IConfiguration configuration) {
            _IConfiguration = configuration;
        }
        /// <summary>
        /// 单例获取
        /// </summary>
        //public static ConnectionMultiplexer Instance {
        //    get {
        //        if (_instance == null) {
        //            lock (Locker) {
        //                if (_instance == null || !_instance.IsConnected) {
        //                    _instance = GetConnectionMultiplexer();
        //                }
        //            }
        //        }
        //        return _instance;
        //    }
        //}
        public RedisRepository GetInstance() {
            if (_instance == null) {
                lock (Locker) {
                    if (_instance == null || !_instance.IsConnected) {
                        _instance = GetConnectionMultiplexer();
                    }
                }
            }
            return this;
        }
        /// <summary>
        /// 获取指定redis实例
        /// </summary>
        /// <param name="instanceName"></param>
        /// <returns></returns>
        public static ConnectionMultiplexer GetConnectionMultiplexer(string nodeServer = null) {
            _NodeServer = string.IsNullOrEmpty(nodeServer) ? _NodeServer : nodeServer;
            //不存在，创建实例
            if (!_ConcurrentDictionary.ContainsKey(_NodeServer)) {
                _ConcurrentDictionary[_NodeServer] = GetConnect(CheckConfiguration(_NodeServer));
            }
            return _ConcurrentDictionary[_NodeServer];
        }
        public IDatabaseAsync GetDatabase(int? number = null) {
            return _instance.GetDatabase(number.HasValue ? number.Value : 0);
        }
        /// <summary>
        /// 检查入参数
        /// </summary>
        /// <param name="configName">RedisConfig配置文件中的 Redis_Default/Redis_6 名称</param>
        /// <returns></returns>
        private static IConfigurationSection CheckConfiguration(string serverNode) {
            var root = _IConfiguration.GetSection(_RedisRootNode);
            if (root == null) {
                throw new ArgumentNullException($"找不到对应的{_RedisRootNode}配置！");
            }
            var server = _IConfiguration.GetSection(_RedisRootNode).GetSection(serverNode);
            if (server == null) {
                throw new ArgumentNullException($"{_RedisRootNode}找不到对应的{serverNode}配置！");
            }
            var instanceName = server["InstanceName"];
            var connection = server["Connection"];
            var defaultDatabase = server["DefaultDatabase"];
            if (string.IsNullOrEmpty(instanceName)) {
                throw new ArgumentNullException($"{serverNode}找不到对应的InstanceName");
            }
            if (string.IsNullOrEmpty(connection)) {
                throw new ArgumentNullException($"{serverNode}找不到对应的Connection");
            }
            if (string.IsNullOrEmpty(defaultDatabase)) {
                throw new ArgumentNullException($"{serverNode}找不到对应的DefaultDatabase");
            }
            return server;
        }
        private static ConnectionMultiplexer GetConnect(IConfigurationSection configurationSection) {
            var instanceName = configurationSection["InstanceName"];
            var connectionString = configurationSection["Connection"];

            var connection = _ConcurrentDictionary.GetOrAdd(instanceName, p => ConnectionMultiplexer.Connect(connectionString));

            //注册如下事件
            connection.ConnectionFailed += MuxerConnectionFailed;
            connection.ConnectionRestored += MuxerConnectionRestored;
            connection.ErrorMessage += MuxerErrorMessage;
            connection.ConfigurationChanged += MuxerConfigurationChanged;
            connection.HashSlotMoved += MuxerHashSlotMoved;
            connection.InternalError += MuxerInternalError;
            return connection;
        }

        #region #region 事件

        /// <summary>
        /// 配置更改时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void MuxerConfigurationChanged(object sender, EndPointEventArgs e) {
            Console.WriteLine("Configuration changed: " + e.EndPoint);
        }
        /// <summary>
        /// 发生错误时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void MuxerErrorMessage(object sender, RedisErrorEventArgs e) {
            Console.WriteLine("ErrorMessage: " + e.Message);
        }
        /// <summary>
        /// 重新建立连接之前的错误
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void MuxerConnectionRestored(object sender, ConnectionFailedEventArgs e) {
            Console.WriteLine("ConnectionRestored: " + e.EndPoint);
        }
        /// <summary>
        /// 连接失败 ， 如果重新连接成功你将不会收到这个通知
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void MuxerConnectionFailed(object sender, ConnectionFailedEventArgs e) {
            Console.WriteLine("重新连接：Endpoint failed: " + e.EndPoint + ", " + e.FailureType + (e.Exception == null ? "" : (", " + e.Exception.Message)));
        }
        /// <summary>
        /// 更改集群
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void MuxerHashSlotMoved(object sender, HashSlotMovedEventArgs e) {
            Console.WriteLine("HashSlotMoved:NewEndPoint" + e.NewEndPoint + ", OldEndPoint" + e.OldEndPoint);
        }
        /// <summary>
        /// redis类库错误
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void MuxerInternalError(object sender, InternalErrorEventArgs e) {
            Console.WriteLine("InternalError:Message" + e.Exception.Message);
        }

        #endregion 事件

        #region 辅助方法
        private string AddCustomKey(string oldKey) {
            var prefixKey = CustomKey ?? RedisConnectionHelp.SysCustomKey;
            return prefixKey + oldKey;
        }
        /// <summary>
        /// 对象转字符串
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        private string ConvertJson<T>(T value) {
            string result = value is string ? value.ToString() : JsonConvert.SerializeObject(value);
            return result;
        }

        /// <summary>
        /// RedisValueToObject
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        private T RedisValueToObject<T>(RedisValue value) {
            if (typeof(T).Name.Equals(typeof(string).Name)) {
                return JsonConvert.DeserializeObject<T>($"'{value}'");
            }
            else {
                T t = JsonConvert.DeserializeObject<T>(value);
                if (t == null) {
                    Console.WriteLine($"reids.ConvertObj.t:{null}");
                }
                return t;
            }
        }

        /// <summary>
        /// RedisValue[]转List对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values"></param>
        /// <returns></returns>
        private List<T> RedisValuesToList<T>(RedisValue[] values) {
            List<T> result = new List<T>();
            foreach (var item in values) {
                var model = RedisValueToObject<T>(item);
                result.Add(model);
            }
            return result;
        }

        /// <summary>
        /// stringList对象转RedisKey[]，多个Keys操作
        /// </summary>
        /// <param name="redisKeys"></param>
        /// <returns></returns>
        private RedisKey[] StringsToRedisKeys(List<string> redisKeys) {
            return redisKeys.Select(redisKey => (RedisKey)redisKey).ToArray();
        }

        /// <summary>
        /// 获取随机DB
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public int GetRandomNumber(string key) {
            var md5 = Md5(key);
            var n = md5[0];
            var numString = "0123456789abcdef";
            return numString.IndexOf(n);
        }

        /// <summary>
        /// 获取MD5字符串
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static string Md5(string input) {
            using (var md5 = MD5.Create()) {
                var result = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
                var strResult = BitConverter.ToString(result);
                return strResult.Replace("-", "");
            }
        }

        #endregion 辅助方法
        public void Dispose() {
            if (_ConcurrentDictionary != null && _ConcurrentDictionary.Count > 0) {
                foreach (var item in _ConcurrentDictionary.Values) {
                    item.Close();
                }
            }
        }
    }
}
