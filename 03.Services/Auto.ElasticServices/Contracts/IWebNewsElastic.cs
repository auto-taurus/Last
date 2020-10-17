using Auto.Commons.Ioc.IContract;
using  Auto.ElasticServices.Entities;

namespace Auto.ElasticServices.Contracts {
    public interface IWebNewsElastic : IElasticRepository<WebNewsDoc>, ISingletonInject {

    }
}
