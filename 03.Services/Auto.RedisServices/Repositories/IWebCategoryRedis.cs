using Auto.Commons.Ioc.IContract;
using Auto.Dto.RedisDto;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Auto.RedisServices.Repositories {
    public interface IWebCategoryRedis : ISingletonInject {

        Task<bool> AddClickCount(string mark, string id);
        Task<Tuple<bool, bool>> AddAccessCount(string mark, string id);
        Task<int> GetAccessCount(string mark, string id);

        Task<SortedSetEntry[]> GetClickDays(string mark, DateTime? dt, int? pageIndex, int? pageSize);
        Task<SortedSetEntry[]> GetClickWeeks(string mark, DateTime? dt, int? pageIndex, int? pageSize);
        Task<SortedSetEntry[]> GetClickMonths(string mark, DateTime? dt, int? pageIndex, int? pageSize);

        Task<SortedSetEntry[]> GetAccessDays(string mark, DateTime? dt, int? pageIndex, int? pageSize);
        Task<SortedSetEntry[]> GetAccessWeeks(string mark, DateTime? dt, int? pageIndex, int? pageSize);
        Task<SortedSetEntry[]> GetAccessMonths(string mark, DateTime? dt, int? pageIndex, int? pageSize);

        Task<List<CategoryDto>> GetAsync(string mark);
        Task<bool> AddAsync(string mark, List<CategoryDto> items);
    }
}
