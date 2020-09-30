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
        private int _index = 0;
        protected readonly ConnectionMultiplexer _Connection;
        protected readonly IRedisStore _IRedisStore;

        public RedisRepository(IRedisStore redisStore, int number = 0) : this(redisStore, null, number) {

        }

        public RedisRepository(IRedisStore redisStore, string instance, int number = 0) {
            this._IRedisStore = redisStore;
            this._Connection = string.IsNullOrEmpty(instance) ? redisStore.Instance : redisStore.GetInstance(instance);
            this._index = number;
        }

        #region #region 辅助方法
        //private string AddCustomKey(string oldKey) {
        //    var prefixKey = CustomKey ?? RedisConnectionHelp.SysCustomKey;
        //    return prefixKey + oldKey;
        //}

        private T Do<T>(Func<IDatabase, T> func, int? index = null) {
            var db = this._Connection.GetDatabase(index.HasValue ? index.Value : _index);
            return func(db);
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
    }
}
