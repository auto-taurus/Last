using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Modals;

namespace Auto.DataServices.Repositories {
    public class TaskNoviceLogRepository : Repository<TaskNoviceLog>, ITaskNoviceLogRepository {
        public TaskNoviceLogRepository(NewsContext newsContext) : base(newsContext) {

        }
    }
}
