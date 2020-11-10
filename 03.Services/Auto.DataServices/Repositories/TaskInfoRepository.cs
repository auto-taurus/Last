using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Modals;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Auto.DataServices.Repositories {
    public class TaskInfoRepository : Repository<TaskInfo>, ITaskInfoRepository {
        private readonly NewsContext _Content;
        public TaskInfoRepository(NewsContext newsContext) : base(newsContext) {
            _Content = newsContext;
        }

        public Task GetDists(List<int> types) {
            throw new System.NotImplementedException();
        }
    }
}
