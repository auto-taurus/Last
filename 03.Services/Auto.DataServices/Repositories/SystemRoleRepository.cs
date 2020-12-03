using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Modals;

namespace Auto.DataServices.Repositories {
    public class SystemRoleRepository : Repository<SystemRole>, ISystemRoleRepository {
        public SystemRoleRepository(NewsContext newsContext) : base(newsContext) {

        }
    }
}
