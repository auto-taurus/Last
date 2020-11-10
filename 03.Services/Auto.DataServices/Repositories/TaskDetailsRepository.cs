using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Modals;

namespace Auto.DataServices.Repositories {
    public class TaskDetailsRepository : Repository<TaskDetails>, ITaskDetailsRepository {
        public TaskDetailsRepository(NewsContext newsContext) : base(newsContext) {
        }
    }
}
