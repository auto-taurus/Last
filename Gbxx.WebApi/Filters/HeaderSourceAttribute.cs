using Auto.Commons.ApiHandles.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace Gbxx.WebApi.Filters {
    /// <summary>
    /// 
    /// </summary>
    public class HeaderSourceAttribute : ActionFilterAttribute, IActionFilter {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public override void OnActionExecuting(ActionExecutingContext context) {
            var response = new Response<Object>();
            try {
                var source = context.HttpContext.Request.Headers["source"];
                if (string.IsNullOrEmpty(source)) {
                    context.Result = new BadRequestObjectResult("请传递Header中Source信息!");
                }
                else {
                    var entity = JsonConvert.DeserializeObject<HeaderSource>(source);
                    var validator = new HeaderSourceValidator();
                    var result = validator.Validate(entity);
                    if (!result.IsValid) {
                        var message = result.Errors.Select(a => a.ErrorMessage).SingleOrDefault();
                        context.Result = new BadRequestObjectResult(message);
                    }
                }
            }
            catch (Exception ex) {
                context.Result = new BadRequestObjectResult("请求头Header中的Source格式不正确！");
            }
            base.OnActionExecuting(context);
        }
    }
}
