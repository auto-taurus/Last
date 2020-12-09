using Auto.Commons;
using Auto.Commons.ApiHandles.Responses;
using Auto.Commons.Systems;
using Auto.Configurations;
using Auto.DataServices.Contracts;
using Auto.ElasticServices.Contracts;
using Auto.ElasticServices.Modals;
using Auto.Entities.Modals;
using Auto.RedisServices;
using Gbxx.WebApi.Areas.v1.Models.Route;
using Gbxx.WebApi.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.WebApi.Areas.v1.Controllers {

    /// <summary>
    /// 
    /// </summary>
    [Route("v1/[controller]", Order = 0)]
    [ApiController]
    [Produces("application/json")]
    public class _TestDataController : ControllerBase {
        /// <summary>
        /// 
        /// </summary>
        protected readonly ILogger _ILogger;
        /// <summary>
        /// 
        /// </summary>
        protected IMySqlRepository _IMySqlRepository;
        /// <summary>
        /// 
        /// </summary>
        protected IWebNewsElastic _IWebNewsElastic;
        /// <summary>
        /// 
        /// </summary>
        protected IRedisStore _IRedisStore;
        /// <summary>
        /// 
        /// </summary>
        protected IWebNewsRepository _IWebNewsRepository;
        /// <summary>
        /// 
        /// </summary>
        protected IWebCategoryRepository _IWebCategoryRepository;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="webNewsElastic"></param>
        /// <param name="mySqlRepository"></param>
        /// <param name="webNewsRepository"></param>
        /// <param name="webCategoryRepository"></param>
        public _TestDataController(
            ILogger<_TestDataController> logger,
            IWebNewsElastic webNewsElastic,
            IMySqlRepository mySqlRepository,
            IWebNewsRepository webNewsRepository,
            IWebCategoryRepository webCategoryRepository) {
            this._ILogger = logger;
            this._IWebNewsElastic = webNewsElastic;
            this._IMySqlRepository = mySqlRepository;
            this._IWebNewsRepository = webNewsRepository;
            this._IWebCategoryRepository = webCategoryRepository;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <param name="newsId"></param>
        /// <returns></returns>
        [HttpGet("{mark}/NewsDoc")]
        //[HiddenApi]
        public async Task<IActionResult> PostNewsDocAsync([FromHeader]String source,
                                                          [FromRoute]SiteRoute route,
                                                          string newsId = "10000000") {
            var response = new Response<Object>();
            try {
                var categories = await _IWebCategoryRepository.Query(a => a.SiteId == route.mark && a.IsEnable == 1,
                                                                          a => a.Sequence).ToListAsync();

                var iidn = await _IWebNewsElastic.AddIndexAsync(_IWebNewsElastic.IndexName);
                for (int pageIndex = 1; pageIndex <= 20; pageIndex++) {
                    var news = new List<WebNews>();
                    news = _IMySqlRepository.GetList(1, pageIndex, 100000, Convert.ToInt32(newsId));
                    var lastNews = news.LastOrDefault();
                    if (lastNews != null) {
                        newsId = news.LastOrDefault().NewsId;
                        var docs = new List<WebNewsDoc>();
                        var newsDatas = new List<WebNews>();
                        news.ForEach(x => {
                            var category = categories.SingleOrDefault(a => a.CategoryName == x.CategoryName);
                            if (category != null) {
                                newsDatas.Add(SetWebNews(x, category));
                                docs.Add(GetWebNewsDoc(x));
                            }
                        });
                        //if (newsDatas.Count > 0)
                        //    await _IWebNewsRepository.BatchAddAsync(newsDatas);//写入数据库
                        if (docs.Count > 0)
                            response.Other += (await _IWebNewsElastic.BatchAddDocumentAsync(_IWebNewsElastic.IndexName, docs)).ToString() + "a|" + docs.Count;//写入es
                    }
                }
                response.Code = true;
                response.Other = null;
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            response.Data = newsId;
            return response.ToHttpResponse();
        }


        /// <summary>
        /// 批量导入es（本地db）
        /// </summary>
        /// <param name="source"></param>
        /// <param name="route"></param>
        /// <param name="newsId"></param>
        /// <returns></returns>
        [HttpGet("{mark}/NewsDoc/Localhost")]
        public async Task<IActionResult> PostNewsDocLocalHostAsync([FromHeader]String source,
                                                        [FromRoute]SiteRoute route,
                                                        DateTime pushTime
                                                        ) {
            var response = new Response<Object>();
            try {
                var categories = await _IWebCategoryRepository.Query(a => a.SiteId == route.mark && a.IsEnable == 1, a => a.Sequence).ToListAsync();

                var iidn = await _IWebNewsElastic.AddIndexAsync(_IWebNewsElastic.IndexName);
                List<WebNews> news = null;
                for (int pageIndex = 1; pageIndex <= 50; pageIndex++) {
                    news = await _IWebNewsRepository.Query(c => c.SiteId == route.mark
                                                                                              && c.IsEnable == 1
                                                                                              && c.PushTime <= pushTime)
                                                                          .ToPager(pageIndex, 50000).ToListAsync();

                    var docs = new List<WebNewsDoc>();
                    news.ForEach(x => {
                        var category = categories.SingleOrDefault(a => a.CategoryName == x.CategoryName);
                        if (category != null) {
                            docs.Add(GetWebNewsDoc(x));
                        }
                    });
                    if (docs.Count > 0) {
                        response.Other += (await _IWebNewsElastic.BatchAddDocumentAsync(_IWebNewsElastic.IndexName, docs)).ToString() + "a|" + docs.Count;//写入es
                        response.Code = true;
                    }
                }
            }
            catch (Exception ex) {
                LogHelper.LogError("错误信息:{0}", ex.Message + ex.StackTrace);
            }
            response.Data = "";
            return response.ToHttpResponse();
        }

        ///// <summary>
        ///// 删除文档
        ///// </summary>
        ///// <param name="source"></param>
        ///// <param name="route"></param>
        ///// <returns></returns>
        //[HttpGet]
        //public async Task<IActionResult> DeleteNewsDocAsync([FromHeader]String source,
        //                                                  [FromRoute]SiteRoute route) {
        //    var response = new Response<Object>();
        //    bool result = false;
        //    int flagCount = 0;
        //    List<string> FailList = new List<string>();
        //    try {
        //        //读取文件批量删除文档
        //        string basePath = AppDomain.CurrentDomain.BaseDirectory;
        //        string filePath = System.IO.Path.Combine(basePath, "data.text");
        //        string[] newsIdArrr = System.IO.File.ReadAllLines(filePath);

        //        foreach (var item in newsIdArrr) {
        //            result = await _IWebNewsElastic.RemoveDocumentAsync(_IWebNewsElastic.IndexName, item);
        //            if (result)
        //                flagCount++;
        //            else {
        //                FailList.Add(item);//失败的记录
        //            }
        //        }
        //    }
        //    catch (Exception) {

        //        throw;
        //    }
        //    response.Code = result;
        //    response.Data = FailList;
        //    response.Message = $"Success,{flagCount}";
        //    return response.ToHttpResponse();
        //}
        private WebNewsDoc GetWebNewsDoc(WebNews x) {
            return new WebNewsDoc() {
                SiteId = x.SiteId,
                NewsId = x.NewsId,
                CategoryId = x.CategoryId,
                CategoryName = x.CategoryName,
                SpecialCode = x.SpecialCode,
                NewsTitle = x.CustomTitle,
                Source = x.Source,
                Author = x.Author,
                Tags = string.IsNullOrEmpty(x.Tags) ? null : x.Tags.Split(","),
                Contents = x.Contents,
                Curl = x.Urls,
                Img = x.ImageThums,
                ImagePath = x.ImagePaths,
                DisplayType = x.DisplayType,
                IsHot = x.IsHot,
                AccessCount = x.VirtualAccessNumber,
                PushTime = x.PushTime,
                CreateTime = x.CreateTime,
                CategorySort = x.CategorySort,
                SpecialSort = x.SpecialSort,
                Sequence = x.Sequence
            };
        }
        private WebNews SetWebNews(WebNews item, WebCategory category) {

            item.NewsId = SnowFlake.NewId;
            if (string.IsNullOrEmpty(item.CustomTitle) && !string.IsNullOrEmpty(item.NewsTitle)) {
                item.CustomTitle = item.NewsTitle;
                item.NewsTitle = "";
            }
            if (item.SpecialCode == "C0000")
                item.SpecialCode = null;
            item.CategoryId = category.CategoryId;
            item.CategoryName = category.CategoryName;
            item.AccessNumber = 0;
            item.ClickNumber = 0;
            item.AuditBy = 1;
            item.AuditStatus = 1;
            item.AuditTime = item.PushTime;
            item.PushStatus = 1;
            item.PushBy = 1;
            item.OperateType = 5;
            item.IsEnable = 1;
            item.Remarks = "管理员手动同步";
            item.CreateBy = 1;
            item.CreateTime = System.DateTime.Now;
            return item;
        }
    }
}