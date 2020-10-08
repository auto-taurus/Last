using Auto.Commons.Ioc.IContract;
using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Auto.RedisServices {
    /// <summary>
    /// Redis客户端，任何地方都可以调用
    /// </summary>
    public interface IRedisStore : ISingletonInject {
        /// <summary>
        /// 获取前缀
        /// </summary>
        string PrefixKey { get; set; }
        /// <summary>
        /// 获取默认实例
        /// </summary>
        ConnectionMultiplexer Instance { get; }
        /// <summary>
        /// 获取指定实例
        /// </summary>
        /// <param name="nodeServer"></param>
        /// <returns></returns>
        ConnectionMultiplexer GetInstance(string nodeServer = null);
        /// <summary>
        /// 获取默认实例数据库
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        IDatabaseAsync GetDatabase(int? number = null);
        /// <summary>
        /// 获取默认实例下的服务
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        IServer GetServer(string hostAndPort);
    }
    public static class IRedisStoreExtension {

        #region #region 辅助方法

        public static T Do<T>(this IRedisStore redisStore, Func<IDatabaseAsync, T> func, int index = 0) {
            var database = redisStore.Instance.GetDatabase(index);
            return func(database);
        }
        /// <summary>
        /// 对象转字符串
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ObjectToString<T>(this IRedisStore redisStore, T value) {
            string result = value is string ? value.ToString() : JsonConvert.SerializeObject(value);
            return result;
        }

        /// <summary>
        /// RedisValueToObject
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static T RedisValueToObject<T>(this IRedisStore redisStore, RedisValue value) {
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
        public static List<T> RedisValuesToList<T>(this IRedisStore redisStore, RedisValue[] values) {
            List<T> result = new List<T>();
            foreach (var item in values) {
                var model = redisStore.RedisValueToObject<T>(item);
                result.Add(model);
            }
            return result;
        }

        /// <summary>
        /// stringList对象转RedisKey[]，多个Keys操作
        /// </summary>
        /// <param name="redisKeys"></param>
        /// <returns></returns>
        public static RedisKey[] StringsToRedisKeys(this IRedisStore redisStore, List<string> redisKeys) {
            return redisKeys.Select(redisKey => (RedisKey)redisKey).ToArray();
        }

        /// <summary>
        /// 获取随机DB
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static int GetRandomNumber(this IRedisStore redisStore, string key) {
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
                return strResult.Replace("-", "").ToLower();
            }
        }

        #endregion 辅助方法

    }
}
