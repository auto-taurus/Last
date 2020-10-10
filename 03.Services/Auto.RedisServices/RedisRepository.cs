using Auto.Commons;
using Auto.Commons.DateTimeExtens;
using Auto.Commons.Extensions.Redis;
using StackExchange.Redis;
using System;
using System.Globalization;
using System.Threading.Tasks;

namespace Auto.RedisServices {
    public class RedisRepository {
        private IRedisStore _IRedisStore;

        public RedisRepository() {

        }
        public RedisRepository(IRedisStore redisStore) {
            this._IRedisStore = redisStore;
        }

        public async Task<SortedSetEntry[]> GetDays(string key, Tuple<DateTime, int, int> tuple) {
            var number = _IRedisStore.GetRandomNumber(key);
            key = $"{key}:{tuple.Item1.ToString("yyyyMMdd")}";
            return await _IRedisStore.Do(db => db.SortedSetRangeByRankWithScoresAsync(key, tuple.Item2, tuple.Item3, Order.Descending), number);
        }
        public async Task<SortedSetEntry[]> GetWeeks(string key, Tuple<DateTime, int, int> tuple) {
            var number = _IRedisStore.GetRandomNumber(key);
            var week = GetWeekAndDays(tuple.Item1);

            var redisKeys = new RedisKey[week.Item3];
            for (int i = 0; i < week.Item3; i++) {
                redisKeys[i] = $"{key}:{week.Item1.AddDays(i).ToString("yyyyMMdd")}";
            }
            key = $"{key}:week:{week.Item1.Year}{week.Item2}";

            // 合并周数据
            await _IRedisStore.Do(db => db.SortedSetCombineAndStoreAsync(SetOperation.Union, key, redisKeys), number);
            // 获取周数据
            var result = await _IRedisStore.Do(db => db.SortedSetRangeByRankWithScoresAsync(key, tuple.Item2, tuple.Item3, Order.Descending), number);
            // 删除周数据
            await _IRedisStore.Do(db => db.KeyDeleteAsync(key), number);
            return result;
        }
        public async Task<SortedSetEntry[]> GetMonths(string key, Tuple<DateTime, int, int> tuple) {
            var number = _IRedisStore.GetRandomNumber(key);
            var month = GetMonthAndDays(tuple.Item1);
            var redisKeys = new RedisKey[month.Item2];
            for (int i = 0; i < month.Item2; i++) {
                redisKeys[i] = $"{key}:{month.Item1.AddDays(i).ToString("yyyyMMdd")}";
            }

            key = $"{key}:month:{month.Item1.ToString("yyyyMM")}";
            // 统计数据
            await _IRedisStore.Do(db => db.SortedSetCombineAndStoreAsync(SetOperation.Union, key, redisKeys), number);
            // 获取数据
            var result = await _IRedisStore.Do(db => db.SortedSetRangeByRankWithScoresAsync(key, tuple.Item2, tuple.Item3, Order.Descending), number);
            // 删除统计数据
            await _IRedisStore.Do(db => db.KeyDeleteAsync(key), number);
            return result;
        }

        /// <summary>
        /// 获取指定日期周一、在年中为第几周，周的天数
        /// </summary> 
        /// <returns></returns>
        protected Tuple<DateTime, string, int> GetWeekAndDays(DateTime? dateTime = null) {
            // 当前时间
            var day = dateTime.HasValue ? dateTime.Value : System.DateTime.Now;
            // 周一
            var monday = DateTimeHelper.GetWeekFirstDaySun(day);
            // 获取指定日期在年中为第几周
            int week = System.Threading.Thread.CurrentThread.CurrentUICulture.Calendar.GetWeekOfYear(day, CalendarWeekRule.FirstDay, DayOfWeek.Monday);

            return new Tuple<DateTime, string, int>(monday, week.ToString("D2"), 7);
        }
        /// <summary>
        /// 获取指定日期月份的第一天、月份的天数
        /// </summary>
        /// <returns></returns>
        protected Tuple<DateTime, int> GetMonthAndDays(DateTime? dateTime = null) {
            // 当前时间
            var day = dateTime.HasValue ? dateTime.Value : System.DateTime.Now;
            // 月份的第一天
            var firstDay = new DateTime(day.Year, day.Month, 1);
            // 月份的天数
            int days = System.Threading.Thread.CurrentThread.CurrentUICulture.Calendar.GetDaysInMonth(day.Year, day.Month);
            return new Tuple<DateTime, int>(firstDay, days);
        }
        /// <summary>
        /// redis分页参数处理
        /// </summary>
        /// <param name="dt">日期</param>
        /// <param name="pageIndex">当前页</param>
        /// <param name="pageSize">页大小</param>
        /// <returns>
        /// item1 - yyyyMMdd（20200101）
        /// item2 - 1（处理后的当前页）
        /// item2 - 2（处理后的页大小）
        /// </returns>
        protected Tuple<DateTime, int, int> GetDayAndPage(DateTime? dt, int? pageIndex, int? pageSize) {
            var day = dt.HasValue ? dt.Value : System.DateTime.Now;

            if (!pageIndex.HasValue) pageIndex = 1;
            if (!pageSize.HasValue) pageSize = 10;

            pageIndex = pageSize.Value * (pageIndex.Value - 1);
            pageSize = pageIndex + (pageSize - 1);
            return new Tuple<DateTime, int, int>(day, pageIndex.Value, pageSize.Value);
        }
    }
}
