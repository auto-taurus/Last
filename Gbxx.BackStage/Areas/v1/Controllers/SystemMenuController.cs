using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Auto.Commons.ApiHandles.Responses;
using Auto.DataServices.Contracts;
using Gbxx.BackStage.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Gbxx.BackStage.Areas.v1.Controllers {
    [Route("v1/[controller]")]
    public class SystemMenuController : DefaultController {

        private readonly ILogger _ILogger;
        /// <summary>
        /// 
        /// </summary>
        protected ISystemMenuRepository _ISystemMenuRepository;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="systemMenuRepository"></param>
        public SystemMenuController(ILogger<SystemMenuController> logger,
                                    ISystemMenuRepository systemMenuRepository) {
            this._ILogger = logger;
            this._ISystemMenuRepository = systemMenuRepository;
        }

        /// <summary>
        /// 获取系统菜单列表
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetSystemMenuAsync() {
            var response = new Response<Object>();
            try {
                response.Code = true;
                response.Data = await _ISystemMenuRepository.Query()
                                                            .OrderBy(a => a.Sequence)
                                                            .Select(a => new {
                                                                a.MenuId,
                                                                a.MenuIcon,
                                                                a.MenuName,
                                                                a.ParentId,
                                                                a.NodeValue,
                                                                a.Urls,
                                                                a.RouterName,
                                                                a.RouterPath,
                                                                a.Component,
                                                                a.ShowAlways,
                                                                a.ShowHeader,
                                                                a.HideInBread,
                                                                a.HideInMenu,
                                                                a.NotCache,
                                                                a.BeforeCloseName,
                                                                a.IsEnable,
                                                                a.Remarks,
                                                                a.CreateBy,
                                                                a.CreateTime
                                                            })
                                                            .ToListAsync();
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
    }
}