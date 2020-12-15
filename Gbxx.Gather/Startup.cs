using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.DataServices.Repositories;
using Auto.ElasticServices.Contracts;
using Auto.ElasticServices.Repositories;
using Gbxx.Gather.Configure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;

namespace Gbxx.Gather {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        private readonly string Any = "Any";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            // 配置信息注入
            services.AddSingleton(Configuration);
            // 配置EF连接字符串
            services.AddDbContextPool<NewsContext>(x => {
                //.UseLazyLoadingProxies()
                x.UseSqlServer(Configuration.GetConnectionString("GbxxNews"),
                    y => {
                        y.MaxBatchSize(10).UseRowNumberForPaging();
                    });
            })
            .AddScoped<NewsContext>()
            .AddOptions();
            //独立发布跨域
            services.AddCors(options =>
                             options.AddPolicy(Any, builder =>
                                                    builder.AllowCredentials()
                                                           .AllowAnyHeader()
                                                           .AllowAnyOrigin()
                                                           .SetIsOriginAllowedToAllowWildcardSubdomains()
                                                           .WithMethods("GET", "POST", "PUT", "DELETE", "HEAD", "OPTIONS", "TRACE")
            ));
            // 注册Swagger服务
            services.AddSwaggerGen(c => {
                // 添加文档信息
                c.SwaggerDoc("v1",
                    new Microsoft.OpenApi.Models.OpenApiInfo {
                        Title = "采集API",
                        Version = "v1"
                    });
                //添加xml文件
                //获取xml注释文件的目录
                var xmlFile = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = System.IO.Path.Combine(AppContext.BaseDirectory, xmlFile);
                // 启用xml注释
                c.IncludeXmlComments(xmlPath);
            });

            services.AddScoped<IEntityMapper, EntityMapper>();

            services.InitElasticSearch(Configuration);

            services.AddScoped<IWebNewsElastic, WebNewsElastic>();
            services.AddScoped<IWebNewsRepository, WebNewsRepository>();
            services.AddScoped<IWebCategoryRepository, WebCategoryRepository>();
            //services.AddScoped<IWebSiteRepository, WebSiteRepository>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                    .AddJsonOptions(options => {
                        //action返回json格式首字母大写调整(3.0以下)
                        //options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                        options.SerializerSettings.DateFormatHandling = Newtonsoft.Json.DateFormatHandling.MicrosoftDateFormat;
                        options.SerializerSettings.DateFormatString = "yyyy-MM-dd HH:mm:ss";
                        options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                    });
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
            // 启用Swagger中间件
            app.UseSwagger();
            // 配置SwaggerUI
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
                c.RoutePrefix = string.Empty;
            });

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
