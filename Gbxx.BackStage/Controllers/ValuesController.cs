using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Auto.DataServices.Contracts;
using Auto.EFCore.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Gbxx.BackStage.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase {
        private ISystemUsersRepository _ISystemUsersRepository;
        public ValuesController(ISystemUsersRepository systemUsersRepository) {
            this._ISystemUsersRepository = systemUsersRepository;
        }
        // GET api/values
        [HttpGet]
        public async Task<ActionResult> Get() {
            return Ok();
        }
    }
}
