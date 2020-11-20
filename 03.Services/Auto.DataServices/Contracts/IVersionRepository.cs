using Auto.Commons.Ioc.IContract;
using Auto.Entities.Modals;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Auto.DataServices.Contracts {
    public interface IVersionRepository : IRepository<APPVersions>, IScopedInject {
    }
}
