using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Auto.EFCore.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gbxx.BackStage.Areas.v1.Controllers {
    /// <summary>
    /// 
    /// </summary>
    [Route("v1/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase {
        public SystemUsers _LoginUser { get; set; }
    }
}