using Auto.Commons.Ioc.IContract;
using Auto.Dto.ElasticDoc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Utils {
    public interface IMySqlRepository : ISingletonInject {
        List<NewsDoc> GetList(int pageIndex = 1, int pageSize = 100000, int minId = 0);
    }
}
