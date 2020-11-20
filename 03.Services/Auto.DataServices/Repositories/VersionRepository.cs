using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.Entities.Modals;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.DataServices.Repositories {
    public class VersionRepository : Repository<APPVersions>, IVersionRepository {
        public VersionRepository(NewsContext newsContext) : base(newsContext) {
        }
    }
}
