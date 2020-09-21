using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Queries
{
    public static partial class SystemUsersInRoleExtensions
    {
        #region Generated Extensions
        public static IQueryable<Auto.EFCore.Entities.SystemUsersInRole> ByRoleId(this IQueryable<Auto.EFCore.Entities.SystemUsersInRole> queryable, int? roleId)
        {
            return queryable.Where(q => (q.RoleId == roleId || (roleId == null && q.RoleId == null)));
        }

        public static IQueryable<Auto.EFCore.Entities.SystemUsersInRole> ByUsersId(this IQueryable<Auto.EFCore.Entities.SystemUsersInRole> queryable, int? usersId)
        {
            return queryable.Where(q => (q.UsersId == usersId || (usersId == null && q.UsersId == null)));
        }

        #endregion

    }
}
