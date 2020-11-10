using Auto.Commons.Ioc.IContract;
using Auto.Entities.Modals;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.DataServices.Contracts {
    public interface ITaskDetailsRepository : IRepository<TaskDetails>, IScopedInject {
    }
}
