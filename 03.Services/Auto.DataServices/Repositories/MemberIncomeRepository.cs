using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Modals;

namespace Auto.DataServices.Repositories {
    public class MemberIncomeRepository : Repository<MemberIncome>, IMemberIncomeRepository {
        public MemberIncomeRepository(NewsContext newsContext) : base(newsContext) {
        }
    }
}
