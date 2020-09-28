using FluentValidation;
using FluentValidation.AspNetCore;
using Gbxx.BackStage.Configure.Ioc;
using Gbxx.WebApi.Configure;
using Gbxx.WebApi.Configure.Swagger;
using Gbxx.WebApi.Requests.Item.Validators;
using Gbxx.WebApi.Utils;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Gbxx.WebApi {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        private readonly string Any = "Any";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {// 配置信息注入
            services.AddSingleton(Configuration);
            // 配置EF连接字符串
            services.AddDbContextPool<MysqlDbContext>(x => {
                x.UseMySql(Configuration.GetConnectionString("GbxxNews"));
            })
            .AddSingleton<MysqlDbContext>()
            .AddOptions();
            //services.AddDbContext<MySqlDbContext>(options => options.UseMySQL(Configuration.GetConnectionString("GbxxNews")));

            services.BatchServices();
            services.InitElasticSearch(Configuration);
            SwaggerConfigure.Configure(services);

            services.AddMvc()
                    .SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                    .AddJsonOptions(options => {
                        //action返回json格式首字母大写调整
                        //options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                        options.SerializerSettings.DateFormatHandling = Newtonsoft.Json.DateFormatHandling.MicrosoftDateFormat;
                        options.SerializerSettings.DateFormatString = "yyyy-MM-dd HH:mm:ss";
                    }).AddFluentValidation(x => {
                        x.RegisterValidatorsFromAssemblyContaining<PostSiteAccessRequestValidator>();
                        x.RunDefaultMvcValidationAfterFluentValidationExecutes = false;
                        x.ValidatorOptions.CascadeMode = CascadeMode.Stop;
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
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            // 启用Swagger中间件
            app.UseSwagger();
            // 配置SwaggerUI
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
                c.RoutePrefix = string.Empty;
            });
            app.UseMvc();
            //app.UseMvc(routes => {
            //    routes.MapRoute(
            //      name: "areas",
            //      template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
            //    );
            //    routes.MapRoute(
            //      name: "default",
            //      template: "{controller=Home}/{action=Index}/{id?}"
            //    );
            //});
        }
    }
}
