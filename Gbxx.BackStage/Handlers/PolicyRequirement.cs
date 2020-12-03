using Auto.RedisServices.Repositories;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Gbxx.BackStage.Handlers {
    public class PolicyRequirement : IAuthorizationRequirement {

    }
    /// <summary>
    /// 测试菜单类
    /// </summary>
    public class Menu {
        public string Role { get; set; }

        public string Url { get; set; }
    }

    public class PolicyHandler : AuthorizationHandler<PolicyRequirement> {
        /// <summary>
        /// 授权方式（cookie, bearer, oauth, openid）
        /// </summary>
        public IAuthenticationSchemeProvider _IAuthenticationSchemeProvider { get; set; }
        /// <summary>
        /// jwt 服务
        /// </summary>
        private readonly IJwtRedis _IJwtRedis;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="authenticationSchemeProvider"></param>
        /// <param name="jwtRedis"></param>
        public PolicyHandler(IAuthenticationSchemeProvider authenticationSchemeProvider, IJwtRedis jwtRedis) {
            _IAuthenticationSchemeProvider = authenticationSchemeProvider;
            _IJwtRedis = jwtRedis;
        }
        //授权处理
        protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, PolicyRequirement requirement) {
            //Todo：获取角色、Url 对应关系
            //List<Menu> list = new List<Menu> {
            //    new Menu
            //    {
            //        Role = Guid.Empty.ToString(),
            //        Url = "/api/v1.0/Values"
            //    },
            //    new Menu
            //    {
            //        Role=Guid.Empty.ToString(),
            //        Url="/api/v1.0/secret/deactivate"
            //    },
            //    new Menu
            //    {
            //        Role=Guid.Empty.ToString(),
            //        Url="/api/v1.0/secret/refresh"
            //    }
            //};
            var httpContext = (context.Resource as AuthorizationFilterContext).HttpContext;

            //获取授权方式
            var defaultAuthenticate = await _IAuthenticationSchemeProvider.GetDefaultAuthenticateSchemeAsync();
            if (defaultAuthenticate != null) {
                //验证签发的用户信息
                var result = await httpContext.AuthenticateAsync(defaultAuthenticate.Name);
                if (result.Succeeded) {
                    //判断是否为已停用的 Token
                    if (!_IJwtRedis.IsCurrentActiveAsync()) {
                        context.Fail();
                        return;
                    }
                    //httpContext.User = result.Principal;
                    ////判断角色与 Url 是否对应
                    ////
                    //var url = httpContext.Request.Path.Value.ToLower();
                    //var role = httpContext.User.Claims.Where(c => c.Type == ClaimTypes.Role).FirstOrDefault().Value;
                    //var menu = list.Where(x => x.Role.Equals(role) && x.Url.ToLower().Equals(url)).FirstOrDefault();
                    //if (m enu == null) {
                    //    context.Fail();
                    //    return;
                    //}
                    //判断是否过期
                    if (DateTime.Parse(httpContext.User.Claims.SingleOrDefault(s => s.Type == ClaimTypes.Expiration).Value) >= DateTime.UtcNow) {
                        context.Succeed(requirement);
                    }
                    else {
                        context.Fail();
                    }
                    return;
                }
            }
            context.Fail();
        }
    }
}
