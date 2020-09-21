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
            var item = new WebSpecial() { SpecialCode = "C00001" };
            var item1 = new WebSpecial() { SpecialCode = "C00002", CreateTime = System.DateTime.Now };
            var list = new List<WebSpecial>();
            list.Add(item);
            list.Add(item1);
            var result = await this._ISystemUsersRepository.QueryPager(e => e.SpecialId > 1, e => e.CreateTime, true);
            await this._ISystemUsersRepository.BatchAddAsync(list);

            await this._ISystemUsersRepository.BatchUpdateAsync(e => e.SpecialId == 1, e => new WebSpecial {
                CreateBy = 1
            });
            //this._ISystemUsersRepository.CommitChangesAsync();
            return Ok(result);
        }
    }
}
