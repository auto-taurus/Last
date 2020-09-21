using Auto.DataServices.Contracts;
using Auto.EFCore;
using Auto.EFCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.DataServices.Repositories {
    public class SystemUsersRepository : Repository<WebSpecial>, ISystemUsersRepository {
        public SystemUsersRepository(AutoNewsContext AutoNewsContext) : base(AutoNewsContext) {

        }
    }
}
