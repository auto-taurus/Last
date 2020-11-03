using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AutoNews.Data.Queries
{
    public static partial class MemberProblemExtensions
    {
        #region Generated Extensions
        public static AutoNews.Data.Entities.MemberProblem GetByKey(this IQueryable<AutoNews.Data.Entities.MemberProblem> queryable, int problemId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.MemberProblem> dbSet)
                return dbSet.Find(problemId);

            return queryable.FirstOrDefault(q => q.ProblemId == problemId);
        }

        public static ValueTask<AutoNews.Data.Entities.MemberProblem> GetByKeyAsync(this IQueryable<AutoNews.Data.Entities.MemberProblem> queryable, int problemId)
        {
            if (queryable is DbSet<AutoNews.Data.Entities.MemberProblem> dbSet)
                return dbSet.FindAsync(problemId);

            var task = queryable.FirstOrDefaultAsync(q => q.ProblemId == problemId);
            return new ValueTask<AutoNews.Data.Entities.MemberProblem>(task);
        }

        #endregion

    }
}
