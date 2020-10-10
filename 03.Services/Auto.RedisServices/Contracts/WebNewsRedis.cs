using Auto.Commons.Extensions.Redis;
using Auto.RedisServices.Repositories;
using StackExchange.Redis;
using System;
using System.Threading.Tasks;

namespace Auto.RedisServices.Contracts {
    /// <summary>
    /// 总访问Key：PrefixKey:{mark}:news:access:all
    /// 点击随机数据库Key：PrefixKey:{mark}:news:click
    /// 每日点击Key：PrefixKey:{mark}:news:click:{day}
    /// 日点击统计周排行Key：PrefixKey:{mark}:news:click:week:{week} 及时删除
    /// 日点击统计月排行Key：PrefixKey:{mark}:news:click:month:{month} 及时删除
    /// 访问随机数据库Key：PrefixKey:{mark}:news:access 
    /// 每日访问Key：PrefixKey:{mark}:news:access:{day}
    /// 日访问计周排行Key：PrefixKey:{mark}:news:access:week:{week} 及时删除
    /// 日访问计月排行Key：PrefixKey:{mark}:news:access:month:{month} 及时删除
    /// </summary>
    public class WebNewsRedis : RedisRepository, IWebNewsRedis {
        private IRedisStore _IRedisStore;

        public WebNewsRedis(IRedisStore redisStore) {
            this._IRedisStore = redisStore;
        }

        public async Task<bool> AddClickCount(int mark, string id) {
            var flag = false;

            var day = System.DateTime.Now.ToString("yyyyMMdd");// 当前日期

            var key = $"{_IRedisStore.PrefixKey}:{mark}:news:click";
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

            var accessKey = $"{_IRedisStore.PrefixKey}:{mark}:news:access";
            var countKey = $"{_IRedisStore.PrefixKey}:{mark}:news:access:all";

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
            var countKey = $"{_IRedisStore.PrefixKey}:{mark}:news:access:all";
            var countNumber = _IRedisStore.GetRandomNumber(countKey);
            var count = await _IRedisStore.Do(db => db.SortedSetScoreAsync(countKey, id), countNumber);
            if (!count.HasValue)
                count = 0;
            return (int)count;
        }

        public async Task<SortedSetEntry[]> GetClickDays(int mark, DateTime? dt, int? pageIndex, int? pageSize) {
            var p = GetDayAndPage(dt, pageIndex, pageSize);
            var key = $"{_IRedisStore.PrefixKey}:{mark}:news:click";

            return await GetDays(key, p);
        }
        public async Task<SortedSetEntry[]> GetClickWeeks(int mark, DateTime? dt, int? pageIndex, int? pageSize) {
            var p = GetDayAndPage(dt, pageIndex, pageSize);
            var key = $"{_IRedisStore.PrefixKey}:{mark}:news:click";

            return await GetWeeks(key, p);
        }
        public async Task<SortedSetEntry[]> GetClickMonths(int mark, DateTime? dt, int? pageIndex, int? pageSize) {
            var p = GetDayAndPage(dt, pageIndex, pageSize);
            var key = $"{_IRedisStore.PrefixKey}:{mark}:news:click";

            return await GetMonths(key, p);
        }

        public async Task<SortedSetEntry[]> GetAccessDays(int mark, DateTime? dt, int? pageIndex, int? pageSize) {
            var p = GetDayAndPage(dt, pageIndex, pageSize);
            var key = $"{_IRedisStore.PrefixKey}:{mark}:news:access";

            return await GetDays(key, p);
        }
        public async Task<SortedSetEntry[]> GetAccessWeeks(int mark, DateTime? dt, int? pageIndex, int? pageSize) {
            var p = GetDayAndPage(dt, pageIndex, pageSize);
            var key = $"{_IRedisStore.PrefixKey}:{mark}:news:access";

            return await GetWeeks(key, p);
        }
        public async Task<SortedSetEntry[]> GetAccessMonths(int mark, DateTime? dt, int? pageIndex, int? pageSize) {
            var p = GetDayAndPage(dt, pageIndex, pageSize);
            var key = $"{_IRedisStore.PrefixKey}:{mark}:news:access";

            return await GetMonths(key, p);

        }
    }

}
