using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Datas;

namespace Auto.DataServices.Repositories {
    public class WebSiteRepository : Repository<WebSite>, IWebSiteRepository {
        public WebSiteRepository(AutoNewsContext  autoNewsContext) : base(autoNewsContext) {
        }
    }
}
