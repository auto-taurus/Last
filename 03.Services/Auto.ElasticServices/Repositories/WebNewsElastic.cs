using Auto.Dto.ElasticDoc;
using Auto.ElasticServices.Contracts;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Nest;
using System;

namespace Auto.ElasticServices.Repositories {
    public class WebNewsElastic : ElasticRepository<NewsDoc>, IWebNewsElastic {
        public WebNewsElastic(IElasticClient elasticClient,
                              IConfiguration configuration,
                              IMemoryCache memoryCache)
            : base(elasticClient, configuration, memoryCache) {

        }
        public String IndexName { get { return $"{base.Prefix}_news"; } }
    }
}
