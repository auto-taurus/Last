using Auto.Commons;
using Auto.Commons.Extensions.Redis;
using Auto.RedisServices.Repositories;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Auto.RedisServices.Contracts {
    /// <summary>
    /// 日点击Key：PrefixKey:{mark}:news:click:{day}
    /// 日访问Key：PrefixKey:{mark}:news:access:{day}
    /// 总访问Key：PrefixKey:{mark}:news:access:all
    /// 日点击统计周Key：PrefixKey:{mark}:news:click:week:{week} 及时删除
    /// 日点击统计月Key：PrefixKey:{mark}:news:click:month:{month}
    /// 日点访问计周Key：PrefixKey:{mark}:news:access:week:{week} 及时删除
    /// 日点访问计月Key：PrefixKey:{mark}:news:access:month:{month}
    /// </summary>
    public class WebNewsRedis : RedisBase, IWebNewsRedis {
        private IRedisStore _IRedisStore;
        public WebNewsRedis(IRedisStore redisStore) {
            this._IRedisStore = redisStore;
        }

        public async Task<bool> AddClickCount(string mark, string newsId) {
            var flag = false;

            var day = System.DateTime.Now.ToString("yyyyMMdd");// 当前日期

            var clickKey = $"{_IRedisStore.PrefixKey}{mark}:news:click";
            var number = _IRedisStore.GetRandomNumber(clickKey);

            var dayClickKey = $"{clickKey}:{day}";// 日点击信息key
            // SortSet日点击排行数据（+1）
            var result = await _IRedisStore.Do(db => db.SortedSetIncrementAsync(dayClickKey, newsId, 1), number);
            return flag;

        }
        public async Task<bool> AddAccessCount(string mark, string newsId) {
            var flag = false;
            ///当前日期
            var day = System.DateTime.Now.ToString("yyyyMMdd");

            var accessKey = $"{_IRedisStore.PrefixKey}{mark}:news:access";
            var countKey = $"{_IRedisStore.PrefixKey}{mark}:news:access:all";

            var accessNumber = _IRedisStore.GetRandomNumber(accessKey);
            var countNumber = _IRedisStore.GetRandomNumber(countKey);

            accessKey = $"{accessKey}:{day}";
            // SortSet日访问排行数据（+1）
            await _IRedisStore.Do(db => db.SortedSetIncrementAsync(accessKey, newsId, 1), accessNumber);
            // SortSet总访问排行数据（+1）
            await _IRedisStore.Do(db => db.SortedSetIncrementAsync(countKey, newsId, 1), countNumber);

            return flag;
        }
        public async Task<int> GetAccessCount(string mark, string newsId) {
            var countKey = $"{_IRedisStore.PrefixKey}{mark}:news:access:all";
            var countNumber = _IRedisStore.GetRandomNumber(countKey);
            var count = await _IRedisStore.Do(db => db.SortedSetScoreAsync(countKey, newsId), countNumber);
            if (!count.HasValue)
                count = 0;
            return (int)count;
        }

        public async Task<SortedSetEntry[]> GetClickDays(string mark, DateTime? dt, int? pageIndex, int? pageSize) {
            var p = GetDayAndPage(dt, pageIndex, pageSize);

            var clickKey = $"{_IRedisStore.PrefixKey}{mark}:news:click";
            var number = _IRedisStore.GetRandomNumber(clickKey);

            clickKey = $"{clickKey}:{p.Item1}";

            var result = await _IRedisStore.Do(db => db.SortedSetRangeByRankWithScoresAsync(clickKey, p.Item2, p.Item3, Order.Descending));
            return result;
        }
        public async Task<SortedSetEntry[]> GetClickWeeks(string mark, DateTime? dt, int? pageIndex, int? pageSize) {
            var p = GetDayAndPage(dt, pageIndex, pageSize);

            var clickKey = $"{_IRedisStore.PrefixKey}{mark}:news:click";
            var number = _IRedisStore.GetRandomNumber(clickKey);

            var week = DateTimeHelper.GetWeekAndDays(dt);
            var keys = new RedisKey[week.Item5];
            for (int i = 0; i < week.Item5; i++) { //年，月,日
                var day = $"{clickKey}:{week.Item1}{week.Item2}{(week.Item4 + i).ToString("D2")}";
                keys[i] = day;
            }

            clickKey = $"{clickKey}:week:{week.Item3}";
            // 统计数据
            await _IRedisStore.Do(db => db.SortedSetCombineAndStoreAsync(SetOperation.Union, clickKey, keys));
            // 获取数据
            var result = await _IRedisStore.Do(db => db.SortedSetRangeByRankWithScoresAsync(clickKey, p.Item2, p.Item3, Order.Descending));
            // 删除统计数据
            await _IRedisStore.Do(db => db.KeyDeleteAsync(clickKey));
            return result;
        }
        public async Task<SortedSetEntry[]> GetClickMonths(string mark, DateTime? dt, int? pageIndex, int? pageSize) {
            var p = GetDayAndPage(dt, pageIndex, pageSize);

            var clickKey = $"{_IRedisStore.PrefixKey}{mark}:news:click";
            var number = _IRedisStore.GetRandomNumber(clickKey);

            var month = DateTimeHelper.GetMonthAndDays(dt);
            var keys = new RedisKey[month.Item3];
            for (int i = 0; i < month.Item3; i++) {
                var day = $"{clickKey}:{month.Item1}{month.Item2}{(i + 1).ToString("D2")}";
                keys[i] = day;
            }

            clickKey = $"{clickKey}:month:{month.Item2}";
            // 统计数据
            await _IRedisStore.Do(db => db.SortedSetCombineAndStoreAsync(SetOperation.Union, clickKey, keys));
            // 获取数据
            var result = await _IRedisStore.Do(db => db.SortedSetRangeByRankWithScoresAsync(clickKey, p.Item2, p.Item3, Order.Descending));
            // 删除统计数据
            await _IRedisStore.Do(db => db.KeyDeleteAsync(clickKey));
            return result;
        }

        public async Task<SortedSetEntry[]> GetAccessDays(string mark, DateTime? dt, int? pageIndex, int? pageSize) {
            var p = GetDayAndPage(dt, pageIndex, pageSize);

            var clickKey = $"{_IRedisStore.PrefixKey}{mark}:news:access";
            var number = _IRedisStore.GetRandomNumber(clickKey);

            clickKey = $"{clickKey}:{p.Item1}";

            var result = await _IRedisStore.Do(db => db.SortedSetRangeByRankWithScoresAsync(clickKey, p.Item2, p.Item3, Order.Descending));
            return result;
        }
        public async Task<SortedSetEntry[]> GetAccessWeeks(string mark, DateTime? dt, int? pageIndex, int? pageSize) {
            var p = GetDayAndPage(dt, pageIndex, pageSize);

            var clickKey = $"{_IRedisStore.PrefixKey}{mark}:news:access";
            var number = _IRedisStore.GetRandomNumber(clickKey);

            var week = DateTimeHelper.GetWeekAndDays(dt);
            var keys = new RedisKey[week.Item5];
            for (int i = 0; i < week.Item5; i++) { //年，月,日
                var day = $"{clickKey}:{week.Item1}{week.Item2}{(week.Item4 + i).ToString("D2")}";
                keys[i] = day;
            }

            clickKey = $"{clickKey}:week:{week.Item3}";
            // 统计数据
            await _IRedisStore.Do(db => db.SortedSetCombineAndStoreAsync(SetOperation.Union, clickKey, keys));
            // 获取数据
            var result = await _IRedisStore.Do(db => db.SortedSetRangeByRankWithScoresAsync(clickKey, p.Item2, p.Item3, Order.Descending));
            // 删除统计数据
            await _IRedisStore.Do(db => db.KeyDeleteAsync(clickKey));
            return result;
        }
        public async Task<SortedSetEntry[]> GetAccessMonths(string mark, DateTime? dt, int? pageIndex, int? pageSize) {
            var p = GetDayAndPage(dt, pageIndex, pageSize);

            var clickKey = $"{_IRedisStore.PrefixKey}{mark}:news:access";
            var number = _IRedisStore.GetRandomNumber(clickKey);

            var month = DateTimeHelper.GetMonthAndDays(dt);
            var keys = new RedisKey[month.Item3];
            for (int i = 0; i < month.Item3; i++) {
                var day = $"{clickKey}:{month.Item1}{month.Item2}{(i + 1).ToString("D2")}";
                keys[i] = day;
            }

            clickKey = $"{clickKey}:month:{month.Item2}";
            // 统计数据
            await _IRedisStore.Do(db => db.SortedSetCombineAndStoreAsync(SetOperation.Union, clickKey, keys));
            // 获取数据
            var result = await _IRedisStore.Do(db => db.SortedSetRangeByRankWithScoresAsync(clickKey, p.Item2, p.Item3, Order.Descending));
            // 删除统计数据
            await _IRedisStore.Do(db => db.KeyDeleteAsync(clickKey));
            return result;
        }
    }

}
