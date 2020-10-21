using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Modals;

namespace Auto.DataServices.Repositories {
    public class MemberMessageRepository : Repository<MemberMessage>, IMemberMessageRepository {
        public MemberMessageRepository(NewsContext newsContext) : base(newsContext) {
        }
    }
}
