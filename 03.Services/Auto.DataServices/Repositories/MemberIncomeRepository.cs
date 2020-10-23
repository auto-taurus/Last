using Auto.Commons.Linq;
using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Dtos;
using Auto.Entities.Modals;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Auto.DataServices.Repositories {
    public class MemberIncomeRepository : Repository<MemberIncome>, IMemberIncomeRepository {
        public MemberIncomeRepository(NewsContext newsContext) : base(newsContext) {
        }

        public async Task<IList<IncomeAppDto>> GetAppPagerAsync(Expression<Func<MemberIncome, bool>> predicate, int pageIndex, int pageSize) {
            predicate = predicate.And(a => a.Status == 0);
            return await base.Query(predicate)
                             .OrderByDescending(a => a.CreateTime)
                             .Select(a => new IncomeAppDto() {
                                 IncomeId = a.IncomeId,
                                 TaksName = a.TaksName,
                                 Title = a.Title,
                                 CategoryDay = a.CategoryDay,
                                 CategoryFixed = a.CategoryFixed,
                                 BeansText = a.BeansText,
                                 CreateTime = a.CreateTime
                             })
                             .ToPager(pageIndex, pageSize)
                             .ToListAsync();
        }
    }
}
