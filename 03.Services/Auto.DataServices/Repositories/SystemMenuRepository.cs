using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Modals;

namespace Auto.DataServices.Repositories {
    public class SystemMenuRepository : Repository<SystemMenu>, ISystemMenuRepository {
        public SystemMenuRepository(NewsContext newsContext) : base(newsContext) {
        }
    }
}
