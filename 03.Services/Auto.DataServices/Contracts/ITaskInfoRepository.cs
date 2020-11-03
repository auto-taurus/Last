using System.Collections.Generic;
using System.Threading.Tasks;
using Auto.Commons.Ioc.IContract;
using Auto.Entities.Modals;

namespace Auto.DataServices.Contracts {
    public interface ITaskInfoRepository : IRepository<TaskInfo>, IScopedInject {
        Task GetDists(List<int> types);
    }
}
