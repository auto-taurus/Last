using Auto.Commons.Ioc.IContract;
using Auto.Entities.Dtos;
using Auto.Entities.Modals;
using System.Threading.Tasks;

namespace Auto.DataServices.Contracts {
    public interface IMemberInfosRepository : IRepository<MemberInfos>, IScopedInject {
        Task<MemberAppDto> GetAppInfo(int memberId);
    }
}
