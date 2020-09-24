using Auto.Commons.ApiHandles.Responses;
using Gbxx.WebApi.Areas.v1.Data;
using Gbxx.WebApi.Requests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Controllers {
    /// <summary>
    /// 分类管理
    /// </summary>
    public class CategoryController : DefaultController {
        protected readonly ILogger _ILogger;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        public CategoryController(ILogger<SiteController> logger) {
            this._ILogger = logger;
        }
        /// <summary>
        /// 分类列表
        /// </summary>
        /// <param name="mark">站点标识</param>
        /// <param name="args"></param>
        /// <returns></returns>
        [SwaggerResponse(200, "", typeof(List<CategoryResponse>))]
        [HttpGet]
        public async Task<IActionResult> GetCategoriesAsync(string mark, [FromQuery]GetBase args) {
            var response = new Response<List<CategoryResponse>>();
            try {


            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 分类信息
        /// </summary>
        /// <param name="mark">站点标识</param>
        /// <param name="id">分类编号</param>
        /// <param name="args"></param>
        /// <returns></returns>
        [SwaggerResponse(200, "", typeof(CategoryResponse))]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryAsync(string mark, string id, [FromQuery]GetBase args) {
            var response = new Response<CategoryResponse>();
            try {


            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 分类新闻列表
        /// </summary>
        /// <param name="mark">站点标识</param>
        /// <param name="id">新闻编号</param>
        /// <param name="args"></param>
        /// <returns></returns>
        [SwaggerResponse(200, "", typeof(List<NewsListResponse>))]
        [HttpGet("{id}/News")]
        public async Task<IActionResult> GetCategoryNewsAsync(string mark, string id, [FromQuery]GetPager args) {
            var response = new Response<Object>();
            try {

            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 栏目访问统计
        /// </summary>
        /// <param name="mark">站点标识</param>
        /// <param name="id">栏目编号</param>
        /// <returns></returns>
        [HttpGet("{id}/Access")]
        public async Task<IActionResult> GetCategoryAccessAsync(string mark, string id) {
            var response = new Response<Object>();
            try {


            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 栏目点击统计
        /// </summary>
        /// <param name="mark">站点标识</param>
        /// <param name="id">栏目编号</param>
        /// <returns></returns>
        [HttpGet("{id}/Click")]
        public async Task<IActionResult> GetCategoryClickAsync(string mark, string id) {
            var response = new Response<Object>();
            try {


            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
    }
}