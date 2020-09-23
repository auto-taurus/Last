using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Auto.Commons.ApiHandles.Responses;
using Gbxx.WebApi.Requests.Query;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetNewsAsync(string mark, string id) {
            var response = new Response<Object>();
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
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("Carousel")]
        public async Task<IActionResult> GetNewsCarouselAsync(string mark) {
            var response = new Response<Object>();
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
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("Big")]
        public async Task<IActionResult> GetNewsBigAsync(string mark) {
            var response = new Response<Object>();
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
        /// <returns></returns>
        [HttpGet("{id}/Access")]
        public async Task<IActionResult> GetNewsAccessAsync(string mark, string id) {
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
        /// <returns></returns>
        [HttpGet("{id}/Click")]
        public async Task<IActionResult> GetNewsClickAsync(string mark, string id) {
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
        /// <param name="item">过滤信息</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> PostNewsSearchAsync(string mark, [FromBody] NewsSearchQuery item) {
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