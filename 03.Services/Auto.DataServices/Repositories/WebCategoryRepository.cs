using Auto.DataServices.Contracts;
using Auto.EFCore;
using Auto.EFCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.DataServices.Repositories {
    public class WebCategoryRepository : Repository<WebCategory>, IWebCategoryRepository {
        public WebCategoryRepository(AutoNewsContext AutoNewsContext) : base(AutoNewsContext) {
        }
    }
}
