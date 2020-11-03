using Auto.Applications.Modals;
using Auto.Commons.Ioc.IContract;
using Auto.DataServices;
using Auto.Entities.Modals;
using System.Threading.Tasks;

namespace Auto.Applications.Contracts.Tasks {
    public interface ITaskInfoApp : IScopedInject {
        Task<bool> AddTask(TaskItem item);
    }
}
