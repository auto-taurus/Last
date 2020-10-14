using Auto.Commons.Ioc.IContract;
using Auto.EFCore.Entities;

namespace Auto.DataServices.Contracts {
    public interface IMemberInfoRepository : IRepository<MemberInfo>, ISingletonInject {
    }
}
