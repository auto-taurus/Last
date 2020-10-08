using Auto.Commons.Ioc.IContract;
using Auto.Dto.ElasticDoc;

namespace Auto.ElasticServices.Contracts {
    public interface IWebNewsElastic : IElasticRepository<NewsDoc>, ISingletonInject {

    }
}
