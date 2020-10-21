using Auto.Commons.Ioc.IContract;
using Auto.Entities.Modals;

namespace Auto.DataServices.Contracts {
    public interface IMemberFavoritesRepository : IRepository<MemberFavorites>, ISingletonInject {
    }
}
