using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Modals;

namespace Auto.DataServices.Repositories {
    public class MemberCommentUpRepository : Repository<MemberCommentUp>, IMemberCommentUpRepository {
        public MemberCommentUpRepository(NewsContext newsContext) : base(newsContext) {
        }
    }
}
