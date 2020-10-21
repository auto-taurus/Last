using Auto.Commons.Ioc.IContract;
using Auto.Entities.Dtos;
using Auto.Entities.Modals;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Auto.DataServices.Contracts {
    public interface IMemberIncomeRepository : IRepository<MemberIncome>, ISingletonInject {
        Task<IList<MemberIncomeAppDto>> GetAppPagerAsync(Expression<Func<MemberIncome, bool>> predicate, int pageIndex, int pageSize);
    }
}
