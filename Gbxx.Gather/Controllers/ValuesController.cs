using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Auto.Commons;
using Auto.Commons.Systems;
using Auto.DataServices.Contracts;
using Auto.ElasticServices.Contracts;
using Auto.ElasticServices.Modals;
using Auto.Entities.Modals;
using Gbxx.Gather.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Gbxx.Gather.Controllers {
    /// <summary>
    /// 
    /// </summary>
    [Route("gather")]
    [ApiController]
    public class ValuesController : ControllerBase {
        /// <summary>
        /// 
        /// </summary>
        protected readonly ILogger _ILogger;
        /// <summary>
        /// 
        /// </summary>
        protected IWebNewsElastic _IWebNewsElastic;
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
        /// <param name="webNewsRepository"></param>
        /// <param name="webCategoryRepository"></param>
        public ValuesController(
            ILogger<ValuesController> logger,
            IWebNewsElastic webNewsElastic,
            IWebNewsRepository webNewsRepository,
            IWebCategoryRepository webCategoryRepository) {
            this._ILogger = logger;
            this._IWebNewsElastic = webNewsElastic;
            this._IWebNewsRepository = webNewsRepository;
            this._IWebCategoryRepository = webCategoryRepository;
        }
        /// <summary>
        /// 同步新闻数据
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> PostWebNewsAsync([FromBody]List<GatherPost> item) {
            try {
                var categories = await _IWebCategoryRepository.Query(a => a.IsEnable == 1 && a.SiteId == 1)
                                                         .ToListAsync();
                var entities = new List<WebNews>();
                var docs = new List<WebNewsDoc>();

                item.ForEach(x => {
                    var category = categories.FirstOrDefault(y => y.CategoryName == x.cate_name);
                    if (category != null) {
                        var entity = GetNewsEntity(category, x);
                        var doc = GetNewsDoc(entity);
                        entities.Add(entity);
                        docs.Add(doc);
                    }
                });

                if (entities.Count > 0) {
                  var resultDB =  await _IWebNewsRepository.BatchAddAsync(entities);
                }

                if (docs.Count > 0) {
                  var resultES=  await _IWebNewsElastic.BatchAddDocumentAsync(_IWebNewsElastic.IndexName, docs);
                }
            }
            catch (Exception ex) {
                LogHelper.LogError("错误信息:{0}", ex.Message + ex.StackTrace);
            }
            return Ok();
        }
        private WebNewsDoc GetNewsDoc(WebNews x) {
            return new WebNewsDoc() {
                SiteId = x.SiteId,
                NewsId = x.NewsId,
                CategoryId = x.CategoryId,
                CategoryName = x.CategoryName,
                SpecialCode = x.SpecialCode,
                NewsTitle = x.CustomTitle,
                Source = x.Source,
                Author = x.Author,
                Tags = string.IsNullOrEmpty(x.Tags) ? null : x.Tags.Split("∮"),
                Contents = x.Contents,
                ContentType=x.ContentType,
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
        private WebNews GetNewsEntity(WebCategory category, GatherPost x) {
            var entity = new WebNews();
            entity.NewsId = SnowFlake.NewId;
            entity.CategoryId = category.CategoryId;
            entity.CategoryName = category.CategoryName; //分类名称

            //entity.SiteId = x.site_id; //站点标识
            entity.SiteId = 1; //站点标识

            //entity.NewsTitle = x.title; //新闻标题
            entity.CustomTitle = x.title; //自定义标题

            entity.Contents = x.content; //内容
            entity.ContentType = x.content_type;//内容类型
            entity.Tags = x.tag.Replace(',', '∮'); //标签
            entity.Source = x.from; //来源
            entity.SourceLogo = x.from_pic; //来源Logo

            entity.Title = x.title; //网页标题
            entity.Keywords = x.search_word; //网页关键字
            entity.Description = x.title; // 网页描述
            if (!string.IsNullOrEmpty(x.thumbpic)) {
                var thumbpic = x.thumbpic.Split(',');
                for (var i = 0; i < thumbpic.Length; i++) {
                    thumbpic[i] = thumbpic[i] + "?x-oss-process=style/xiaotu";
                }
                entity.ImageThums = string.Join('∮', thumbpic); // 缩略图
                //entity.ImagePaths = x.thumbpic.Replace(',', '∮'); // 大图由运维人员去设置
            }

            entity.Controller = "/Content";
            entity.Action = "/Index";
            entity.Urls = "/Content/Index";

            entity.Author = "admin";
            entity.CategorySort = 255;
            entity.SpecialSort = 255;
            entity.Sequence = 255;

            entity.AuditBy = 1; // 审核人
            entity.AuditStatus = 1;// 审核状态
            entity.AuditTime = System.DateTime.Now;

            entity.IsEnable = 1; // 有效

            entity.PushBy = 1; // 发布人
            entity.PushStatus = 1; // 已发布
            entity.PushTime = System.DateTime.Now; // 发布时间

            entity.OperateType = 4; //同步
            entity.CreateBy = 1; //创建人
            entity.CreateTime = System.DateTime.Now;//创建时间

            var codeNumber = new Random().Next(0, 12);
            if (codeNumber > 0)
                entity.SpecialCode = string.Format("C{0:d4}", codeNumber); //

            entity.DisplayType = new Random().Next(0, 1); //
            entity.IsHot = new Random().Next(0, 1); //
            entity.VirtualAccessNumber = new Random().Next(1000, 200000); //

            entity.Remarks = "PHP采集同步！";
            return entity;
        }
    }
}
