using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Datas;

namespace Auto.DataServices.Repositories {
    public class WebCategoryRepository : Repository<WebCategory>, IWebCategoryRepository {
        public WebCategoryRepository(AutoNewsContext autoNewsContext) : base(autoNewsContext) {
        }
    }
}
