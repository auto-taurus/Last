using Auto.DataServices.Contracts;
using Auto.EFCore;
using Auto.EFCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.DataServices.Repositories {
    public class WebSpecialRepository : Repository<WebSpecial>, IWebSpecialRepository {
        public WebSpecialRepository(AutoNewsContext AutoNewsContext) : base(AutoNewsContext) {
        }

    }
}
