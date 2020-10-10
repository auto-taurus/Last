using Auto.Commons.Ioc.IContract;
using StackExchange.Redis;
using System;
using System.Threading.Tasks;

namespace Auto.RedisServices.Repositories {
    public interface IWebChannelRedis : ISingletonInject {
        Task<Tuple<bool, bool>> AddAccessCount(int mark, string id);
        Task<int> GetAccessCount(int mark, string id);

        Task<int> GetAccessDays(int mark, string id, DateTime? dt);
        Task<int> GetAccessWeeks(int mark, string id, DateTime? dt);
        Task<int> GetAccessMonths(int mark, string id, DateTime? dt);

        Task<SortedSetEntry[]> GetAccessDays(int mark, DateTime? dt, int? pageIndex, int? pageSize);
        Task<SortedSetEntry[]> GetAccessWeeks(int mark, DateTime? dt, int? pageIndex, int? pageSize);
        Task<SortedSetEntry[]> GetAccessMonths(int mark, DateTime? dt, int? pageIndex, int? pageSize);

    }
}
