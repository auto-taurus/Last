using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.IO;
using System.Reflection;

namespace Gbxx.WebApi.Configure.Swagger {
    public class SwaggerConfigure {
        public static void Configure(IServiceCollection services) {
            // 注册Swagger服务
            services.AddSwaggerGen(c => {
                // 添加文档信息
                c.SwaggerDoc("v1",
                    new Microsoft.OpenApi.Models.OpenApiInfo {
                        Title = "Wap、Web、M端资讯接口",
                        Version = "v1",
                        Description = "接口调用示例：<br/>" +
                        "基本参数(不区分大小写)-> {\"Ip\": \"IP地址\",\"Device\": \"设备号\",\"Version\": \"版本号\"}<br/>" +
                        "GET请求示例-> https://localhost:44328/v1/1/Category/2?Ip=3&Device=4&Version=5 <br/>" +
                        "GET加其他参数示例->https://localhost:44328/v1/1/News/Tag?Title=%E7%89%B9%E6%9C%97%E6%99%AE&PageIndex=1&PageSize=10&Ip=127.0.0.1&Device=ios.10.26.1&Version=10.26.0"
                    });
                c.ExampleFilters();
                //添加xml文件
                //获取xml注释文件的目录
                var xmlFile = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = System.IO.Path.Combine(AppContext.BaseDirectory, xmlFile);
                // 启用xml注释
                c.IncludeXmlComments(xmlPath);
            });

            //services.AddSwaggerGen(c => {
            //    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });

            //    // [SwaggerRequestExample] & [SwaggerResponseExample]
            //    // version < 3.0 like this: c.OperationFilter<ExamplesOperationFilter>(); 
            //    // version 3.0 like this: c.AddSwaggerExamples(services.BuildServiceProvider());
            //    // version > 4.0 like this:
            //    c.ExampleFilters();

            //    c.OperationFilter<AddHeaderOperationFilter>("correlationId", "Correlation Id for the request", false); // adds any string you like to the request headers - in this case, a correlation id
            //    c.OperationFilter<AddResponseHeadersFilter>(); // [SwaggerResponseHeader]

            //    var xmlFile = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}.xml";
            //    c.IncludeXmlComments(xmlFile); // standard Swashbuckle functionality, this needs to be before c.OperationFilter<AppendAuthorizeToSummaryOperationFilter>()

            //    c.OperationFilter<AppendAuthorizeToSummaryOperationFilter>(); // Adds "(Auth)" to the summary so that you can see which endpoints have Authorization
            //                                                                  // or use the generic method, e.g. c.OperationFilter<AppendAuthorizeToSummaryOperationFilter<MyCustomAttribute>>();

            //    // add Security information to each operation for OAuth2
            //    c.OperationFilter<SecurityRequirementsOperationFilter>();
            //    // or use the generic method, e.g. c.OperationFilter<SecurityRequirementsOperationFilter<MyCustomAttribute>>();

            //    // if you're using the SecurityRequirementsOperationFilter, you also need to tell Swashbuckle you're using OAuth2
            //    c.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme {
            //        Description = "Standard Authorization header using the Bearer scheme. Example: \"bearer {token}\"",
            //        In = ParameterLocation.Header,
            //        Name = "Authorization",
            //        Type = SecuritySchemeType.ApiKey
            //    });
            //});
            services.AddSwaggerExamplesFromAssemblies(Assembly.GetEntryAssembly());
        }
    }
}
