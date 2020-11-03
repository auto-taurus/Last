using Microsoft.AspNetCore.Authorization;
using System;
using System.Security.Claims;

namespace Gbxx.WebApi.Controllers {
    /// <summary>
    /// 
    /// </summary>
    [Authorize(Policy = "Permission")]
    public class AuthorizeController : DefaultController {

        /// <summary>
        /// 用户编号
        /// </summary>
        protected int MemberId {
            get {
                var ident = User.FindFirst(e => e.Type == ClaimTypes.NameIdentifier);
                if (ident != null)
                    return int.Parse(ident.Value);
                else
                    return 0;
            }
        }
        /// <summary>
        /// 用户名称
        /// </summary>
        protected String MemberName { get { return User.Identity.Name; } }
        /// <summary>
        /// 昵称
        /// </summary>
        protected String NickName { get { return User.FindFirst(e => e.Type == ClaimTypes.GivenName).Value; } }
        /// <summary>
        /// 手机号
        /// </summary>
        protected String Phone { get { return User.FindFirst(e => e.Type == ClaimTypes.MobilePhone).Value; } }
        /// <summary>
        /// 邀请码
        /// </summary>
        protected String Code { get { return User.FindFirst(e => e.Type == ClaimTypes.SerialNumber).Value; } }
        /// <summary>
        /// 支付宝
        /// </summary>
        protected String Alipay { get { return User.FindFirst(e => e.Type == ClaimTypes.Upn).Value; } }
        /// <summary>
        /// 微信
        /// </summary>
        protected String OpenId { get { return User.FindFirst(e => e.Type == ClaimTypes.Spn).Value; } }
    }
}