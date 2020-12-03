using Gbxx.BackStage.Handlers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Reflection;

namespace Gbxx.BackStage.Configure {
    public static class SwaggerConfigure {
        public static void InitSwaggerGen(this IServiceCollection services) {
            // 注册Swagger服务
            services.AddSwaggerGen(c => {
                // 添加文档信息
                c.SwaggerDoc("v1",
                    new Microsoft.OpenApi.Models.OpenApiInfo {
                        Title = "资讯网站后台接口",
                        Version = "v1",
                        Description = "接口调用说明：<br/>" +
                        "<p>Header头部权限参数(参数不区分大小写/不可包含中文)-> <label style='color:red;'>Token : asdlfqpwerup9qwe;oadfjg'jzjxpvhaiprhtiqwr;oqwje</label></p>" +
                        "<p>URL地址-> <label style='color:red;'>带{value}的不需要在header，from，body等其他地方再进行传递</label></p>" +
                        "<p>返回状态-> 200成功（包含其他规则验证），204请求成功没有数据（一般针对列表），400请求参数验证错误，401未登录，403已登录没有权限，404资源不存在或未定义（一般针对单个对象），500内部错误</p>" +
                        "<p>200返回格式 -> <label>{\"code\":bool,\"message\":string,\"data\":object,\"other\":objecte}</label></p>" +
                        "<p>其他状态返回错误或提示文本<p>"
                    });
                c.ExampleFilters();
                // c.OperationFilter<AddHeaderOperationFilter>("source", "{\"Ip\": \"127.0.0.1\",\"Device\": \"ios\",\"DeviceVers\": \"1.0.0\",\"SystemVers\": \"1.0.0\"}", true);
                // 添加xml文件
                // 获取xml注释文件的目录
                var xmlFile = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = System.IO.Path.Combine(AppContext.BaseDirectory, xmlFile);
                // 启用xml注释
                c.IncludeXmlComments(xmlPath);

                //开启权限小锁
                c.OperationFilter<AddResponseHeadersFilter>();
                c.OperationFilter<AppendAuthorizeToSummaryOperationFilter>();

                //在header中添加token，传递到后台
                c.OperationFilter<SecurityRequirementsOperationFilter>();

                //Add Jwt Authorize to http header

                c.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme {
                    Description = "JWT授权(数据将在请求头中进行传递)直接在下面框中输入Bearer {token}(注意两者之间是一个空格) \"",
                    Name = "Authorization",//jwt默认的参数名称
                    In = ParameterLocation.Header,//jwt默认存放Authorization信息的位置(请求头中)
                    Type = SecuritySchemeType.ApiKey
                });
                //Add authentication type
                //c.AddSecurityRequirement(new OpenApiSecurityRequirement {
                //    {
                //        new OpenApiSecurityScheme
                //        {
                //             Reference = new OpenApiReference(){
                //                Id = "Bearer",
                //                Type = ReferenceType.SecurityScheme
                //             }
                //        }, Array.Empty<string>()
                //    }
                //});
                c.DocumentFilter<HiddenApiFilter>();
            });
            services.AddSwaggerExamplesFromAssemblies(Assembly.GetEntryAssembly());
        }
    }
}
