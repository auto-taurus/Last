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
    public class RedisStore : IRedisStore {
        private readonly object Locker = new object();
        private readonly IConfiguration _IConfiguration;
        private ConnectionMultiplexer _instance;
        private readonly ConcurrentDictionary<string, ConnectionMultiplexer> _ConcurrentDictionary = new ConcurrentDictionary<string, ConnectionMultiplexer>();
        private readonly string _RedisRootNode = "RedisConfig";
        public string PrefixKey { get; set; }
        public RedisStore(IConfiguration configuration) {
            this._IConfiguration = configuration;
            this.PrefixKey = this._IConfiguration["RedisConfig:Default:Prefix"];
        }
        /// <summary>
        /// 当前实例
        /// </summary>
        public ConnectionMultiplexer Instance {
            get {
                if (_instance == null) {
                    lock (Locker) {
                        if (_instance == null || !_instance.IsConnected) {
                            _instance = GetInstance();
                        }
                    }
                }
                return _instance;
            }
        }
        /// <summary>
        /// 获取指定redis实例
        /// </summary>
        /// <param name="instanceName"></param>
        /// <returns></returns>
        public ConnectionMultiplexer GetInstance(string nodeServer = null) {
            nodeServer = string.IsNullOrEmpty(nodeServer) ? "Default" : nodeServer;
            //不存在，创建实例
            if (!_ConcurrentDictionary.ContainsKey(nodeServer)) {
                this._ConcurrentDictionary[nodeServer] = this.GetConnect(this.CheckConfiguration(nodeServer));
            }
            return this._ConcurrentDictionary[nodeServer];
        }
        /// <summary>
        /// 获取默认数据库
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public IDatabaseAsync GetDatabase(int? number = null) {
            return this.Instance.GetDatabase(number.HasValue ? number.Value : 0);
        }
        /// <summary>
        /// 获取默认服务
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public IServer GetServer(string hostAndPort) {
            return this.Instance.GetServer(hostAndPort);
        }
        /// <summary>
        /// 检查参数
        /// </summary>
        /// <param name="configName">RedisConfig配置文件中的 Redis_Default/Redis_6 名称</param>
        /// <returns></returns>
        private IConfigurationSection CheckConfiguration(string nodeServer) {
            var root = this._IConfiguration.GetSection(_RedisRootNode);
            if (root == null) {
                throw new ArgumentNullException($"找不到对应的{_RedisRootNode}配置！");
            }
            var server = this._IConfiguration.GetSection(_RedisRootNode).GetSection(nodeServer);
            if (server == null) {
                throw new ArgumentNullException($"{_RedisRootNode}找不到对应的{nodeServer}配置！");
            }
            var connection = server["Connection"];
            var defaultDatabase = server["DefaultDatabase"];
            if (string.IsNullOrEmpty(connection)) {
                throw new ArgumentNullException($"{nodeServer}找不到对应的Connection");
            }
            if (string.IsNullOrEmpty(defaultDatabase)) {
                throw new ArgumentNullException($"{nodeServer}找不到对应的DefaultDatabase");
            }
            return server;
        }
        /// <summary>
        /// 获取链接
        /// </summary>
        /// <param name="configurationSection"></param>
        /// <returns></returns>
        private ConnectionMultiplexer GetConnect(IConfigurationSection configurationSection) {
            var connectionString = configurationSection["Connection"];

            //var connection = _ConcurrentDictionary.GetOrAdd(instanceName, p => ConnectionMultiplexer.Connect(connectionString));
            var connection = ConnectionMultiplexer.Connect(connectionString);

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
        /// 连接失败，如果重新连接成功你将不会收到这个通知
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
    }

}
