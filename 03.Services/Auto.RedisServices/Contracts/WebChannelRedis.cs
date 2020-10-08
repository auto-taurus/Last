using Auto.Commons.Extensions.Redis;
using Auto.RedisServices.Repositories;
using StackExchange.Redis;
using System;
using System.Threading.Tasks;

namespace Auto.RedisServices.Contracts {
    /// <summary>
    /// 总访问Key：        gbxx:{mark}:channel:access:all
    /// 每日访问Key：      gbxx:{mark}:channel:access:{day}
    /// 日访问计周Key：    gbxx:{mark}:channel:access:week:count:{week} 及时删除
    /// 日访问计月Key：    gbxx:{mark}:channel:access:month:count:{month} 及时删除
    /// 日访问计周Key：    gbxx:{mark}:channel:access:week:{week} 及时删除
    /// 日访问计月Key：    gbxx:{mark}:channel:access:month:{month} 及时删除
    /// </summary>
    public class WebChannelRedis : RedisRepository, IWebChannelRedis {
        private IRedisStore _IRedisStore;

        public WebChannelRedis(IRedisStore redisStore) : base(redisStore) {
            this._IRedisStore = redisStore;
        }

        public async Task<Tuple<bool, bool>> AddAccessCount(string mark, string id) {
            ///当前日期
            var day = System.DateTime.Now.ToString("yyyyMMdd");

            var accessKey = $"{_IRedisStore.PrefixKey}:{mark}:channel:access";
            var countKey = $"{_IRedisStore.PrefixKey}:{mark}:channel:access:all";

            var accessNumber = _IRedisStore.GetRandomNumber(accessKey);
            var countNumber = _IRedisStore.GetRandomNumber(countKey);
            // 日访key
            accessKey = $"{accessKey}:{day}";
            // SortSet日访问排行数据（+1）
            var dayResult = await _IRedisStore.Do(db => db.SortedSetIncrementAsync(accessKey, id, 1), accessNumber);
            var allResult = await _IRedisStore.Do(db => db.SortedSetIncrementAsync(countKey, id, 1), countNumber);

            return new Tuple<bool, bool>(dayResult > 0, allResult > 0);
        }
        public async Task<int> GetAccessCount(string mark, string id) {
            var countKey = $"{_IRedisStore.PrefixKey}:{mark}:channel:access:all";
            var countNumber = _IRedisStore.GetRandomNumber(countKey);
            var count = await _IRedisStore.Do(db => db.SortedSetScoreAsync(countKey, id), countNumber);
            if (!count.HasValue)
                count = 0;
            return (int)count;
        }

        public async Task<int> GetAccessDays(string mark, string id, DateTime? dt) {
            var p = GetDayAndPage(dt, 0, 0);

            var key = $"{_IRedisStore.PrefixKey}:{mark}:channel:access";
            var number = _IRedisStore.GetRandomNumber(key);

            key = $"{key}:{p.Item1}";

            var result = await _IRedisStore.Do(db => db.SortedSetScoreAsync(key, id), number);
            if (!result.HasValue)
                result = 0;
            return (int)result;
        }
        public async Task<int> GetAccessWeeks(string mark, string id, DateTime? dt) {
            var p = GetDayAndPage(dt, 0, 0);

            var key = $"{_IRedisStore.PrefixKey}:{mark}:channel:access";
            var number = _IRedisStore.GetRandomNumber(key);

            var week = GetWeekAndDays(null);
            var redisKeys = new RedisKey[week.Item3];
            for (int i = 0; i < week.Item3; i++) {
                redisKeys[i] = $"{key}:{week.Item1.AddDays(i).ToString("D2")}";
            }

            key = $"{key}:week:count:{week.Item1.Year}{week.Item2}";
            // 合并数据
            await _IRedisStore.Do(db => db.SortedSetCombineAndStoreAsync(SetOperation.Union, key, redisKeys), number);
            // 获取合并数据
            var result = await _IRedisStore.Do(db => db.SortedSetScoreAsync(key, id), number);
            // 删除合并数据
            await _IRedisStore.Do(db => db.KeyDeleteAsync(key), number);
            if (!result.HasValue)
                result = 0;
            return (int)result;
        }
        public async Task<int> GetAccessMonths(string mark, string id, DateTime? dt) {
            var p = GetDayAndPage(dt, 0, 0);

            var key = $"{_IRedisStore.PrefixKey}:{mark}:channel:access";
            var number = _IRedisStore.GetRandomNumber(key);

            var month = GetMonthAndDays(p.Item1);
            var redisKeys = new RedisKey[month.Item2];
            for (int i = 0; i < month.Item2; i++) {
                redisKeys[i] = $"{key}:{month.Item1.AddDays(i).ToString("D2")}";
            }

            key = $"{key}:month:count:{month.Item2.ToString("yyyyMM")}";
            // 合并数据
            await _IRedisStore.Do(db => db.SortedSetCombineAndStoreAsync(SetOperation.Union, key, redisKeys), number);
            // 获取合并数据
            var result = await _IRedisStore.Do(db => db.SortedSetScoreAsync(key, id), number);
            // 删除合并数据
            await _IRedisStore.Do(db => db.KeyDeleteAsync(key), number);
            if (!result.HasValue)
                result = 0;
            return (int)result;
        }

        public async Task<SortedSetEntry[]> GetAccessDays(string mark, DateTime? dt, int? pageIndex, int? pageSize) {
            var p = GetDayAndPage(dt, pageIndex, pageSize);
            var key = $"{_IRedisStore.PrefixKey}:{mark}:channel:access";

            return await GetDays(key, p);
        }
        public async Task<SortedSetEntry[]> GetAccessWeeks(string mark, DateTime? dt, int? pageIndex, int? pageSize) {
            var p = GetDayAndPage(dt, pageIndex, pageSize);
            var key = $"{_IRedisStore.PrefixKey}:{mark}:channel:access";

            return await GetWeeks(key, p);
        }
        public async Task<SortedSetEntry[]> GetAccessMonths(string mark, DateTime? dt, int? pageIndex, int? pageSize) {
            var p = GetDayAndPage(dt, pageIndex, pageSize);
            var key = $"{_IRedisStore.PrefixKey}:{mark}:channel:access";

            return await GetMonths(key, p);

        }
    }
}
