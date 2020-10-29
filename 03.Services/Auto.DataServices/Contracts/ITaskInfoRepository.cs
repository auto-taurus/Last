using System.Collections.Generic;
using System.Threading.Tasks;
using Auto.Commons.Ioc.IContract;
using Auto.Entities.Modals;

namespace Auto.DataServices.Contracts {
    public interface ITaskInfoRepository : IRepository<TaskInfo>, ISingletonInject {
        Task GetDists(List<int> types);
    }
}
