using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Linq;

namespace Gbxx.Gather.Handlers {
    /// <summary>
    /// 隐藏接口，不生成到swagger文档展示
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public partial class HiddenApiAttribute : Attribute {
    }
    /// <summary>
    /// 
    /// </summary>
    public class HiddenApiFilter : IDocumentFilter {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="swaggerDoc"></param>
        /// <param name="context"></param>
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context) {
            foreach (ApiDescription apiDescription in context.ApiDescriptions) {
                if (apiDescription.CustomAttributes().OfType<HiddenApiAttribute>().Count() == 0
                    && apiDescription.CustomAttributes().OfType<HiddenApiAttribute>().Count() == 0) {
                    continue;
                }
                var key = "/" + apiDescription.RelativePath.TrimEnd('/');
                if (!key.Contains("/test/") && swaggerDoc.Paths.ContainsKey(key)) {
                    swaggerDoc.Paths.Remove(key);
                }
            }
        }
    }
}
