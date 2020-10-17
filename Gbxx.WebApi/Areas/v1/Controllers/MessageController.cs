using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gbxx.WebApi.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gbxx.WebApi.Areas.v1.Controllers
{
    [Route("v1/[controller]")]
    public class MessageController : AuthorizeController {

    }
}