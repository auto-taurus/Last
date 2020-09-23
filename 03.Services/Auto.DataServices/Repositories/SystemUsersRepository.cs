using Auto.DataServices.Contracts;
using Auto.EFCore;
using Auto.EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Auto.DataServices.Repositories {
    public class SystemUsersRepository : Repository<SystemUsers>, ISystemUsersRepository {
        public SystemUsersRepository(AutoNewsContext AutoNewsContext) : base(AutoNewsContext) {
        }

    }
}
