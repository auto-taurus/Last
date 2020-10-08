using Auto.Commons.Extensions.Redis;
using Auto.Dto.RedisDto;
using Auto.RedisServices.Repositories;
using StackExchange.Redis;
using System;
using System.Threading.Tasks;

namespace Auto.RedisServices.Contracts {

    /// <summary>
    /// 站点信息Key：     site:info:{mark}
    /// 站点总访问排行Key：site:access:all
    /// 每日访问Key：     site:access:{day}
    /// 日访问计周排行Key：site:access:week:{week} week=202001 及时删除
    /// 日访问计月排行Key：site:access:month:{month} month=202001 及时删除
    /// </summary>
    public class WebSiteRedis : RedisRepository, IWebSiteRedis {
        private IRedisStore _IRedisStore;
        private String _customPrefix = "site";
        public WebSiteRedis(IRedisStore redisStore) : base(redisStore) {
            this._IRedisStore = redisStore;
        }

        public async Task<Tuple<bool, bool>> AddAccessCount(string mark) {
            ///当前日期
            var day = System.DateTime.Now.ToString("yyyyMMdd");

            var key = $"{_customPrefix}:access";
            var countKey = $"{_customPrefix}:access:all";

            var accessNumber = _IRedisStore.GetRandomNumber(key);
            var countNumber = _IRedisStore.GetRandomNumber(countKey);
            // 日访问Key
            key = $"{key}:{day}";
            // SortSet日访问排行数据（+1）
            var dayResult = await _IRedisStore.Do(db => db.SortedSetIncrementAsync(key, mark, 1), accessNumber);
            // SortSet总访问排行数据（+1）
            var allResult = await _IRedisStore.Do(db => db.SortedSetIncrementAsync(countKey, mark, 1), countNumber);

            return new Tuple<bool, bool>(dayResult > 0, allResult > 0);
        }
        public async Task<int> GetAccessCount(string mark) {
            var countKey = $"{_customPrefix}:access:all";
            var countNumber = _IRedisStore.GetRandomNumber(countKey);
            var count = await _IRedisStore.Do(db => db.SortedSetScoreAsync(countKey, mark), countNumber);
            if (!count.HasValue)
                count = 0;
            return (int)count;
        }

        public async Task<SortedSetEntry[]> GetAccessDays(string mark, DateTime? dt, int? pageIndex, int? pageSize) {
            var p = GetDayAndPage(dt, pageIndex, pageSize);
            var key = $"{_customPrefix}:access";

            return await GetDays(key, p);
        }
        public async Task<SortedSetEntry[]> GetAccessWeeks(string mark, DateTime? dt, int? pageIndex, int? pageSize) {
            var p = GetDayAndPage(dt, pageIndex, pageSize);
            var key = $"{_customPrefix}:access";

            return await GetWeeks(key, p);

        }
        public async Task<SortedSetEntry[]> GetAccessMonths(string mark, DateTime? dt, int? pageIndex, int? pageSize) {
            var p = GetDayAndPage(dt, pageIndex, pageSize);
            var key = $"{_customPrefix}:access";

            return await GetMonths(key, p);
        }

        /// <summary>
        /// 获取站点信息
        /// </summary>
        /// <param name="mark"></param>
        /// <returns></returns>
        public async Task<SiteDto> GetAsync(string mark) {
            var key = $"{_customPrefix}:{mark}";
            var number = _IRedisStore.GetRandomNumber(key);
            var result = await this._IRedisStore.Do(db => db.StringGetAsync(key), number);
            if (!result.HasValue)
                return default(SiteDto);
            return _IRedisStore.RedisValueToObject<SiteDto>(result);
        }
        /// <summary>
        /// 添加站点信息
        /// </summary>
        /// <param name="mark"></param>
        /// <returns></returns>
        public async Task<bool> AddAsync(string mark, SiteDto items) {
            var key = $"{_customPrefix}:{mark}";
            var number = _IRedisStore.GetRandomNumber(key);

            var json = _IRedisStore.ObjectToString(items);
            return await this._IRedisStore.Do(db => db.StringSetAsync(key, json), number);
        }
    }
}
