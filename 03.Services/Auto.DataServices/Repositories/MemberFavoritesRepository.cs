using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Modals;

namespace Auto.DataServices.Repositories {
    public class MemberFavoritesRepository : Repository<MemberFavorites>, IMemberFavoritesRepository {
        public MemberFavoritesRepository(NewsContext newsContext) : base(newsContext) {
        }
    }
}
