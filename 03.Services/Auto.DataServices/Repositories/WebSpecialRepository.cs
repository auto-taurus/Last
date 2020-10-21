using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Modals;

namespace Auto.DataServices.Repositories {
    public class WebSpecialRepository : Repository<WebSpecial>, IWebSpecialRepository {
        public WebSpecialRepository(NewsContext newsContext) : base(newsContext) {

        }

    }
}
