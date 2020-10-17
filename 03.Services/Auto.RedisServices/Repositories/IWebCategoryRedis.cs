using Auto.Commons.Ioc.IContract;
using  Auto.RedisServices.Entities;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Auto.RedisServices.Repositories {
    public interface IWebCategoryRedis : ISingletonInject {

        Task<bool> AddClickCount(int mark, string id);
        Task<Tuple<bool, bool>> AddAccessCount(int mark, string id);
        Task<int> GetAccessCount(int mark, string id);

        Task<SortedSetEntry[]> GetClickDays(int mark, DateTime? dt, int? pageIndex, int? pageSize);
        Task<SortedSetEntry[]> GetClickWeeks(int mark, DateTime? dt, int? pageIndex, int? pageSize);
        Task<SortedSetEntry[]> GetClickMonths(int mark, DateTime? dt, int? pageIndex, int? pageSize);

        Task<SortedSetEntry[]> GetAccessDays(int mark, DateTime? dt, int? pageIndex, int? pageSize);
        Task<SortedSetEntry[]> GetAccessWeeks(int mark, DateTime? dt, int? pageIndex, int? pageSize);
        Task<SortedSetEntry[]> GetAccessMonths(int mark, DateTime? dt, int? pageIndex, int? pageSize);

        Task<List<WebCategoryValue>> GetAsync(int mark);
        Task<bool> AddAsync(int mark, List<WebCategoryValue> items);
    }
}
