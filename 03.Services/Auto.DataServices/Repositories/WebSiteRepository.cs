using Auto.DataServices.Contracts;
using Auto.EFCore;
using Auto.EFCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.DataServices.Repositories {
    public class WebSiteRepository : Repository<WebSite>, IWebSiteRepository {
        public WebSiteRepository(AutoNewsContext AutoNewsContext) : base(AutoNewsContext) {
        }
    }
}
