using Auto.Commons.Ioc.IContract;
using  Auto.ElasticServices.Modals;

namespace Auto.ElasticServices.Contracts {
    public interface IWebNewsElastic : IElasticRepository<WebNewsDoc>, ISingletonInject {

    }
}
