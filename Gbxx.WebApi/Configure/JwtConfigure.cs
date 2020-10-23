using Gbxx.WebApi.Handlers;
using IdentityModel;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Text;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Configure {
    /// <summary>
    /// 
    /// </summary>
    public static class JwtConfigure {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public static void InitJwt(this IServiceCollection services, IConfiguration configuration) {
            if (bool.Parse(configuration["Authentication:JwtBearer:IsEnabled"])) {

                services.AddAuthorization(options => {
                    options.AddPolicy("Permission", policy => policy.AddRequirements(new OperationAuthorizationRequirement()));
                    //1、Definition authorization policy
                    //options.AddPolicy("Permission", policy => policy.Requirements.Add(new PolicyRequirement()));
                }).AddAuthentication(options => {
                    options.DefaultAuthenticateScheme = "JwtBearer";
                    options.DefaultChallengeScheme = "JwtBearer";
                }).AddJwtBearer("JwtBearer", options => {
                    options.Audience = configuration["Authentication:JwtBearer:Audience"];

                    options.TokenValidationParameters = new TokenValidationParameters {
                        NameClaimType = JwtClaimTypes.Name,
                        RoleClaimType = JwtClaimTypes.Role,
                        // The signing key must match!
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(configuration["Authentication:JwtBearer:SecurityKey"])),

                        // Validate the JWT Issuer (iss) claim
                        ValidateIssuer = true,
                        ValidIssuer = configuration["Authentication:JwtBearer:Issuer"],
                        // Validate the JWT Audience (aud) claim
                        ValidateAudience = true,
                        ValidAudience = configuration["Authentication:JwtBearer:Audience"],
                        //AudienceValidator = (m, n, z) =>
                        //{
                        //    return m != null && m.FirstOrDefault().Equals(IsConst.ValidAudience);
                        //},
                        // Validate the token expiry
                        ValidateLifetime = true, //是否验证超时  当设置exp和nbf时有效 同时启用ClockSkew 
                        // If you want to allow a certain amount of clock drift, set that here
                        ClockSkew = TimeSpan.FromMinutes(Convert.ToInt32(configuration["Authentication:JwtBearer:TokenMinutes"]))
                    };
                    options.Events = new JwtBearerEvents {
                        OnAuthenticationFailed = context => {
                            if (context.Exception.GetType() == typeof(SecurityTokenExpiredException)) {
                                //设置响应头过期信息
                                context.Response.Headers.Add("act", "expired");
                            }
                            return Task.CompletedTask;
                        },
                        OnMessageReceived = context => {
                            //context.Token = context.Request.Query["access_token"];
                            context.Token = context.Request.Headers["authorization"];
                            return Task.CompletedTask;
                        }
                    };
                    //options.Events = new JwtBearerEvents {
                    //    OnMessageReceived = QueryStringTokenResolver
                    //};
                });
            }

            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<IAuthorizationHandler, PolicyHandler>();
        }

        //private static Task QueryStringTokenResolver(MessageReceivedContext context) {
        //    if (!context.HttpContext.Request.Path.HasValue ||
        //        !context.HttpContext.Request.Path.Value.StartsWith("/signalr")) {
        //        // We are just looking for signalr clients
        //        return Task.CompletedTask;
        //    }

        //    var qsAuthToken = context.HttpContext.Request.Query["enc_auth_token"].FirstOrDefault();
        //    if (qsAuthToken == null) {
        //        // Cookie value does not matches to querystring value
        //        return Task.CompletedTask;
        //    }

        //    // Set auth token from cookie
        //    context.Token = SimpleStringCipher.Instance.Decrypt(qsAuthToken, AppConsts.DefaultPassPhrase);
        //    return Task.CompletedTask;
        //}
    }
}
