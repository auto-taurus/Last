using Auto.Commons.Ioc.IContract;
using Auto.Entities.Datas;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.DataServices.Contracts {
    public interface IWebNewsRepository : IRepository<WebNews>, ISingletonInject {
    }
}
