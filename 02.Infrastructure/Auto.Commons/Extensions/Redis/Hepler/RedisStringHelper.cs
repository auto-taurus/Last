﻿using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto.Commons.Extensions.Redis.Hepler {
    public partial class RedisRepository {
        //#region String

        //#region 同步方法

        ///// <summary>
        ///// 保存单个key value
        ///// </summary>
        ///// <param name="key">Redis Key</param>
        ///// <param name="value">保存的值</param>
        ///// <param name="expiry">过期时间</param>
        ///// <returns></returns>
        //public bool StringSet(string key, string value, TimeSpan? expiry = default(TimeSpan?)) {
        //    key = AddCustomKey(key);
        //    return Do(db => db.StringSet(key, value, expiry));
        //}

        ///// <summary>
        ///// 保存多个key value
        ///// </summary>
        ///// <param name="keyValues">键值对</param>
        ///// <returns></returns>
        //public bool StringSet(List<KeyValuePair<RedisKey, RedisValue>> keyValues) {
        //    List<KeyValuePair<RedisKey, RedisValue>> newkeyValues =
        //        keyValues.Select(p => new KeyValuePair<RedisKey, RedisValue>(AddCustomKey(p.Key), p.Value)).ToList();
        //    return Do(db => db.StringSet(newkeyValues.ToArray()));
        //}

        ///// <summary>
        ///// 保存一个对象
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <param name="key"></param>
        ///// <param name="obj"></param>
        ///// <param name="expiry"></param>
        ///// <returns></returns>
        //public bool StringSet<T>(string key, T obj, TimeSpan? expiry = default(TimeSpan?)) {
        //    key = AddCustomKey(key);
        //    string json = _IRedisStore.ObjectToString(obj);
        //    return Do(db => db.StringSet(key, json, expiry));
        //}

        ///// <summary>
        ///// 获取单个key的值
        ///// </summary>
        ///// <param name="key">Redis Key</param>
        ///// <returns></returns>
        //public string StringGet(string key) {
        //    key = AddCustomKey(key);
        //    return Do(db => db.StringGet(key));
        //}

        ///// <summary>
        ///// 获取多个Key
        ///// </summary>
        ///// <param name="listKey">Redis Key集合</param>
        ///// <returns></returns>
        //public RedisValue[] StringGet(List<string> listKey) {
        //    List<string> newKeys = listKey.Select(AddCustomKey).ToList();
        //    return Do(db => db.StringGet(_IRedisStore.StringsToRedisKeys(newKeys)));
        //}

        ///// <summary>
        ///// 获取一个key的对象
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <param name="key"></param>
        ///// <returns></returns>
        //public T StringGet<T>(string key) {
        //    key = AddCustomKey(key);
        //    return Do(db => _IRedisStore.RedisValueToObject<T>(db.StringGet(key)));
        //}

        ///// <summary>
        ///// 为数字增长val
        ///// </summary>
        ///// <param name="key"></param>
        ///// <param name="val">可以为负</param>
        ///// <returns>增长后的值</returns>
        //public double StringIncrement(string key, double val = 1) {
        //    key = AddCustomKey(key);
        //    return Do(db => db.StringIncrement(key, val));
        //}

        ///// <summary>
        ///// 为数字减少val
        ///// </summary>
        ///// <param name="key"></param>
        ///// <param name="val">可以为负</param>
        ///// <returns>减少后的值</returns>
        //public double StringDecrement(string key, double val = 1) {
        //    key = AddCustomKey(key);
        //    return Do(db => db.StringDecrement(key, val));
        //}

        //#endregion 同步方法

        //#region 异步方法

        ///// <summary>
        ///// 保存单个key value
        ///// </summary>
        ///// <param name="key">Redis Key</param>
        ///// <param name="value">保存的值</param>
        ///// <param name="expiry">过期时间</param>
        ///// <returns></returns>
        //public async Task<bool> StringSetAsync(string key, string value, TimeSpan? expiry = default(TimeSpan?)) {
        //    key = AddCustomKey(key);
        //    return await Do(db => db.StringSetAsync(key, value, expiry));
        //}

        ///// <summary>
        ///// 保存多个key value
        ///// </summary>
        ///// <param name="keyValues">键值对</param>
        ///// <returns></returns>
        //public async Task<bool> StringSetAsync(List<KeyValuePair<RedisKey, RedisValue>> keyValues) {
        //    List<KeyValuePair<RedisKey, RedisValue>> newkeyValues =
        //        keyValues.Select(p => new KeyValuePair<RedisKey, RedisValue>(AddCustomKey(p.Key), p.Value)).ToList();
        //    return await Do(db => db.StringSetAsync(newkeyValues.ToArray()));
        //}

        ///// <summary>
        ///// 保存一个对象
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <param name="key"></param>
        ///// <param name="obj"></param>
        ///// <param name="expiry"></param>
        ///// <returns></returns>
        //public async Task<bool> StringSetAsync<T>(string key, T obj, TimeSpan? expiry = default(TimeSpan?)) {
        //    key = AddCustomKey(key);
        //    string json = _IRedisStore.ObjectToString(obj);
        //    return await Do(db => db.StringSetAsync(key, json, expiry));
        //}

        ///// <summary>
        ///// 获取单个key的值
        ///// </summary>
        ///// <param name="key">Redis Key</param>
        ///// <returns></returns>
        //public async Task<string> StringGetAsync(string key) {
        //    key = AddCustomKey(key);
        //    return await Do(db => db.StringGetAsync(key));
        //}

        ///// <summary>
        ///// 获取多个Key
        ///// </summary>
        ///// <param name="listKey">Redis Key集合</param>
        ///// <returns></returns>
        //public async Task<RedisValue[]> StringGetAsync(List<string> listKey) {
        //    List<string> newKeys = listKey.Select(AddCustomKey).ToList();
        //    return await Do(db => db.StringGetAsync(_IRedisStore.StringsToRedisKeys(newKeys)));
        //}

        ///// <summary>
        ///// 获取一个key的对象
        ///// </summary>
        ///// <typeparam name="T"></typeparam>
        ///// <param name="key"></param>
        ///// <returns></returns>
        //public async Task<T> StringGetAsync<T>(string key) {
        //    key = AddCustomKey(key);
        //    string result = await Do(db => db.StringGetAsync(key));
        //    return _IRedisStore.RedisValueToObject<T>(result);
        //}

        ///// <summary>
        ///// 为数字增长val
        ///// </summary>
        ///// <param name="key"></param>
        ///// <param name="val">可以为负</param>
        ///// <returns>增长后的值</returns>
        //public async Task<double> StringIncrementAsync(string key, double val = 1) {
        //    key = AddCustomKey(key);
        //    return await Do(db => db.StringIncrementAsync(key, val));
        //}

        ///// <summary>
        ///// 为数字减少val
        ///// </summary>
        ///// <param name="key"></param>
        ///// <param name="val">可以为负</param>
        ///// <returns>减少后的值</returns>
        //public async Task<double> StringDecrementAsync(string key, double val = 1) {
        //    key = AddCustomKey(key);
        //    return await Do(db => db.StringDecrementAsync(key, val));
        //}

        //#endregion 异步方法

        //#endregion String
    }
}
