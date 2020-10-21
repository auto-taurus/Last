using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Modals;

namespace Auto.DataServices.Repositories {
    public class MemberFootprintRepository : Repository<MemberFootprint>, IMemberFootprintRepository {
        public MemberFootprintRepository(NewsContext newsContext) : base(newsContext) {
        }
    }
}
