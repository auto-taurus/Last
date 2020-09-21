using Auto.Commons.Extensions.IocPrictic;
using Auto.EFCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.DataServices.Contracts {
    public interface ISystemUsersRepository : IRepository<WebSpecial>, ISingletonInject {

    }
}
