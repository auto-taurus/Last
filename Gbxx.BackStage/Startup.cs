using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Auto.EFCore;
using Gbxx.BackStage.Configure.Ioc;
using Gbxx.BackStage.Configure.Swagger;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json.Serialization;

namespace Gbxx.BackStage {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        private readonly string Any = "Any";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            //添加jwt验证：
            //JwtConfigure.Configure(services, Configuration);
            //RedisConfigure.Configure(services, Configuration);

            ServiceConfigure.Configure(services);
            SwaggerConfigure.Configure(services);

            services.AddMvc()
                    .SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                    .AddJsonOptions(options => {
                        //action返回json格式首字母大写调整
                        options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                        options.SerializerSettings.DateFormatHandling = Newtonsoft.Json.DateFormatHandling.MicrosoftDateFormat;
                        options.SerializerSettings.DateFormatString = "yyyy-MM-dd HH:mm:ss";
                    });
            // 配置EF连接字符串
            services.AddDbContextPool<AutoNewsContext>(x => {
                x.UseSqlServer(Configuration.GetConnectionString("GbxxNews"),
                    y => {
                        y.MaxBatchSize(10).UseRowNumberForPaging();
                    });
            })
            .AddSingleton<AutoNewsContext>()
            .AddOptions();
            // 配置信息注入
            services.AddSingleton(Configuration);
            //独立发布跨域
            services.AddCors(options =>
                             options.AddPolicy(Any, builder =>
                                                    builder.AllowCredentials()
                                                           .AllowAnyHeader()
                                                           .AllowAnyOrigin()
                                                           .SetIsOriginAllowedToAllowWildcardSubdomains()
                                                           .WithMethods("GET", "POST", "PUT", "DELETE", "HEAD", "OPTIONS", "TRACE")
            ));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseCors(Any);
                app.UseDeveloperExceptionPage();
            }
            else {
                app.UseHsts();
            }
            //前后端分离，支持静态页启动
            //DefaultFilesOptions options = new DefaultFilesOptions();
            //options.DefaultFileNames.Clear();
            //options.DefaultFileNames.Add("index.html");
            //app.UseDefaultFiles(options);

            // 启用Swagger中间件
            app.UseSwagger();
            // 配置SwaggerUI
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
                c.RoutePrefix = string.Empty;
            });

            app.UseStaticFiles();
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
