using Auto.Entities.Modals;
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