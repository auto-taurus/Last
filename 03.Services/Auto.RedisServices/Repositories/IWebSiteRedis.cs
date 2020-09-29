using Auto.Commons.Ioc.IContract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.RedisServices.Repositories {
    public interface IWebSiteRedis : IRedisRepository, ISingletonInject {
    }
}
