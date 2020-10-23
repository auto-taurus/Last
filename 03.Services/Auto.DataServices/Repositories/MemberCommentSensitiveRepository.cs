using System.Threading.Tasks;
using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Modals;

namespace Auto.DataServices.Repositories {
    public class MemberCommentSensitiveRepository : Repository<MemberCommentSensitive>, IMemberCommentSensitiveRepository {
        public MemberCommentSensitiveRepository(NewsContext newsContext) : base(newsContext) {
        }
    }
}
