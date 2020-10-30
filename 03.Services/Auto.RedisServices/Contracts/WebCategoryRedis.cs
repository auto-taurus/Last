using  Auto.RedisServices.Modals;
using Auto.RedisServices.Repositories;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Auto.RedisServices.Contracts {

    /// <summary>
    /// 站点下的分类信息Key：gbxx:{mark}:categories
    /// 总访问Key：gbxx:{mark}:category:access:all
    /// 每日点击Key：gbxx:{mark}:category:click:{day}
    /// 日点击统计周排行Key：gbxx:{mark}:category:click:week:{week} 及时删除
    /// 日点击统计月排行Key：gbxx:{mark}:category:click:month:{month} 及时删除
    /// 每日访问Key：gbxx:{mark}:category:access:{day}
    /// 日访问计周排行Key：gbxx:{mark}:category:access:week:{week} 及时删除
    /// 日访问计月排行Key：gbxx:{mark}:category:access:month:{month} 及时删除
    /// </summary>
    public class WebCategoryRedis : RedisRepository, IWebCategoryRedis {
        private IRedisStore _IRedisStore;

        public WebCategoryRedis(IRedisStore redisStore) {
            this._IRedisStore = redisStore;
        }

        public async Task<bool> AddClickCount(int mark, string id) {
            var flag = false;

            var day = System.DateTime.Now.ToString("yyyyMMdd");// 当前日期

            var key = $"{_IRedisStore.PrefixKey}:{mark}:category:click";
            var number = _IRedisStore.GetRandomNumber(key);
            // 日点击key
            var daykey = $"{key}:{day}";
            // SortSet日点击排行数据（+1）
            var result = await _IRedisStore.Do(db => db.SortedSetIncrementAsync(daykey, id, 1), number);
            if (result > 0) flag = true;
            else flag = false;
            return flag;

        }
        public async Task<Tuple<bool, bool>> AddAccessCount(int mark, string id) {
            ///当前日期
            var day = System.DateTime.Now.ToString("yyyyMMdd");

            var accessKey = $"{_IRedisStore.PrefixKey}:{mark}:category:access";
            var countKey = $"{_IRedisStore.PrefixKey}:{mark}:category:access:all";

            var accessNumber = _IRedisStore.GetRandomNumber(accessKey);
            var countNumber = _IRedisStore.GetRandomNumber(countKey);
            // 日访key
            accessKey = $"{accessKey}:{day}";
            // SortSet日访问排行数据（+1）
            var dayResult = await _IRedisStore.Do(db => db.SortedSetIncrementAsync(accessKey, id, 1), accessNumber);
            var allResult = await _IRedisStore.Do(db => db.SortedSetIncrementAsync(countKey, id, 1), countNumber);

            return new Tuple<bool, bool>(dayResult > 0, allResult > 0);
        }
        public async Task<int> GetAccessCount(int mark, string id) {
            var countKey = $"{_IRedisStore.PrefixKey}:{mark}:category:access:all";
            var countNumber = _IRedisStore.GetRandomNumber(countKey);
            var count = await _IRedisStore.Do(db => db.SortedSetScoreAsync(countKey, id), countNumber);
            if (!count.HasValue)
                count = 0;
            return (int)count;
        }

        public async Task<SortedSetEntry[]> GetClickDays(int mark, DateTime? dt, int? pageIndex, int? pageSize) {
            var p = GetDayAndPage(dt, pageIndex, pageSize);
            var key = $"{_IRedisStore.PrefixKey}:{mark}:category:click";

            return await GetDays(key, p);
        }
        public async Task<SortedSetEntry[]> GetClickWeeks(int mark, DateTime? dt, int? pageIndex, int? pageSize) {
            var p = GetDayAndPage(dt, pageIndex, pageSize);
            var key = $"{_IRedisStore.PrefixKey}:{mark}:category:click";

            return await GetWeeks(key, p);
        }
        public async Task<SortedSetEntry[]> GetClickMonths(int mark, DateTime? dt, int? pageIndex, int? pageSize) {
            var p = GetDayAndPage(dt, pageIndex, pageSize);
            var key = $"{_IRedisStore.PrefixKey}:{mark}:category:click";

            return await GetMonths(key, p);
        }

        public async Task<SortedSetEntry[]> GetAccessDays(int mark, DateTime? dt, int? pageIndex, int? pageSize) {
            var p = GetDayAndPage(dt, pageIndex, pageSize);
            var key = $"{_IRedisStore.PrefixKey}:{mark}:category:access";

            return await GetDays(key, p);
        }
        public async Task<SortedSetEntry[]> GetAccessWeeks(int mark, DateTime? dt, int? pageIndex, int? pageSize) {
            var p = GetDayAndPage(dt, pageIndex, pageSize);
            var key = $"{_IRedisStore.PrefixKey}:{mark}:category:access";

            return await GetWeeks(key, p);
        }
        public async Task<SortedSetEntry[]> GetAccessMonths(int mark, DateTime? dt, int? pageIndex, int? pageSize) {
            var p = GetDayAndPage(dt, pageIndex, pageSize);
            var key = $"{_IRedisStore.PrefixKey}:{mark}:category:access";

            return await GetMonths(key, p);

        }

        /// <summary>
        /// 获取分类信息
        /// </summary>
        /// <param name="mark"></param>
        /// <returns></returns>
        public async Task<List<WebCategoryValue>> GetAsync(int mark) {
            var key = $"{_IRedisStore.PrefixKey}:{mark}:categories";
            var number = _IRedisStore.GetRandomNumber(key);
            var result = await this._IRedisStore.Do(db => db.StringGetAsync(key), number);
            if (!result.HasValue)
                return new List<WebCategoryValue>();
            return _IRedisStore.RedisValueToObject<List<WebCategoryValue>>(result);
        }
        /// <summary>
        /// 添加分类信息
        /// </summary>
        /// <param name="mark"></param>
        /// <returns></returns>
        public async Task<bool> AddAsync(int mark, List<WebCategoryValue> items) {
            var key = $"{_IRedisStore.PrefixKey}:{mark}:categories";
            var number = _IRedisStore.GetRandomNumber(key);

            var json = _IRedisStore.ObjectToString(items);
            return await this._IRedisStore.Do(db => db.StringSetAsync(key, json), number);
        }
    }
}
