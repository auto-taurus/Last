using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Datas;

namespace Auto.DataServices.Repositories {
    public class WebSpecialRepository : Repository<WebSpecial>, IWebSpecialRepository {
        public WebSpecialRepository(AutoNewsContext autoNewsContext) : base(autoNewsContext) {

        }

    }
}
