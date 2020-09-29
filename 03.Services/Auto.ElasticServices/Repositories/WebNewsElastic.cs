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
        public WebNewsElastic(
            IElasticClient elasticClient,
            IMemoryCache memoryCache,
            IConfiguration configuration)
            
            : base(elasticClient, memoryCache, configuration) {

        }
        public string IndexName => base.Prefix + "-news";
    }
}
