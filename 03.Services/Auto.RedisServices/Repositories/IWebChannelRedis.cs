using Auto.Commons.Ioc.IContract;
using StackExchange.Redis;
using System;
using System.Threading.Tasks;

namespace Auto.RedisServices.Repositories {
    public interface IWebChannelRedis : ISingletonInject {
        Task<Tuple<bool, bool>> AddAccessCount(string mark, string id);
        Task<int> GetAccessCount(string mark, string id);

        Task<int> GetAccessDays(string mark, string id, DateTime? dt);
        Task<int> GetAccessWeeks(string mark, string id, DateTime? dt);
        Task<int> GetAccessMonths(string mark, string id, DateTime? dt);

        Task<SortedSetEntry[]> GetAccessDays(string mark, DateTime? dt, int? pageIndex, int? pageSize);
        Task<SortedSetEntry[]> GetAccessWeeks(string mark, DateTime? dt, int? pageIndex, int? pageSize);
        Task<SortedSetEntry[]> GetAccessMonths(string mark, DateTime? dt, int? pageIndex, int? pageSize);

    }
}
