using Auto.Commons.ApiHandles.Responses;
using Auto.DataServices.Contracts;
using Auto.Entities.Dtos;
using Gbxx.WebApi.Areas.v1.Data;
using Gbxx.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Controllers {
    /// <summary>
    /// 常见问题
    /// </summary>
    [Route("v1/[controller]")]
    public class ProblemController : DefaultController {
        /// <summary>
        /// 
        /// </summary>
        protected readonly ILogger _ILogger;
        /// <summary>
        /// 
        /// </summary>
        protected ISystemDictionaryRepository _ISystemDictionaryRepository;
        /// <summary>
        /// 
        /// </summary>
        protected IMemberProblemRepository _IMemberProblemRepository;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="webNewsElastic"></param>
        /// <param name="webNewsRedis"></param>
        public ProblemController(ILogger<SiteController> logger,
                              ISystemDictionaryRepository systemDictionaryRepository,
                              IMemberProblemRepository memberProblemRepository) {
            this._ILogger = logger;
            this._ISystemDictionaryRepository = systemDictionaryRepository;
            this._IMemberProblemRepository = memberProblemRepository;
        }
        /// <summary>
        /// 获取问题列表
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <returns></returns>
        [HttpGet]
        //[SwaggerResponse(200, "", typeof(MemberData))]
        public async Task<IActionResult> GetProblemAsync([FromHeader]String source) {
            var response = new Response<Object>();
            try {
                var dists = await _ISystemDictionaryRepository.GetKeyNames("ProblemType");
                if (dists.Count > 0) {
                    var types = dists.Select(a => int.Parse(a.DistKey)).ToList();
                    var problems = await _IMemberProblemRepository.GetDists(types);
                    response.Code = true;
                    response.Data = new {
                        Dists = dists,
                        Problems = problems
                    };
                }
                else
                    return NoContent();
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
    }
}