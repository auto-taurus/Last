using Auto.Commons.Ioc.IContract;
using Auto.Entities.Modals;

namespace Auto.DataServices.Contracts {
    public interface IMemberCommentRepository : IRepository<MemberComment>, ISingletonInject {
    }
}
