using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Modals;

namespace Auto.DataServices.Repositories {
    public class MemberWithdrawRepository : Repository<MemberWithdraw>, IMemberWithdrawRepository {
        public MemberWithdrawRepository(NewsContext newsContext) : base(newsContext) {
        }
    }
}
