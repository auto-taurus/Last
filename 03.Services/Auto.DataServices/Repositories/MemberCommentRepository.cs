using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Modals;

namespace Auto.DataServices.Repositories {
    public class MemberCommentRepository : Repository<MemberComment>, IMemberCommentRepository {
        public MemberCommentRepository(NewsContext newsContext) : base(newsContext) {
        }
    }
}
