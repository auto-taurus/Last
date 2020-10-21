using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Modals;

namespace Auto.DataServices.Repositories {
    public class WebSiteRepository : Repository<WebSite>, IWebSiteRepository {
        public WebSiteRepository(NewsContext  newsContext) : base(newsContext) {
        }
    }
}
