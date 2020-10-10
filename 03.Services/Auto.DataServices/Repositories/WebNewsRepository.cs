using Auto.DataServices.Contracts;
using Auto.EFCore;
using Auto.EFCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.DataServices.Repositories {
    public class WebNewsRepository : Repository<WebNews>, IWebNewsRepository {
        public WebNewsRepository(AutoNewsContext AutoNewsContext) : base(AutoNewsContext) {
        }

    }
}
