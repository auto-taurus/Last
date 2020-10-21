using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Modals;

namespace Auto.DataServices.Repositories {
    public class MemberWithdrawConfigRepository : Repository<MemberWithdrawConfig>, IMemberWithdrawConfigRepository {
        public MemberWithdrawConfigRepository(NewsContext newsContext) : base(newsContext) {
        }
    }
}
