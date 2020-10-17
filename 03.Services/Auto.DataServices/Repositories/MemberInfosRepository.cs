using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Datas;

namespace Auto.DataServices.Repositories {
    public class MemberInfosRepository : Repository<MemberInfos>, IMemberInfosRepository {
        public MemberInfosRepository(AutoNewsContext autoNewsContext) : base(autoNewsContext) {
        }

    }
}
