using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Reflection;

namespace Gbxx.WebApi.Configure.Swagger {
    public static class SwaggerConfigure {
        public static void InitSwaggerGen(this IServiceCollection services) {
            // 注册Swagger服务
            services.AddSwaggerGen(c => {
                // 添加文档信息
                c.SwaggerDoc("v1",
                    new Microsoft.OpenApi.Models.OpenApiInfo {
                        Title = "Wap、Web、M端资讯接口",
                        Version = "v1",
                        Description = "接口调用说明：<br/>" +
                        "<p>Header头部设备参数(参数不区分大小写/不可包含中文)-> <label style='color:red;'>Source : {\"Ip\": \"127.0.0.1\",\"Device\": \"ios\",\"DeviceVers\": \"1.0.0\",\"SystemVers\": \"1.0.0\"}，Device和SystemVers为必传，PC、H5传递浏览器信息</label></p>" +
                        "<p>Header头部权限参数(参数不区分大小写/不可包含中文)-> <label style='color:red;'>Authorization : asdlfqpwerup9qwe;oadfjg'jzjxpvhaiprhtiqwr;oqwje</label></p>" +
                        "<p>URL地址-> <label style='color:red;'>带{value}的不需要在header，from，body等其他地方再进行传递</label></p>" +
                        "<p>返回状态-> 200成功（包含其他规则验证），204请求成功没有数据（一般针对列表），400请求参数验证错误，404资源不存在或未定义（一般针对单个对象），500内部错误，权限验证状态码待添加</p>" +
                        "<p>200返回格式 -> <label>{\"code\":bool,\"message\":string,\"data\":object,\"other\":objecte}</label></p>"
                        +
                        "<p>其他状态返回错误或提示文本<p>"


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
