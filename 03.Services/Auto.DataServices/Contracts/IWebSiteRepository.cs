using Auto.Commons.Ioc.IContract;
using Auto.Entities.Modals;

namespace Auto.DataServices.Contracts {
    public interface IWebSiteRepository : IRepository<WebSite>, ISingletonInject {
    }
}
