using Auto.Commons.Ioc.IContract;
using Auto.Dto.ElasticDoc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.ElasticServices.Contracts {
    public interface IWebNewsElastic : IElasticRepository<NewsDoc>, IScopedInject {

    }
}
