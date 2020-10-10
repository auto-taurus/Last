using Auto.Commons.Ioc.IContract;
using  Auto.CacheEntities.RedisValues;
using StackExchange.Redis;
using System;
using System.Threading.Tasks;

namespace Auto.RedisServices.Repositories {
    public interface IWebSiteRedis : ISingletonInject {

        Task<Tuple<bool, bool>> AddAccessCount(int mark);
        Task<int> GetAccessCount(int mark);

        Task<SortedSetEntry[]> GetAccessDays(int mark, DateTime? dt, int? pageIndex, int? pageSize);
        Task<SortedSetEntry[]> GetAccessWeeks(int mark, DateTime? dt, int? pageIndex, int? pageSize);
        Task<SortedSetEntry[]> GetAccessMonths(int mark, DateTime? dt, int? pageIndex, int? pageSize);

        Task<WebSiteValue> GetAsync(int mark);
        Task<bool> AddAsync(int mark, WebSiteValue item);
    }
}
