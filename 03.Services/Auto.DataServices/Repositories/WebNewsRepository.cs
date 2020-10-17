using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Datas;

namespace Auto.DataServices.Repositories {
    public class WebNewsRepository : Repository<WebNews>, IWebNewsRepository {
        public WebNewsRepository(AutoNewsContext autoNewsContext) : base(autoNewsContext) {
        }

    }
}
