using Elasticsearch.Net;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nest;
using System;
using System.Linq;

namespace Gbxx.Gather.Configure {
    public static class ElasticsearchConfigure  {
        public static void InitElasticSearch(this IServiceCollection services, IConfiguration configuration) {

            var uris = configuration["ElasticConfig:Host"].Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries)
                                                          .ToList()
                                                          .ConvertAll(x => new Uri(x));
            var connectionPool = new StaticConnectionPool(uris);
            var connectionsettings = new ConnectionSettings(connectionPool).RequestTimeout(TimeSpan.FromSeconds(30));
            services.AddSingleton<IElasticClient>(new ElasticClient(connectionsettings));
            //AddDefaultMappings(settings);
            //CreateIndex(client, defaultIndex);
        }
        //private static void AddDefaultMappings(ConnectionSettings settings) {
        //    settings.DefaultMappingFor<Product>(m => m.Ignore(p => p.Price).Ignore(p => p.Quantity).Ignore(p => p.Rating));
        //}
        //private static void CreateIndex(IElasticClient client, string indexName) {
        //    var createIndexResponse = client.Indices.Create(indexName, index => index.Map<Product>(x => x.AutoMap()));
        //}
    }
}
