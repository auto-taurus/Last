using Auto.Commons.Ioc.IContract;
using Auto.EFCore.Entities;

namespace Auto.DataServices.Contracts {
    public interface ISystemUsersRepository : IRepository<SystemUsers>, ISingletonInject {
    }
}
