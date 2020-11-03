using Auto.Commons.Ioc.IContract;
using Auto.Entities.Dtos;
using Auto.Entities.Modals;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Auto.DataServices.Contracts {
    public interface IMemberProblemRepository : IRepository<MemberProblem>, IScopedInject {
        Task<IList<ProblemDto>> GetDists(List<int> distKey);
    }
}
