using Auto.Commons.ApiHandles.Responses;
using Auto.DataServices.Contracts;
using Auto.Entities.Dtos;
using Gbxx.WebApi.Controllers;
using Gbxx.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Controllers {

    /// <summary>
    /// 版本控制
    /// </summary>
    [Route("v1/[controller]")]
    public class AppInfoController : DefaultController {
        /// <summary>
        /// 
        /// </summary>
        protected readonly Microsoft.Extensions.Logging.ILogger _ILogger;

        private readonly IConfiguration _IConfiguration;

        protected readonly IAppInfoRepository _IVersionRepository;

        public AppInfoController(ILogger<AppInfoController> logger,
            IAppInfoRepository versionRepository,
            IConfiguration configuration) {
            _ILogger = logger;
            _IConfiguration = configuration;
            _IVersionRepository = versionRepository;
        }

        /// <summary>
        /// 获取版本信息
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpGet("{code}")]
        public async Task<IActionResult> GetVersionAsync([FromHeader]String source,
                                                           [FromRoute]RouteCode route) {
            var response = new Response<Object>();
            try {
                var result = await _IVersionRepository.Query(a =>a.Code == route.code
                                                                                    && a.Status == 1
                                                                                    && a.IsEnable == 1).
                                                                                    OrderByDescending(i => i.CreateTime).
                                                                                    Select(a=>new APPVersionsDto {
                                                                                        Code=a.Code,
                                                                                        LogoUrl=a.LogoUrl,
                                                                                        PackageName=a.PackageName,
                                                                                        Version=a.Version,
                                                                                        VersionSize=a.VersionSize,
                                                                                        VersionCode=a.VersionCode,
                                                                                        AppName=a.AppName,
                                                                                        AppUrl=a.AppUrl,
                                                                                        Introduction=a.Introduction,
                                                                                        UpdateLog=a.UpdateLog,
                                                                                        IsMandatory=a.IsMandatory,
                                                                                        CreateTime=a.CreateTime//更新时间
                                                                                    }).
                                                                                    FirstOrDefaultAsync();
                if(result==null) {
                    return NotFound();
                }
                response.Code = true;
                response.Message = "Success";
                response.Data = result;
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
    }
}
