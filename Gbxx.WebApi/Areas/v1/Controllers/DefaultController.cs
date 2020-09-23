using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Gbxx.WebApi.Areas.v1.Controllers {
    [Route("v1/{mark}/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class DefaultController : ControllerBase {
    }
}