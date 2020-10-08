using Auto.Commons.Ioc.IContract;
using Auto.Dto.RedisDto;
using StackExchange.Redis;
using System;
using System.Threading.Tasks;

namespace Auto.RedisServices.Repositories {
    public interface IWebSiteRedis : ISingletonInject {

        Task<Tuple<bool, bool>> AddAccessCount(string mark);
        Task<int> GetAccessCount(string mark);

        Task<SortedSetEntry[]> GetAccessDays(string mark, DateTime? dt, int? pageIndex, int? pageSize);
        Task<SortedSetEntry[]> GetAccessWeeks(string mark, DateTime? dt, int? pageIndex, int? pageSize);
        Task<SortedSetEntry[]> GetAccessMonths(string mark, DateTime? dt, int? pageIndex, int? pageSize);

        Task<SiteDto> GetAsync(string mark);
        Task<bool> AddAsync(string mark, SiteDto item);
    }
}
