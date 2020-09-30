using Auto.Commons.Ioc.IContract;
using StackExchange.Redis;

namespace Auto.Commons.Extensions.Redis {
    public interface IRedisStore : ISingletonInject {
        /// <summary>
        /// 获取默认实例
        /// </summary>
        ConnectionMultiplexer Instance { get; }
        /// <summary>
        /// 获取指定实例
        /// </summary>
        /// <param name="nodeServer"></param>
        /// <returns></returns>
        ConnectionMultiplexer GetInstance(string nodeServer = null);
        /// <summary>
        /// 获取默认实例数据库
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        IDatabaseAsync GetDatabase(int? number = null);
    }
}
