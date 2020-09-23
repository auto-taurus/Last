using Auto.Commons.Ioc.IContract;
using Auto.EFCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.DataServices.Contracts {
    public interface ISystemUsersRepository : IRepository<SystemUsers>, ISingletonInject {
        //AddRolesAsync(IList<>)
    }
}
