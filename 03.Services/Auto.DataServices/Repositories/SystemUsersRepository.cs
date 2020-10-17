using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Datas;

namespace Auto.DataServices.Repositories {
    public class SystemUsersRepository : Repository<SystemUsers>, ISystemUsersRepository {
        public SystemUsersRepository(AutoNewsContext autoNewsContext) : base(autoNewsContext) {
        }

    }
}
