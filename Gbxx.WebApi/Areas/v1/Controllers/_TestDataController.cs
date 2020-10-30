using Auto.ElasticServices.Modals;
using Auto.Commons.ApiHandles.Responses;
using Auto.Commons.Systems;
using Auto.DataServices.Contracts;
using Auto.Entities.Modals;
using Auto.ElasticServices.Contracts;
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
        public async Task<IActionResult> PostNewsDocAsync([FromRoute]SiteRoute route,
                                                          string newsId = "10000000") {
            var response = new Response<Object>();
            try {
                var categories = await _IWebCategoryRepository.Query(a => a.SiteId == route.mark && a.IsEnable == 1,
                                                                          a => a.Sequence).ToListAsync();

                var iidn = await _IWebNewsElastic.AddIndexAsync(_IWebNewsElastic.IndexName);
                for (int pageIndex = 1; pageIndex <= 2; pageIndex++) {
                    var news = new List<WebNews>();
                    news = _IMySqlRepository.GetList(1, pageIndex, 100000, Convert.ToInt32(newsId));
                    //var cateSources = news.GroupBy(a => a.CategoryId,
                    //                          (CategoryId, CategoryGroup) => new { CategoryId, Source = CategoryGroup.GroupBy(b => b.Source.Trim()).ToList() }).ToList();

                    //var sources = news.GroupBy(a => a.Source)
                    //                  .Select(a => new { a.First().Source })
                    //                  .ToList();
                    //var number = (int)Math.Ceiling(sources.Count / 1999.0);
                    //var index = 0;
                    //for (var i = 0; i < number; i++) {
                    //    if (i > 0)
                    //        index = i * 1999;
                    //    var sou = sources.Skip(index).Take(1999).ToList();

                    //}
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
                        if (newsDatas.Count > 0)
                            await _IWebNewsRepository.BatchAddAsync(news);
                        if (docs.Count > 0)
                            response.Other += (await _IWebNewsElastic.BatchAddDocumentAsync(_IWebNewsElastic.IndexName, docs)).ToString() + "a|" + docs.Count;
                    }
                }
                response.Code = true;
                response.Other = iidn;
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            response.Data = newsId;
            return response.ToHttpResponse();
        }

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