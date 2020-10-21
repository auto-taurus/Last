using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Dtos;
using Auto.Entities.Modals;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auto.DataServices.Repositories {
    public class MemberProblemRepository : Repository<MemberProblem>, IMemberProblemRepository {
        public MemberProblemRepository(NewsContext newsContext) : base(newsContext) {

        }
        public async Task<IList<ProblemDto>> GetDists(List<int> distKey) {
            return await base.Query(a => distKey.Contains(a.Type.Value) && a.IsEnable == 1, a => a.Sequence)
                             .Select(a => new ProblemDto {
                                 ProblemId = a.ProblemId,
                                 Type = a.Type,
                                 Title = a.Title,
                                 Urls = a.Urls,
                                 Desc = a.Desc,
                                 IsHot = a.IsHot
                             }).ToListAsync();
        }
    }
}
