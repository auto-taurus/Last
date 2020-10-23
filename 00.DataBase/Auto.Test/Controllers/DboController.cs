using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NorthwindWebAPI.DataLayer.Contracts;
using NorthwindWebAPI.DataLayer.Repositories;
using Northwind.WebAPI.Responses;
using Northwind.WebAPI.RequestModels;
using NorthwindWebAPI.EntityLayer;

namespace Northwind.WebAPI.Controllers
{
	[Route("api/[controller]")]
	public class DboController : Controller
	{
		protected readonly IDboRepository Repository;
		protected ILogger Logger;

		public DboController(IDboRepository repository, ILogger<DboController> logger)
		{
			Repository = repository;
			Logger = logger;
		}

		protected override void Dispose(Boolean disposing)
		{
			Repository?.Dispose();
			
			base.Dispose(disposing);
		}

		[HttpGet("MSreplicationOptions")]
		public async Task<IActionResult> GetMSreplicationOptionsAsync(Int32? pageSize = 10, Int32? pageNumber = 1)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetMSreplicationOptionsAsync));
			
			var response = new PagedResponse<MSreplicationOptions>();
			
			try
			{
				// Get query from repository
				var query = Repository.GetMSreplicationOptions();
			
				// Set paging's information
				response.PageSize = (Int32)pageSize;
				response.PageNumber = (Int32)pageNumber;
				response.ItemsCount = await query.CountAsync();
			
				// Retrieve items by page size and page number, set model for response
				response.Model = await query.Paging(response.PageSize, response.PageNumber).ToListAsync();
			
				Logger?.LogInformation("Page {0} of {1}, Total of rows: {2}", response.PageNumber, response.PageCount, response.ItemsCount);
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpPost("MSreplicationOptions")]
		public async Task<IActionResult> PostMSreplicationOptionsAsync([FromBody]MSreplicationOptionsRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PostMSreplicationOptionsAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<MSreplicationOptionsRequestModel>();
			
			try
			{
				var entity = requestModel.ToEntity();
			
				// Add entity to database
				await Repository.AddMSreplicationOptionsAsync(entity);
			
				response.Model = entity.ToRequestModel();
			
				Logger?.LogInformation("The entity was created successfully");
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpGet("SptFallbackDb")]
		public async Task<IActionResult> GetSptFallbackDbsAsync(Int32? pageSize = 10, Int32? pageNumber = 1)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetSptFallbackDbsAsync));
			
			var response = new PagedResponse<SptFallbackDb>();
			
			try
			{
				// Get query from repository
				var query = Repository.GetSptFallbackDbs();
			
				// Set paging's information
				response.PageSize = (Int32)pageSize;
				response.PageNumber = (Int32)pageNumber;
				response.ItemsCount = await query.CountAsync();
			
				// Retrieve items by page size and page number, set model for response
				response.Model = await query.Paging(response.PageSize, response.PageNumber).ToListAsync();
			
				Logger?.LogInformation("Page {0} of {1}, Total of rows: {2}", response.PageNumber, response.PageCount, response.ItemsCount);
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpPost("SptFallbackDb")]
		public async Task<IActionResult> PostSptFallbackDbAsync([FromBody]SptFallbackDbRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PostSptFallbackDbAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<SptFallbackDbRequestModel>();
			
			try
			{
				var entity = requestModel.ToEntity();
			
				// Add entity to database
				await Repository.AddSptFallbackDbAsync(entity);
			
				response.Model = entity.ToRequestModel();
			
				Logger?.LogInformation("The entity was created successfully");
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpGet("SptFallbackDev")]
		public async Task<IActionResult> GetSptFallbackDevsAsync(Int32? pageSize = 10, Int32? pageNumber = 1)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetSptFallbackDevsAsync));
			
			var response = new PagedResponse<SptFallbackDev>();
			
			try
			{
				// Get query from repository
				var query = Repository.GetSptFallbackDevs();
			
				// Set paging's information
				response.PageSize = (Int32)pageSize;
				response.PageNumber = (Int32)pageNumber;
				response.ItemsCount = await query.CountAsync();
			
				// Retrieve items by page size and page number, set model for response
				response.Model = await query.Paging(response.PageSize, response.PageNumber).ToListAsync();
			
				Logger?.LogInformation("Page {0} of {1}, Total of rows: {2}", response.PageNumber, response.PageCount, response.ItemsCount);
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpPost("SptFallbackDev")]
		public async Task<IActionResult> PostSptFallbackDevAsync([FromBody]SptFallbackDevRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PostSptFallbackDevAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<SptFallbackDevRequestModel>();
			
			try
			{
				var entity = requestModel.ToEntity();
			
				// Add entity to database
				await Repository.AddSptFallbackDevAsync(entity);
			
				response.Model = entity.ToRequestModel();
			
				Logger?.LogInformation("The entity was created successfully");
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpGet("SptFallbackUsg")]
		public async Task<IActionResult> GetSptFallbackUsgsAsync(Int32? pageSize = 10, Int32? pageNumber = 1)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetSptFallbackUsgsAsync));
			
			var response = new PagedResponse<SptFallbackUsg>();
			
			try
			{
				// Get query from repository
				var query = Repository.GetSptFallbackUsgs();
			
				// Set paging's information
				response.PageSize = (Int32)pageSize;
				response.PageNumber = (Int32)pageNumber;
				response.ItemsCount = await query.CountAsync();
			
				// Retrieve items by page size and page number, set model for response
				response.Model = await query.Paging(response.PageSize, response.PageNumber).ToListAsync();
			
				Logger?.LogInformation("Page {0} of {1}, Total of rows: {2}", response.PageNumber, response.PageCount, response.ItemsCount);
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpPost("SptFallbackUsg")]
		public async Task<IActionResult> PostSptFallbackUsgAsync([FromBody]SptFallbackUsgRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PostSptFallbackUsgAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<SptFallbackUsgRequestModel>();
			
			try
			{
				var entity = requestModel.ToEntity();
			
				// Add entity to database
				await Repository.AddSptFallbackUsgAsync(entity);
			
				response.Model = entity.ToRequestModel();
			
				Logger?.LogInformation("The entity was created successfully");
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpGet("SptMonitor")]
		public async Task<IActionResult> GetSptMonitorsAsync(Int32? pageSize = 10, Int32? pageNumber = 1)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetSptMonitorsAsync));
			
			var response = new PagedResponse<SptMonitor>();
			
			try
			{
				// Get query from repository
				var query = Repository.GetSptMonitors();
			
				// Set paging's information
				response.PageSize = (Int32)pageSize;
				response.PageNumber = (Int32)pageNumber;
				response.ItemsCount = await query.CountAsync();
			
				// Retrieve items by page size and page number, set model for response
				response.Model = await query.Paging(response.PageSize, response.PageNumber).ToListAsync();
			
				Logger?.LogInformation("Page {0} of {1}, Total of rows: {2}", response.PageNumber, response.PageCount, response.ItemsCount);
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpPost("SptMonitor")]
		public async Task<IActionResult> PostSptMonitorAsync([FromBody]SptMonitorRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PostSptMonitorAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<SptMonitorRequestModel>();
			
			try
			{
				var entity = requestModel.ToEntity();
			
				// Add entity to database
				await Repository.AddSptMonitorAsync(entity);
			
				response.Model = entity.ToRequestModel();
			
				Logger?.LogInformation("The entity was created successfully");
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpGet("WebCategory")]
		public async Task<IActionResult> GetWebCategoriesAsync(Int32? pageSize = 10, Int32? pageNumber = 1)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetWebCategoriesAsync));
			
			var response = new PagedResponse<WebCategory>();
			
			try
			{
				// Get query from repository
				var query = Repository.GetWebCategories();
			
				// Set paging's information
				response.PageSize = (Int32)pageSize;
				response.PageNumber = (Int32)pageNumber;
				response.ItemsCount = await query.CountAsync();
			
				// Retrieve items by page size and page number, set model for response
				response.Model = await query.Paging(response.PageSize, response.PageNumber).ToListAsync();
			
				Logger?.LogInformation("Page {0} of {1}, Total of rows: {2}", response.PageNumber, response.PageCount, response.ItemsCount);
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpGet("WebCategory/{id}")]
		public async Task<IActionResult> GetWebCategoryAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetWebCategoryAsync));
			
			var response = new SingleResponse<WebCategoryRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetWebCategoryAsync(new WebCategory(id));
			
				if (entity != null)
				{
					response.Model = entity.ToRequestModel();
			
					Logger?.LogInformation("The entity was retrieved successfully");
				}
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpPost("WebCategory")]
		public async Task<IActionResult> PostWebCategoryAsync([FromBody]WebCategoryRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PostWebCategoryAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<WebCategoryRequestModel>();
			
			try
			{
				var entity = requestModel.ToEntity();
			
				// Add entity to database
				await Repository.AddWebCategoryAsync(entity);
			
				response.Model = entity.ToRequestModel();
			
				Logger?.LogInformation("The entity was created successfully");
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpPut("WebCategory")]
		public async Task<IActionResult> PutWebCategoryAsync(Int32? id, [FromBody]WebCategoryRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PutWebCategoryAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<WebCategoryRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetWebCategoryAsync(new WebCategory(id));
			
				if (entity != null)
				{
					// todo:  Check properties to update
					// Apply changes on entity
					entity.SiteId = requestModel.SiteId;
					entity.CategoryName = requestModel.CategoryName;
					entity.ParentId = requestModel.ParentId;
					entity.NodeValue = requestModel.NodeValue;
					entity.Controller = requestModel.Controller;
					entity.Action = requestModel.Action;
					entity.Urls = requestModel.Urls;
					entity.DocumentNumber = requestModel.DocumentNumber;
					entity.AccessNumber = requestModel.AccessNumber;
					entity.ClickNumber = requestModel.ClickNumber;
					entity.Title = requestModel.Title;
					entity.Keywords = requestModel.Keywords;
					entity.Description = requestModel.Description;
					entity.Sequence = requestModel.Sequence;
					entity.IsEnable = requestModel.IsEnable;
					entity.RowVers = requestModel.RowVers;
					entity.Remarks = requestModel.Remarks;
					entity.CreateBy = requestModel.CreateBy;
					entity.CreateTime = requestModel.CreateTime;
			
					// Save changes for entity in database
					await Repository.UpdateWebCategoryAsync(entity);
			
					Logger?.LogInformation("The entity was updated successfully");
			
					response.Model = entity.ToRequestModel();
				}
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpDelete("WebCategory")]
		public async Task<IActionResult> DeleteWebCategoryAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(DeleteWebCategoryAsync));
			
			var response = new SingleResponse<WebCategoryRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetWebCategoryAsync(new WebCategory(id));
			
				if (entity != null)
				{
					// Remove entity from database
					await Repository.RemoveWebCategoryAsync(entity);
			
					Logger?.LogInformation("The entity was deleted successfully");
			
					response.Model = entity.ToRequestModel();
				}
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpGet("WebNews")]
		public async Task<IActionResult> GetWebNewsAsync(Int32? pageSize = 10, Int32? pageNumber = 1, Int32? categoryId = null, Int32? sourceId = null)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetWebNewsAsync));
			
			var response = new PagedResponse<WebNews>();
			
			try
			{
				// Get query from repository
				var query = Repository.GetWebNews(categoryId, sourceId);
			
				// Set paging's information
				response.PageSize = (Int32)pageSize;
				response.PageNumber = (Int32)pageNumber;
				response.ItemsCount = await query.CountAsync();
			
				// Retrieve items by page size and page number, set model for response
				response.Model = await query.Paging(response.PageSize, response.PageNumber).ToListAsync();
			
				Logger?.LogInformation("Page {0} of {1}, Total of rows: {2}", response.PageNumber, response.PageCount, response.ItemsCount);
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpGet("WebNews/{id}")]
		public async Task<IActionResult> GetWebNewsAsync(String id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetWebNewsAsync));
			
			var response = new SingleResponse<WebNewsRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetWebNewsAsync(new WebNews(id));
			
				if (entity != null)
				{
					response.Model = entity.ToRequestModel();
			
					Logger?.LogInformation("The entity was retrieved successfully");
				}
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpPost("WebNews")]
		public async Task<IActionResult> PostWebNewsAsync([FromBody]WebNewsRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PostWebNewsAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<WebNewsRequestModel>();
			
			try
			{
				var entity = requestModel.ToEntity();
			
				// Add entity to database
				await Repository.AddWebNewsAsync(entity);
			
				response.Model = entity.ToRequestModel();
			
				Logger?.LogInformation("The entity was created successfully");
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpPut("WebNews")]
		public async Task<IActionResult> PutWebNewsAsync(String id, [FromBody]WebNewsRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PutWebNewsAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<WebNewsRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetWebNewsAsync(new WebNews(id));
			
				if (entity != null)
				{
					// todo:  Check properties to update
					// Apply changes on entity
					entity.SiteId = requestModel.SiteId;
					entity.SpecialCode = requestModel.SpecialCode;
					entity.CategoryId = requestModel.CategoryId;
					entity.CategoryName = requestModel.CategoryName;
					entity.NewsTitle = requestModel.NewsTitle;
					entity.CustomTitle = requestModel.CustomTitle;
					entity.SourceId = requestModel.SourceId;
					entity.Source = requestModel.Source;
					entity.SourceAddress = requestModel.SourceAddress;
					entity.SourceLogo = requestModel.SourceLogo;
					entity.Tags = requestModel.Tags;
					entity.Contents = requestModel.Contents;
					entity.Controller = requestModel.Controller;
					entity.Action = requestModel.Action;
					entity.Urls = requestModel.Urls;
					entity.ImageThums = requestModel.ImageThums;
					entity.ImagePaths = requestModel.ImagePaths;
					entity.DisplayType = requestModel.DisplayType;
					entity.IsHot = requestModel.IsHot;
					entity.Title = requestModel.Title;
					entity.Keywords = requestModel.Keywords;
					entity.Description = requestModel.Description;
					entity.AccessNumber = requestModel.AccessNumber;
					entity.VirtualAccessNumber = requestModel.VirtualAccessNumber;
					entity.ClickNumber = requestModel.ClickNumber;
					entity.Author = requestModel.Author;
					entity.AuditBy = requestModel.AuditBy;
					entity.AuditStatus = requestModel.AuditStatus;
					entity.AuditTime = requestModel.AuditTime;
					entity.PushBy = requestModel.PushBy;
					entity.PushStatus = requestModel.PushStatus;
					entity.PushTime = requestModel.PushTime;
					entity.OperateType = requestModel.OperateType;
					entity.CategorySort = requestModel.CategorySort;
					entity.SingleSort = requestModel.SingleSort;
					entity.Sequence = requestModel.Sequence;
					entity.IsEnable = requestModel.IsEnable;
					entity.RowVers = requestModel.RowVers;
					entity.Remarks = requestModel.Remarks;
					entity.CreateBy = requestModel.CreateBy;
					entity.CreateTime = requestModel.CreateTime;
			
					// Save changes for entity in database
					await Repository.UpdateWebNewsAsync(entity);
			
					Logger?.LogInformation("The entity was updated successfully");
			
					response.Model = entity.ToRequestModel();
				}
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpDelete("WebNews")]
		public async Task<IActionResult> DeleteWebNewsAsync(String id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(DeleteWebNewsAsync));
			
			var response = new SingleResponse<WebNewsRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetWebNewsAsync(new WebNews(id));
			
				if (entity != null)
				{
					// Remove entity from database
					await Repository.RemoveWebNewsAsync(entity);
			
					Logger?.LogInformation("The entity was deleted successfully");
			
					response.Model = entity.ToRequestModel();
				}
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpGet("WebSource")]
		public async Task<IActionResult> GetWebSourcesAsync(Int32? pageSize = 10, Int32? pageNumber = 1, Int32? categoryId = null)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetWebSourcesAsync));
			
			var response = new PagedResponse<WebSource>();
			
			try
			{
				// Get query from repository
				var query = Repository.GetWebSources(categoryId);
			
				// Set paging's information
				response.PageSize = (Int32)pageSize;
				response.PageNumber = (Int32)pageNumber;
				response.ItemsCount = await query.CountAsync();
			
				// Retrieve items by page size and page number, set model for response
				response.Model = await query.Paging(response.PageSize, response.PageNumber).ToListAsync();
			
				Logger?.LogInformation("Page {0} of {1}, Total of rows: {2}", response.PageNumber, response.PageCount, response.ItemsCount);
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpGet("WebSource/{id}")]
		public async Task<IActionResult> GetWebSourceAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetWebSourceAsync));
			
			var response = new SingleResponse<WebSourceRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetWebSourceAsync(new WebSource(id));
			
				if (entity != null)
				{
					response.Model = entity.ToRequestModel();
			
					Logger?.LogInformation("The entity was retrieved successfully");
				}
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpPost("WebSource")]
		public async Task<IActionResult> PostWebSourceAsync([FromBody]WebSourceRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PostWebSourceAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<WebSourceRequestModel>();
			
			try
			{
				var entity = requestModel.ToEntity();
			
				// Add entity to database
				await Repository.AddWebSourceAsync(entity);
			
				response.Model = entity.ToRequestModel();
			
				Logger?.LogInformation("The entity was created successfully");
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpPut("WebSource")]
		public async Task<IActionResult> PutWebSourceAsync(Int32? id, [FromBody]WebSourceRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PutWebSourceAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<WebSourceRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetWebSourceAsync(new WebSource(id));
			
				if (entity != null)
				{
					// todo:  Check properties to update
					// Apply changes on entity
					entity.CategoryId = requestModel.CategoryId;
					entity.SourceName = requestModel.SourceName;
					entity.SourceLogo = requestModel.SourceLogo;
					entity.FollowNumber = requestModel.FollowNumber;
					entity.Sequence = requestModel.Sequence;
					entity.IsEnable = requestModel.IsEnable;
					entity.Remarks = requestModel.Remarks;
			
					// Save changes for entity in database
					await Repository.UpdateWebSourceAsync(entity);
			
					Logger?.LogInformation("The entity was updated successfully");
			
					response.Model = entity.ToRequestModel();
				}
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpDelete("WebSource")]
		public async Task<IActionResult> DeleteWebSourceAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(DeleteWebSourceAsync));
			
			var response = new SingleResponse<WebSourceRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetWebSourceAsync(new WebSource(id));
			
				if (entity != null)
				{
					// Remove entity from database
					await Repository.RemoveWebSourceAsync(entity);
			
					Logger?.LogInformation("The entity was deleted successfully");
			
					response.Model = entity.ToRequestModel();
				}
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}
	}
}
