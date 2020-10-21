using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Modals;

namespace Auto.DataServices.Repositories {
    public class MemberInfosRepository : Repository<MemberInfos>, IMemberInfosRepository {
        public MemberInfosRepository(NewsContext newsContext) : base(newsContext) {
        }

    }
}
