using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Modals;

namespace Auto.DataServices.Repositories {
    public class SystemUsersRepository : Repository<SystemUsers>, ISystemUsersRepository {
        public SystemUsersRepository(NewsContext newsContext) : base(newsContext) {
        }

    }
}
