using Auto.Commons.Ioc.IContract;
using Auto.Entities.Modals;
using System.Threading.Tasks;

namespace Auto.DataServices.Contracts {
    public interface IMemberCommentSensitiveRepository : IRepository<MemberCommentSensitive>, ISingletonInject {
    }
}
