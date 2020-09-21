using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Company.AutoNews.Data.Queries
{
    public static partial class SystemUsersInMenuExtensions
    {
        #region Generated Extensions
        public static IQueryable<Auto.EFCore.Entities.SystemUsersInMenu> ByMenuId(this IQueryable<Auto.EFCore.Entities.SystemUsersInMenu> queryable, int? menuId)
        {
            return queryable.Where(q => (q.MenuId == menuId || (menuId == null && q.MenuId == null)));
        }

        public static IQueryable<Auto.EFCore.Entities.SystemUsersInMenu> ByUserId(this IQueryable<Auto.EFCore.Entities.SystemUsersInMenu> queryable, int? userId)
        {
            return queryable.Where(q => (q.UserId == userId || (userId == null && q.UserId == null)));
        }

        #endregion

    }
}
