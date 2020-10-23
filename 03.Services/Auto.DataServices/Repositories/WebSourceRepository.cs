using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Modals;

namespace Auto.DataServices.Repositories {
    public class WebSourceRepository : Repository<WebSource>, IWebSourceRepository {
        public WebSourceRepository(NewsContext newsContext) : base(newsContext) {

        }

    }
}
