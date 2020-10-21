using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Modals;

namespace Auto.DataServices.Repositories {
    public class WebNewsRepository : Repository<WebNews>, IWebNewsRepository {
        public WebNewsRepository(NewsContext newsContext) : base(newsContext) {
        }

    }
}
