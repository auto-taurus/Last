using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Modals;

namespace Auto.DataServices.Repositories {
    public class TaskUpperLogRepository : Repository<TaskUpperLog>, ITaskUpperLogRepository {
        public TaskUpperLogRepository(NewsContext newsContext) : base(newsContext) {
        }
    }
}
