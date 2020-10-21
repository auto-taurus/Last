using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Modals;

namespace Auto.DataServices.Repositories {
    public class WebCategoryRepository : Repository<WebCategory>, IWebCategoryRepository {
        public WebCategoryRepository(NewsContext newsContext) : base(newsContext) {
        }
    }
}
