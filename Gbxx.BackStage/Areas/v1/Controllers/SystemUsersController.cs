using Auto.Commons.ApiHandles.Responses;
using Auto.Commons.Linq;
using Auto.DataServices.Contracts;
using Auto.Entities.Modals;
using Gbxx.BackStage.Requests.Items;
using Gbxx.BackStage.Requests.Query;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gbxx.BackStage.Areas.v1.Controllers {
    /// <summary>
    /// 系统用户管理
    /// </summary>
    public class SystemUsersController : DefaultController {
        public ISystemUsersRepository _ISystemUsersRepository;
        private readonly ILogger _ILogger;
        /// <summary>
        /// 系统用户信息
        /// </summary>
        /// <param name="systemUsersRepository"></param>
        /// <param name="logger"></param>
        public SystemUsersController(ISystemUsersRepository systemUsersRepository, ILogger<SystemUsersController> logger) {
            this._ISystemUsersRepository = systemUsersRepository;
            this._ILogger = logger;
        }
        /// <summary>
        /// 用户列表分页查询
        /// </summary>
        /// <param name="args"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetSystemUsersAsync([FromQuery]SystemUsersQuery args) {
            var response = new Response<SystemUsers>();
            try {
                var p = P.Begin<SystemUsers>(true);
                if (!string.IsNullOrEmpty(args.UserName))
                    p = p.And(e => e.UsersName.Contains(args.UserName));
                if (!string.IsNullOrEmpty(args.LoginName))
                    p = p.And(e => e.LoginName == args.LoginName);
                if (!string.IsNullOrEmpty(args.Email))
                    p = p.And(e => e.Email.Contains(args.Email));
                if (args.IsEnable.HasValue)
                    p = p.And(e => e.IsEnable == args.IsEnable);

                //var result = await this._ISystemUsersRepository.QueryPager(p, e => e.LoginTime, true, args.PageIndex.Value, args.PageSize.Value);


                response.Code = true;
                //response.Data.Entities = result.Item2;
                //response.Data.PageCount = result.Item1;

            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 用户Info
        /// </summary>
        /// <param name="id">用户编号</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSystemUsersAsync(int? id) {
            var response = new Response<SystemUsers>();
            try {
                var entity = await this._ISystemUsersRepository.SingleAsync(e => e.UsersId == id);
                if (entity != null) {
                    response.Data = entity;
                }
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 用户更新
        /// </summary>
        /// <param name="requestModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> PostSystemUsersAsync([FromBody]SystemUsersRequest requestModel) {
            if (!ModelState.IsValid)
                return BadRequest(requestModel);
            var response = new Response<Object>();
            try {
                if (requestModel.UsersId <= 0) {
                    var entity = requestModel.ToEntity();
                    this._ISystemUsersRepository.Add(entity);
                    await this._ISystemUsersRepository.SaveChangesAsync();
                }
                else {
                    var entity = await this._ISystemUsersRepository.SingleAsync(e => e.UsersId == requestModel.UsersId);
                    if (entity != null) {
                        entity.UsersName = requestModel.UsersName;
                        entity.LoginName = requestModel.LoginName;
                        entity.Password = requestModel.Password;
                        entity.MobilePhone = requestModel.MobilePhone;
                        entity.Email = requestModel.Email;
                        entity.LoginIp = requestModel.LoginIp;
                        entity.LoginTime = requestModel.LoginTime;
                        entity.IsEnable = requestModel.IsEnable;
                        entity.Remarks = requestModel.Remarks;

                        this._ISystemUsersRepository.Update(entity);
                        await _ISystemUsersRepository.SaveChangesAsync();
                    }
                }
            }
            catch (Exception ex) {
                response.SetError(ex, this._ILogger);
            }
            return response.ToHttpResponse();
        }
        /// <summary>
        /// 用户对应菜单添加
        /// </summary>
        /// <param name="id">用户编号</param>
        /// <param name="menuIds">菜单编号列表</param>
        /// <returns></returns>
        [HttpPost("{id}/Menus")]
        public async Task<IActionResult> PostSystemUsersInMenuAsync(int? id, [FromBody]List<int> menuIds) {
            // Validate request model
            if (!id.HasValue)
                return BadRequest("请传递用户编号！");
            if (menuIds.Count <= 0)
                return BadRequest("请传递菜单编号列表！");
            var response = new Response<Object>();
            try {
                // Add entity to database
                var entity = await _ISystemUsersRepository.SingleAsync(e => e.UsersId == id);
                var inMenus = new List<SystemUsersInMenu>();
                menuIds.ForEach(x => {
                    entity.SystemMenus.Add(new SystemUsersInMenu() { UserId = id, MenuId = x });
                });
                await _ISystemUsersRepository.SaveChangesAsync();
            }
            catch (Exception ex) {
                response.SetError(ex, _ILogger);
            }

            return response.ToHttpResponse();
        }
        /// <summary>
        /// 用户对应角色添加
        /// </summary>
        /// <param name="id">用户编号</param>
        /// <param name="roleIds">角色编号列表</param>
        /// <returns></returns>
        [HttpPost("{id}/Roles")]
        public async Task<IActionResult> PostSystemUsersInRoleAsync(int? id, [FromBody]List<int> roleIds) {
            // Validate request model
            if (!id.HasValue)
                return BadRequest("请传递用户编号！");
            if (roleIds.Count <= 0)
                return BadRequest("请传递角色编号列表！");
            var response = new Response<Object>();
            try {
                // Add entity to database
                var entity = await _ISystemUsersRepository.SingleAsync(e => e.UsersId == id);
                var inMenus = new List<SystemUsersInRole>();
                roleIds.ForEach(x => {
                    entity.SystemRoles.Add(new SystemUsersInRole() { UsersId = id, RoleId = x });
                });
                await _ISystemUsersRepository.SaveChangesAsync();
            }
            catch (Exception ex) {
                response.SetError(ex, _ILogger);
            }

            return response.ToHttpResponse();
        }

        //[HttpPut("SystemUsers")]
        //public async Task<IActionResult> PutSystemUsersAsync(int? id, [FromBody]SystemUsersRequestModel requestModel) {
        //    this._ILogger?.LogDebug("'{0}' has been invoked", nameof(PutSystemUsersAsync));

        //    // Validate request model
        //    if (!ModelState.IsValid)
        //        return BadRequest(requestModel);

        //    var response = new SingleResponse<SystemUsersRequestModel>();

        //    try {
        //        // Retrieve entity by id
        //        var entity = await this._ISystemUsersRepository.GetSystemUsersAsync(new SystemUsers(id));

        //        if (entity != null) {
        //            // todo:  Check properties to update
        //            // Apply changes on entity
        //            entity.UsersName = requestModel.UsersName;
        //            entity.LoginName = requestModel.LoginName;
        //            entity.Password = requestModel.Password;
        //            entity.MobilePhone = requestModel.MobilePhone;
        //            entity.Email = requestModel.Email;
        //            entity.LoginIp = requestModel.LoginIp;
        //            entity.LoginTime = requestModel.LoginTime;
        //            entity.IsEnable = requestModel.IsEnable;
        //            entity.Remarks = requestModel.Remarks;
        //            entity.CreateBy = requestModel.CreateBy;
        //            entity.CreateTime = requestModel.CreateTime;

        //            // Save changes for entity in database
        //            await this._ISystemUsersRepository.UpdateSystemUsersAsync(entity);

        //            this._ILogger?.LogInformation("The entity was updated successfully");

        //            response.Model = entity.ToRequestModel();
        //        }
        //    }
        //    catch (Exception ex) {
        //        response.SetError(ex, this._ILogger);
        //    }

        //    return response.ToHttpResponse();
        //}
        //[HttpDelete("SystemUsers")]
        //public async Task<IActionResult> DeleteSystemUsersAsync(int? id) {
        //    this._ILogger?.LogDebug("'{0}' has been invoked", nameof(DeleteSystemUsersAsync));

        //    var response = new SingleResponse<SystemUsersRequestModel>();

        //    try {
        //        // Retrieve entity by id
        //        var entity = await this._ISystemUsersRepository.GetSystemUsersAsync(new SystemUsers(id));

        //        if (entity != null) {
        //            // Remove entity from database
        //            await this._ISystemUsersRepository.RemoveSystemUsersAsync(entity);

        //            this._ILogger?.LogInformation("The entity was deleted successfully");

        //            response.Model = entity.ToRequestModel();
        //        }
        //    }
        //    catch (Exception ex) {
        //        response.SetError(ex, this._ILogger);
        //    }

        //    return response.ToHttpResponse();
        //}
        //[HttpGet("SystemUsersInDictionary")]
        //public async Task<IActionResult> GetSystemUsersInDictionariesAsync(int? pageSize = 10, int? pageNumber = 1, int? usersId = null) {
        //    this._ILogger?.LogDebug("'{0}' has been invoked", nameof(GetSystemUsersInDictionariesAsync));

        //    var response = new PagedResponse<SystemUsersInDictionary>();

        //    try {
        //        // Get query from repository
        //        var query = this._ISystemUsersRepository.GetSystemUsersInDictionaries(usersId);

        //        // Set paging's information
        //        response.PageSize = (int)pageSize;
        //        response.PageNumber = (int)pageNumber;
        //        response.ItemsCount = await query.CountAsync();

        //        // Retrieve items by page size and page number, set model for response
        //        response.Model = await query.Paging(response.PageSize, response.PageNumber).ToListAsync();

        //        this._ILogger?.LogInformation("Page {0} of {1}, Total of rows: {2}", response.PageNumber, response.PageCount, response.ItemsCount);
        //    }
        //    catch (Exception ex) {
        //        response.SetError(ex, this._ILogger);
        //    }

        //    return response.ToHttpResponse();
        //}
        //[HttpGet("SystemUsersInDictionary/{id}")]
        //public async Task<IActionResult> GetSystemUsersInDictionaryAsync(int? id) {
        //    this._ILogger?.LogDebug("'{0}' has been invoked", nameof(GetSystemUsersInDictionaryAsync));

        //    var response = new SingleResponse<SystemUsersInDictionaryRequestModel>();

        //    try {
        //        // Retrieve entity by id
        //        var entity = await this._ISystemUsersRepository.GetSystemUsersInDictionaryAsync(new SystemUsersInDictionary(id));

        //        if (entity != null) {
        //            response.Model = entity.ToRequestModel();

        //            this._ILogger?.LogInformation("The entity was retrieved successfully");
        //        }
        //    }
        //    catch (Exception ex) {
        //        response.SetError(ex, this._ILogger);
        //    }

        //    return response.ToHttpResponse();
        //}
        //[HttpPost("SystemUsersInDictionary")]
        //public async Task<IActionResult> PostSystemUsersInDictionaryAsync([FromBody]SystemUsersInDictionaryRequestModel requestModel) {
        //    this._ILogger?.LogDebug("'{0}' has been invoked", nameof(PostSystemUsersInDictionaryAsync));

        //    // Validate request model
        //    if (!ModelState.IsValid)
        //        return BadRequest(requestModel);

        //    var response = new SingleResponse<SystemUsersInDictionaryRequestModel>();

        //    try {
        //        var entity = requestModel.ToEntity();

        //        // Add entity to database
        //        await this._ISystemUsersRepository.AddSystemUsersInDictionaryAsync(entity);

        //        response.Model = entity.ToRequestModel();

        //        this._ILogger?.LogInformation("The entity was created successfully");
        //    }
        //    catch (Exception ex) {
        //        response.SetError(ex, this._ILogger);
        //    }

        //    return response.ToHttpResponse();
        //}
        //[HttpPut("SystemUsersInDictionary")]
        //public async Task<IActionResult> PutSystemUsersInDictionaryAsync(int? id, [FromBody]SystemUsersInDictionaryRequestModel requestModel) {
        //    this._ILogger?.LogDebug("'{0}' has been invoked", nameof(PutSystemUsersInDictionaryAsync));

        //    // Validate request model
        //    if (!ModelState.IsValid)
        //        return BadRequest(requestModel);

        //    var response = new SingleResponse<SystemUsersInDictionaryRequestModel>();

        //    try {
        //        // Retrieve entity by id
        //        var entity = await this._ISystemUsersRepository.GetSystemUsersInDictionaryAsync(new SystemUsersInDictionary(id));

        //        if (entity != null) {
        //            // todo:  Check properties to update
        //            // Apply changes on entity
        //            entity.UserId = requestModel.UserId;
        //            entity.DictionaryKey = requestModel.DictionaryKey;
        //            entity.DictionaryValue = requestModel.DictionaryValue;

        //            // Save changes for entity in database
        //            await this._ISystemUsersRepository.UpdateSystemUsersInDictionaryAsync(entity);

        //            this._ILogger?.LogInformation("The entity was updated successfully");

        //            response.Model = entity.ToRequestModel();
        //        }
        //    }
        //    catch (Exception ex) {
        //        response.SetError(ex, this._ILogger);
        //    }

        //    return response.ToHttpResponse();
        //}
        //[HttpDelete("SystemUsersInDictionary")]
        //public async Task<IActionResult> DeleteSystemUsersInDictionaryAsync(int? id) {
        //    this._ILogger?.LogDebug("'{0}' has been invoked", nameof(DeleteSystemUsersInDictionaryAsync));

        //    var response = new SingleResponse<SystemUsersInDictionaryRequestModel>();

        //    try {
        //        // Retrieve entity by id
        //        var entity = await this._ISystemUsersRepository.GetSystemUsersInDictionaryAsync(new SystemUsersInDictionary(id));

        //        if (entity != null) {
        //            // Remove entity from database
        //            await this._ISystemUsersRepository.RemoveSystemUsersInDictionaryAsync(entity);

        //            this._ILogger?.LogInformation("The entity was deleted successfully");

        //            response.Model = entity.ToRequestModel();
        //        }
        //    }
        //    catch (Exception ex) {
        //        response.SetError(ex, this._ILogger);
        //    }

        //    return response.ToHttpResponse();
        //}
        //[HttpGet("SystemUsersInMenu")]
        //public async Task<IActionResult> GetSystemUsersInMenusAsync(int? pageSize = 10, int? pageNumber = 1) {
        //    this._ILogger?.LogDebug("'{0}' has been invoked", nameof(GetSystemUsersInMenusAsync));

        //    var response = new PagedResponse<SystemUsersInMenu>();

        //    try {
        //        // Get query from repository
        //        var query = this._ISystemUsersRepository.GetSystemUsersInMenus();

        //        // Set paging's information
        //        response.PageSize = (int)pageSize;
        //        response.PageNumber = (int)pageNumber;
        //        response.ItemsCount = await query.CountAsync();

        //        // Retrieve items by page size and page number, set model for response
        //        response.Model = await query.Paging(response.PageSize, response.PageNumber).ToListAsync();

        //        this._ILogger?.LogInformation("Page {0} of {1}, Total of rows: {2}", response.PageNumber, response.PageCount, response.ItemsCount);
        //    }
        //    catch (Exception ex) {
        //        response.SetError(ex, this._ILogger);
        //    }

        //    return response.ToHttpResponse();
        //}
        //[HttpPost("SystemUsersInMenu")]
        //public async Task<IActionResult> PostSystemUsersInMenuAsync([FromBody]SystemUsersInMenuRequestModel requestModel) {
        //    this._ILogger?.LogDebug("'{0}' has been invoked", nameof(PostSystemUsersInMenuAsync));

        //    // Validate request model
        //    if (!ModelState.IsValid)
        //        return BadRequest(requestModel);

        //    var response = new SingleResponse<SystemUsersInMenuRequestModel>();

        //    try {
        //        var entity = requestModel.ToEntity();

        //        // Add entity to database
        //        await this._ISystemUsersRepository.AddSystemUsersInMenuAsync(entity);

        //        response.Model = entity.ToRequestModel();

        //        this._ILogger?.LogInformation("The entity was created successfully");
        //    }
        //    catch (Exception ex) {
        //        response.SetError(ex, this._ILogger);
        //    }

        //    return response.ToHttpResponse();
        //}
        //[HttpGet("SystemUsersInRole")]
        //public async Task<IActionResult> GetSystemUsersInRolesAsync(int? pageSize = 10, int? pageNumber = 1) {
        //    this._ILogger?.LogDebug("'{0}' has been invoked", nameof(GetSystemUsersInRolesAsync));

        //    var response = new PagedResponse<SystemUsersInRole>();

        //    try {
        //        // Get query from repository
        //        var query = this._ISystemUsersRepository.GetSystemUsersInRoles();

        //        // Set paging's information
        //        response.PageSize = (int)pageSize;
        //        response.PageNumber = (int)pageNumber;
        //        response.ItemsCount = await query.CountAsync();

        //        // Retrieve items by page size and page number, set model for response
        //        response.Model = await query.Paging(response.PageSize, response.PageNumber).ToListAsync();

        //        this._ILogger?.LogInformation("Page {0} of {1}, Total of rows: {2}", response.PageNumber, response.PageCount, response.ItemsCount);
        //    }
        //    catch (Exception ex) {
        //        response.SetError(ex, this._ILogger);
        //    }

        //    return response.ToHttpResponse();
        //}
        //[HttpPost("SystemUsersInRole")]
        //public async Task<IActionResult> PostSystemUsersInRoleAsync([FromBody]SystemUsersInRoleRequestModel requestModel) {
        //    this._ILogger?.LogDebug("'{0}' has been invoked", nameof(PostSystemUsersInRoleAsync));

        //    // Validate request model
        //    if (!ModelState.IsValid)
        //        return BadRequest(requestModel);

        //    var response = new SingleResponse<SystemUsersInRoleRequestModel>();

        //    try {
        //        var entity = requestModel.ToEntity();

        //        // Add entity to database
        //        await this._ISystemUsersRepository.AddSystemUsersInRoleAsync(entity);

        //        response.Model = entity.ToRequestModel();

        //        this._ILogger?.LogInformation("The entity was created successfully");
        //    }
        //    catch (Exception ex) {
        //        response.SetError(ex, this._ILogger);
        //    }

        //    return response.ToHttpResponse();
        //}
    }
}