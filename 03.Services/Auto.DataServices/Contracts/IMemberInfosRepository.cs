using Auto.Commons.Ioc.IContract;
using Auto.Entities.Datas;

namespace Auto.DataServices.Contracts {
    public interface IMemberInfosRepository : IRepository<MemberInfos>, ISingletonInject {
    }
}
