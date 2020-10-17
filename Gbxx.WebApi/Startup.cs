using Auto.EFCore;
using Auto.EFCore.Configurations.Maps;
using FluentValidation;
using FluentValidation.AspNetCore;
using Gbxx.BackStage.Configure.Ioc;
using Gbxx.WebApi.Configure;
using Gbxx.WebApi.Configure.Swagger;
using Gbxx.WebApi.Filters;
using Gbxx.WebApi.Utils;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace Gbxx.WebApi {
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
            services.AddDbContextPool<MysqlDbContext>(x => {
                x.UseMySql(Configuration.GetConnectionString("XinWen"));
            })
            .AddSingleton<MysqlDbContext>()
            .AddOptions();

            // 配置EF连接字符串
            services.AddDbContextPool<AutoNewsContext>(x => {
                x.UseSqlServer(Configuration.GetConnectionString("GbxxNews"),
                    y => {
                        y.MaxBatchSize(10).UseRowNumberForPaging();
                    });
            })
            .AddSingleton<AutoNewsContext>()
            .AddOptions();

            services.AddSingleton<IEntityMapper, AutoNewsEntityMapper>();

            services.BatchServices();
            services.InitElasticSearch(Configuration);
            services.InitSwaggerGen();
            services.InitJwt(Configuration);
            services.AddMvc(options => {
                //全局拦截器
                options.Filters.Add<HeaderSourceAttribute>();
            })
                    .SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                    .AddJsonOptions(options => {
                        //action返回json格式首字母大写调整
                        //options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                        options.SerializerSettings.DateFormatHandling = Newtonsoft.Json.DateFormatHandling.MicrosoftDateFormat;
                        options.SerializerSettings.DateFormatString = "yyyy-MM-dd HH:mm:ss";
                    }).AddFluentValidation(x => {
                        x.RegisterValidatorsFromAssemblyContaining<HeaderSourceValidator>();
                        x.RunDefaultMvcValidationAfterFluentValidationExecutes = false;
                        x.ValidatorOptions.CascadeMode = CascadeMode.Stop;
                    });

            services.Configure<ApiBehaviorOptions>(options => {
                options.InvalidModelStateResponseFactory = (context) => {
                    var error = context.ModelState
                                       .Values
                                       .SelectMany(x => x.Errors.Select(p => p.ErrorMessage))
                                       .SingleOrDefault();
                    //var result = new Response<Object>() {
                    //    Code = false,
                    //    Message = error,
                    //};
                    return new BadRequestObjectResult(error);
                };
            });
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
            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            // 启用Swagger中间件
            app.UseSwagger();
            // 配置SwaggerUI
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
                c.RoutePrefix = string.Empty;
            });
            app.UsePathBase(new PathString("/v2"));
            //app.UseMvc(routes => { });
            app.UseMvc(routes => {
                routes.MapRoute(
                  name: "areas",
                  template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
                //routes.MapRoute(
                //  name: "default",
                //  template: "{controller=Home}/{action=Index}/{id?}"
                //);
            });
        }
    }
}
