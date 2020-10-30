using  Auto.ElasticServices.Modals;
using Auto.ElasticServices.Contracts;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Nest;
using System;

namespace Auto.ElasticServices.Repositories {
    public class WebNewsElastic : ElasticRepository<WebNewsDoc>, IWebNewsElastic {
        public WebNewsElastic(IElasticClient elasticClient,
                              IConfiguration configuration,
                              IMemoryCache memoryCache)
            : base(elasticClient, configuration, memoryCache) {

        }
        public String IndexName { get { return $"{base.Prefix}-news"; } }
    }
}
