using Auto.Commons.Ioc.IContract;
using Auto.Entities.Modals;
using System.Collections.Generic;

namespace Gbxx.WebApi.Utils {
    public interface IMySqlRepository : ISingletonInject {
        List<WebNews> GetList(int categoryid, int pageIndex = 1, int pageSize = 100000, int minId = 0);
    }
}
