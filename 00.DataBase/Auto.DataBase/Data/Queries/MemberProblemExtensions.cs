using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Master.Data.Queries
{
    public static partial class MemberProblemExtensions
    {
        #region Generated Extensions
        public static Master.Data.Entities.MemberProblem GetByKey(this IQueryable<Master.Data.Entities.MemberProblem> queryable, int problemId)
        {
            if (queryable is DbSet<Master.Data.Entities.MemberProblem> dbSet)
                return dbSet.Find(problemId);

            return queryable.FirstOrDefault(q => q.ProblemId == problemId);
        }

        public static ValueTask<Master.Data.Entities.MemberProblem> GetByKeyAsync(this IQueryable<Master.Data.Entities.MemberProblem> queryable, int problemId)
        {
            if (queryable is DbSet<Master.Data.Entities.MemberProblem> dbSet)
                return dbSet.FindAsync(problemId);

            var task = queryable.FirstOrDefaultAsync(q => q.ProblemId == problemId);
            return new ValueTask<Master.Data.Entities.MemberProblem>(task);
        }

        #endregion

    }
}
