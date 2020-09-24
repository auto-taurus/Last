using Auto.Commons.ApiHandles.Responses;
using Gbxx.WebApi.Areas.v1.Data;
using Gbxx.WebApi.Areas.v1.Models.Get;
using Gbxx.WebApi.Requests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Controllers {
    /// <summary>
    /// 新闻管理
    /// </summary>
    public class NewsController : DefaultController {
        protected readonly ILogger _ILogger;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        public NewsController(ILogger<SiteController> logger) {
            this._ILogger = logger;
        }
        /// <summary>
        /// 新闻信息
        /// </summary>
        /// <param name="mark"></param>
        /// <param name="id"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [SwaggerResponse(200, "", typeof(NewsResponse))]
        public async Task<IActionResult> GetNewsAsync(string mark, string id, [FromQuery]GetBase args) {
            var response = new Response<NewsResponse>();
            try {


            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 新闻首页轮播列表
        /// </summary>
        /// <param name="mark"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        [HttpGet("Carousel")]
        [SwaggerResponse(200, "", typeof(List<NewsListResponse>))]
        public async Task<IActionResult> GetNewsCarouselAsync(string mark, [FromQuery]GetPager args) {
            var response = new Response<List<NewsListResponse>>();
            try {


            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 新闻首页大标信息
        /// </summary>
        /// <param name="mark"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        [HttpGet("Big")]
        [SwaggerResponse(200, "", typeof(NewsListResponse))]
        public async Task<IActionResult> GetNewsBigAsync(string mark, [FromQuery]GetBase args) {
            var response = new Response<NewsListResponse>();
            try {


            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 新闻访问统计
        /// </summary>
        /// <param name="mark">站点标识</param>
        /// <param name="id">文章编号</param>
        /// <param name="args"></param>
        /// <returns></returns>
        [HttpGet("{id}/Access")]
        public async Task<IActionResult> GetNewsAccessAsync(string mark, string id, [FromQuery]GetBase args) {
            var response = new Response<Object>();
            try {


            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 新闻点击统计
        /// </summary>
        /// <param name="mark">站点标识</param>
        /// <param name="id">文章编号</param>
        /// <param name="args"></param>
        /// <returns></returns>
        [HttpGet("{id}/Click")]
        public async Task<IActionResult> GetNewsClickAsync(string mark, string id, [FromQuery]GetBase args) {
            var response = new Response<Object>();
            try {


            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 新闻信息检索
        /// </summary>
        /// <param name="mark">站点标识</param>
        /// <param name="args"></param>
        /// <returns></returns>
        [SwaggerResponse(200, "", typeof(List<NewsListResponse>))]
        [HttpGet("Tag")]
        public async Task<IActionResult> GetNewsSearchAsync(string mark, [FromQuery]GetNewsSearch args) {
            var response = new Response<List<NewsListResponse>>();
            try {

            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 文章热门访问
        /// </summary>
        /// <param name="mark">站点标识</param>
        /// <param name="args"></param>
        /// <returns></returns>
        [SwaggerResponse(200, "", typeof(List<NewsListResponse>))]
        [HttpGet("Hot")]
        public async Task<IActionResult> GetNewsHotAsync(string mark, [FromQuery]GetNewsHot args) {
            var response = new Response<List<NewsListResponse>>();
            try {

            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
    }
}