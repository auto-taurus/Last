using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Modals;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.DataServices.Repositories {
    public class AppInfoRepository : Repository<AppInfo>, IAppInfoRepository {
        public AppInfoRepository(NewsContext newsContext) : base(newsContext) {
        }
    }
}
