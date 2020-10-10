using Auto.Commons.Ioc.IContract;
using  Auto.CacheEntities.ElasticDoc;

namespace Auto.ElasticServices.Contracts {
    public interface IWebNewsElastic : IElasticRepository<WebNewsDoc>, ISingletonInject {

    }
}
