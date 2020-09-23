using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Auto.Commons.ApiHandles.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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
        /// 分类信息
        /// </summary>
        /// <param name="mark">站点标识</param>
        /// <param name="id">分类编号</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryAsync(string mark, string id) {
            var response = new Response<Object>();
            try {


            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 分类列表
        /// </summary>
        /// <param name="mark">站点标识</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetCategoriesAsync(string mark) {
            var response = new Response<Object>();
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
        /// <param name="pageIndex">当前页</param>
        /// <param name="pageSize">页大小</param>
        /// <returns></returns>
        [HttpGet("{id}/News")]
        public async Task<IActionResult> GetCategoryNewsAsync(string mark, string id, int pageIndex = 1, int pageSize = 10) {
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