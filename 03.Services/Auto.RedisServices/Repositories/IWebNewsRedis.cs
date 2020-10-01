using Auto.Commons.Ioc.IContract;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Auto.RedisServices.Repositories {
    public interface IWebNewsRedis : ISingletonInject {
        Task<bool> AddClickCount(string mark, string newsId);
        Task<bool> AddAccessCount(string mark, string newsId);
        Task<int> GetAccessCount(string mark, string newsId);
        Task<SortedSetEntry[]> GetClickDays(string mark, DateTime? dt, int? pageIndex, int? pageSize);
        Task<SortedSetEntry[]> GetClickWeeks(string mark, DateTime? dt, int? pageIndex, int? pageSize);
        Task<SortedSetEntry[]> GetClickMonths(string mark, DateTime? dt, int? pageIndex, int? pageSize);
    }
}
