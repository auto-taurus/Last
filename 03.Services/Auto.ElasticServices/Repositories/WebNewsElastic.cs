using Auto.Dto.ElasticDoc;
using Auto.ElasticServices.Contracts;
using Elasticsearch.Net;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Nest;
using System;
using System.Collections.Generic;
using System.Text;

namespace Auto.ElasticServices.Repositories {
    public class WebNewsElastic : ElasticRepository<NewsDoc>, IWebNewsElastic {
        public WebNewsElastic(IConfiguration configuration, IMemoryCache memoryCache) : base(configuration, memoryCache) {

        }
    }
}
