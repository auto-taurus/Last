using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Modals;

namespace Auto.DataServices.Repositories {
    public class MemberFollowRepository : Repository<MemberFollow>, IMemberFollowRepository {
        public MemberFollowRepository(NewsContext newsContext) : base(newsContext) {
        }
    }
}
