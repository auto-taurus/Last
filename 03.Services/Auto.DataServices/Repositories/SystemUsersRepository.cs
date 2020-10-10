using Auto.DataServices.Contracts;
using Auto.EFCore;
using Auto.EFCore.Entities;

namespace Auto.DataServices.Repositories {
    public class SystemUsersRepository : Repository<SystemUsers>, ISystemUsersRepository {
        public SystemUsersRepository(AutoNewsContext AutoNewsContext) : base(AutoNewsContext) {
        }

    }
}
