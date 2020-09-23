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

		[HttpGet("AutoBatchInsertNewsId")]
		public async Task<IActionResult> GetAutoBatchInsertNewsIdsAsync(Int32? pageSize = 10, Int32? pageNumber = 1)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetAutoBatchInsertNewsIdsAsync));
			
			var response = new PagedResponse<AutoBatchInsertNewsId>();
			
			try
			{
				// Get query from repository
				var query = Repository.GetAutoBatchInsertNewsIds();
			
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

		[HttpGet("AutoBatchInsertNewsId/{id}")]
		public async Task<IActionResult> GetAutoBatchInsertNewsIdAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetAutoBatchInsertNewsIdAsync));
			
			var response = new SingleResponse<AutoBatchInsertNewsIdRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetAutoBatchInsertNewsIdAsync(new AutoBatchInsertNewsId(id));
			
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

		[HttpPost("AutoBatchInsertNewsId")]
		public async Task<IActionResult> PostAutoBatchInsertNewsIdAsync([FromBody]AutoBatchInsertNewsIdRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PostAutoBatchInsertNewsIdAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<AutoBatchInsertNewsIdRequestModel>();
			
			try
			{
				var entity = requestModel.ToEntity();
			
				// Add entity to database
				await Repository.AddAutoBatchInsertNewsIdAsync(entity);
			
				response.Model = entity.ToRequestModel();
			
				Logger?.LogInformation("The entity was created successfully");
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpPut("AutoBatchInsertNewsId")]
		public async Task<IActionResult> PutAutoBatchInsertNewsIdAsync(Int32? id, [FromBody]AutoBatchInsertNewsIdRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PutAutoBatchInsertNewsIdAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<AutoBatchInsertNewsIdRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetAutoBatchInsertNewsIdAsync(new AutoBatchInsertNewsId(id));
			
				if (entity != null)
				{
					// todo:  Check properties to update
					// Apply changes on entity
					entity.NewsId = requestModel.NewsId;
					entity.Message = requestModel.Message;
			
					// Save changes for entity in database
					await Repository.UpdateAutoBatchInsertNewsIdAsync(entity);
			
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

		[HttpDelete("AutoBatchInsertNewsId")]
		public async Task<IActionResult> DeleteAutoBatchInsertNewsIdAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(DeleteAutoBatchInsertNewsIdAsync));
			
			var response = new SingleResponse<AutoBatchInsertNewsIdRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetAutoBatchInsertNewsIdAsync(new AutoBatchInsertNewsId(id));
			
				if (entity != null)
				{
					// Remove entity from database
					await Repository.RemoveAutoBatchInsertNewsIdAsync(entity);
			
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

		[HttpGet("ReportCategoryDayAccess")]
		public async Task<IActionResult> GetReportCategoryDayAccessesAsync(Int32? pageSize = 10, Int32? pageNumber = 1)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetReportCategoryDayAccessesAsync));
			
			var response = new PagedResponse<ReportCategoryDayAccess>();
			
			try
			{
				// Get query from repository
				var query = Repository.GetReportCategoryDayAccesses();
			
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

		[HttpGet("ReportCategoryDayAccess/{id}")]
		public async Task<IActionResult> GetReportCategoryDayAccessAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetReportCategoryDayAccessAsync));
			
			var response = new SingleResponse<ReportCategoryDayAccessRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetReportCategoryDayAccessAsync(new ReportCategoryDayAccess(id));
			
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

		[HttpPost("ReportCategoryDayAccess")]
		public async Task<IActionResult> PostReportCategoryDayAccessAsync([FromBody]ReportCategoryDayAccessRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PostReportCategoryDayAccessAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<ReportCategoryDayAccessRequestModel>();
			
			try
			{
				var entity = requestModel.ToEntity();
			
				// Add entity to database
				await Repository.AddReportCategoryDayAccessAsync(entity);
			
				response.Model = entity.ToRequestModel();
			
				Logger?.LogInformation("The entity was created successfully");
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpPut("ReportCategoryDayAccess")]
		public async Task<IActionResult> PutReportCategoryDayAccessAsync(Int32? id, [FromBody]ReportCategoryDayAccessRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PutReportCategoryDayAccessAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<ReportCategoryDayAccessRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetReportCategoryDayAccessAsync(new ReportCategoryDayAccess(id));
			
				if (entity != null)
				{
					// todo:  Check properties to update
					// Apply changes on entity
					entity.CategoryId = requestModel.CategoryId;
					entity.CategoryName = requestModel.CategoryName;
					entity.Count = requestModel.Count;
					entity.Today = requestModel.Today;
					entity.LastUpdateTime = requestModel.LastUpdateTime;
			
					// Save changes for entity in database
					await Repository.UpdateReportCategoryDayAccessAsync(entity);
			
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

		[HttpDelete("ReportCategoryDayAccess")]
		public async Task<IActionResult> DeleteReportCategoryDayAccessAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(DeleteReportCategoryDayAccessAsync));
			
			var response = new SingleResponse<ReportCategoryDayAccessRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetReportCategoryDayAccessAsync(new ReportCategoryDayAccess(id));
			
				if (entity != null)
				{
					// Remove entity from database
					await Repository.RemoveReportCategoryDayAccessAsync(entity);
			
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

		[HttpGet("ReportCategoryDayClick")]
		public async Task<IActionResult> GetReportCategoryDayClicksAsync(Int32? pageSize = 10, Int32? pageNumber = 1)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetReportCategoryDayClicksAsync));
			
			var response = new PagedResponse<ReportCategoryDayClick>();
			
			try
			{
				// Get query from repository
				var query = Repository.GetReportCategoryDayClicks();
			
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

		[HttpGet("ReportCategoryDayClick/{id}")]
		public async Task<IActionResult> GetReportCategoryDayClickAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetReportCategoryDayClickAsync));
			
			var response = new SingleResponse<ReportCategoryDayClickRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetReportCategoryDayClickAsync(new ReportCategoryDayClick(id));
			
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

		[HttpPost("ReportCategoryDayClick")]
		public async Task<IActionResult> PostReportCategoryDayClickAsync([FromBody]ReportCategoryDayClickRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PostReportCategoryDayClickAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<ReportCategoryDayClickRequestModel>();
			
			try
			{
				var entity = requestModel.ToEntity();
			
				// Add entity to database
				await Repository.AddReportCategoryDayClickAsync(entity);
			
				response.Model = entity.ToRequestModel();
			
				Logger?.LogInformation("The entity was created successfully");
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpPut("ReportCategoryDayClick")]
		public async Task<IActionResult> PutReportCategoryDayClickAsync(Int32? id, [FromBody]ReportCategoryDayClickRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PutReportCategoryDayClickAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<ReportCategoryDayClickRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetReportCategoryDayClickAsync(new ReportCategoryDayClick(id));
			
				if (entity != null)
				{
					// todo:  Check properties to update
					// Apply changes on entity
					entity.CategoryId = requestModel.CategoryId;
					entity.CategoryName = requestModel.CategoryName;
					entity.Count = requestModel.Count;
					entity.Today = requestModel.Today;
					entity.LastUpdateTime = requestModel.LastUpdateTime;
			
					// Save changes for entity in database
					await Repository.UpdateReportCategoryDayClickAsync(entity);
			
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

		[HttpDelete("ReportCategoryDayClick")]
		public async Task<IActionResult> DeleteReportCategoryDayClickAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(DeleteReportCategoryDayClickAsync));
			
			var response = new SingleResponse<ReportCategoryDayClickRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetReportCategoryDayClickAsync(new ReportCategoryDayClick(id));
			
				if (entity != null)
				{
					// Remove entity from database
					await Repository.RemoveReportCategoryDayClickAsync(entity);
			
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

		[HttpGet("ReportNewsDayAccess")]
		public async Task<IActionResult> GetReportNewsDayAccessesAsync(Int32? pageSize = 10, Int32? pageNumber = 1)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetReportNewsDayAccessesAsync));
			
			var response = new PagedResponse<ReportNewsDayAccess>();
			
			try
			{
				// Get query from repository
				var query = Repository.GetReportNewsDayAccesses();
			
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

		[HttpGet("ReportNewsDayAccess/{id}")]
		public async Task<IActionResult> GetReportNewsDayAccessAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetReportNewsDayAccessAsync));
			
			var response = new SingleResponse<ReportNewsDayAccessRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetReportNewsDayAccessAsync(new ReportNewsDayAccess(id));
			
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

		[HttpPost("ReportNewsDayAccess")]
		public async Task<IActionResult> PostReportNewsDayAccessAsync([FromBody]ReportNewsDayAccessRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PostReportNewsDayAccessAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<ReportNewsDayAccessRequestModel>();
			
			try
			{
				var entity = requestModel.ToEntity();
			
				// Add entity to database
				await Repository.AddReportNewsDayAccessAsync(entity);
			
				response.Model = entity.ToRequestModel();
			
				Logger?.LogInformation("The entity was created successfully");
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpPut("ReportNewsDayAccess")]
		public async Task<IActionResult> PutReportNewsDayAccessAsync(Int32? id, [FromBody]ReportNewsDayAccessRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PutReportNewsDayAccessAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<ReportNewsDayAccessRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetReportNewsDayAccessAsync(new ReportNewsDayAccess(id));
			
				if (entity != null)
				{
					// todo:  Check properties to update
					// Apply changes on entity
					entity.NewsId = requestModel.NewsId;
					entity.CategoryId = requestModel.CategoryId;
					entity.CategoryName = requestModel.CategoryName;
					entity.SpecialCode = requestModel.SpecialCode;
					entity.SpecialName = requestModel.SpecialName;
					entity.Count = requestModel.Count;
					entity.Today = requestModel.Today;
					entity.LastUpdateTime = requestModel.LastUpdateTime;
			
					// Save changes for entity in database
					await Repository.UpdateReportNewsDayAccessAsync(entity);
			
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

		[HttpDelete("ReportNewsDayAccess")]
		public async Task<IActionResult> DeleteReportNewsDayAccessAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(DeleteReportNewsDayAccessAsync));
			
			var response = new SingleResponse<ReportNewsDayAccessRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetReportNewsDayAccessAsync(new ReportNewsDayAccess(id));
			
				if (entity != null)
				{
					// Remove entity from database
					await Repository.RemoveReportNewsDayAccessAsync(entity);
			
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

		[HttpGet("ReportNewsDayClick")]
		public async Task<IActionResult> GetReportNewsDayClicksAsync(Int32? pageSize = 10, Int32? pageNumber = 1)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetReportNewsDayClicksAsync));
			
			var response = new PagedResponse<ReportNewsDayClick>();
			
			try
			{
				// Get query from repository
				var query = Repository.GetReportNewsDayClicks();
			
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

		[HttpGet("ReportNewsDayClick/{id}")]
		public async Task<IActionResult> GetReportNewsDayClickAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetReportNewsDayClickAsync));
			
			var response = new SingleResponse<ReportNewsDayClickRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetReportNewsDayClickAsync(new ReportNewsDayClick(id));
			
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

		[HttpPost("ReportNewsDayClick")]
		public async Task<IActionResult> PostReportNewsDayClickAsync([FromBody]ReportNewsDayClickRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PostReportNewsDayClickAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<ReportNewsDayClickRequestModel>();
			
			try
			{
				var entity = requestModel.ToEntity();
			
				// Add entity to database
				await Repository.AddReportNewsDayClickAsync(entity);
			
				response.Model = entity.ToRequestModel();
			
				Logger?.LogInformation("The entity was created successfully");
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpPut("ReportNewsDayClick")]
		public async Task<IActionResult> PutReportNewsDayClickAsync(Int32? id, [FromBody]ReportNewsDayClickRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PutReportNewsDayClickAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<ReportNewsDayClickRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetReportNewsDayClickAsync(new ReportNewsDayClick(id));
			
				if (entity != null)
				{
					// todo:  Check properties to update
					// Apply changes on entity
					entity.NewsId = requestModel.NewsId;
					entity.CategoryId = requestModel.CategoryId;
					entity.CategoryName = requestModel.CategoryName;
					entity.SpecialCode = requestModel.SpecialCode;
					entity.SpecialName = requestModel.SpecialName;
					entity.Count = requestModel.Count;
					entity.Today = requestModel.Today;
					entity.LastUpdateTime = requestModel.LastUpdateTime;
			
					// Save changes for entity in database
					await Repository.UpdateReportNewsDayClickAsync(entity);
			
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

		[HttpDelete("ReportNewsDayClick")]
		public async Task<IActionResult> DeleteReportNewsDayClickAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(DeleteReportNewsDayClickAsync));
			
			var response = new SingleResponse<ReportNewsDayClickRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetReportNewsDayClickAsync(new ReportNewsDayClick(id));
			
				if (entity != null)
				{
					// Remove entity from database
					await Repository.RemoveReportNewsDayClickAsync(entity);
			
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

		[HttpGet("ReportSiteDayAccess")]
		public async Task<IActionResult> GetReportSiteDayAccessesAsync(Int32? pageSize = 10, Int32? pageNumber = 1)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetReportSiteDayAccessesAsync));
			
			var response = new PagedResponse<ReportSiteDayAccess>();
			
			try
			{
				// Get query from repository
				var query = Repository.GetReportSiteDayAccesses();
			
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

		[HttpGet("ReportSiteDayAccess/{id}")]
		public async Task<IActionResult> GetReportSiteDayAccessAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetReportSiteDayAccessAsync));
			
			var response = new SingleResponse<ReportSiteDayAccessRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetReportSiteDayAccessAsync(new ReportSiteDayAccess(id));
			
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

		[HttpPost("ReportSiteDayAccess")]
		public async Task<IActionResult> PostReportSiteDayAccessAsync([FromBody]ReportSiteDayAccessRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PostReportSiteDayAccessAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<ReportSiteDayAccessRequestModel>();
			
			try
			{
				var entity = requestModel.ToEntity();
			
				// Add entity to database
				await Repository.AddReportSiteDayAccessAsync(entity);
			
				response.Model = entity.ToRequestModel();
			
				Logger?.LogInformation("The entity was created successfully");
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpPut("ReportSiteDayAccess")]
		public async Task<IActionResult> PutReportSiteDayAccessAsync(Int32? id, [FromBody]ReportSiteDayAccessRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PutReportSiteDayAccessAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<ReportSiteDayAccessRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetReportSiteDayAccessAsync(new ReportSiteDayAccess(id));
			
				if (entity != null)
				{
					// todo:  Check properties to update
					// Apply changes on entity
					entity.SiteNo = requestModel.SiteNo;
					entity.Count = requestModel.Count;
					entity.Today = requestModel.Today;
					entity.LastUpdateTime = requestModel.LastUpdateTime;
			
					// Save changes for entity in database
					await Repository.UpdateReportSiteDayAccessAsync(entity);
			
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

		[HttpDelete("ReportSiteDayAccess")]
		public async Task<IActionResult> DeleteReportSiteDayAccessAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(DeleteReportSiteDayAccessAsync));
			
			var response = new SingleResponse<ReportSiteDayAccessRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetReportSiteDayAccessAsync(new ReportSiteDayAccess(id));
			
				if (entity != null)
				{
					// Remove entity from database
					await Repository.RemoveReportSiteDayAccessAsync(entity);
			
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

		[HttpGet("SystemDictionary")]
		public async Task<IActionResult> GetSystemDictionariesAsync(Int32? pageSize = 10, Int32? pageNumber = 1)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetSystemDictionariesAsync));
			
			var response = new PagedResponse<SystemDictionary>();
			
			try
			{
				// Get query from repository
				var query = Repository.GetSystemDictionaries();
			
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

		[HttpGet("SystemDictionary/{id}")]
		public async Task<IActionResult> GetSystemDictionaryAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetSystemDictionaryAsync));
			
			var response = new SingleResponse<SystemDictionaryRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetSystemDictionaryAsync(new SystemDictionary(id));
			
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

		[HttpPost("SystemDictionary")]
		public async Task<IActionResult> PostSystemDictionaryAsync([FromBody]SystemDictionaryRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PostSystemDictionaryAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<SystemDictionaryRequestModel>();
			
			try
			{
				var entity = requestModel.ToEntity();
			
				// Add entity to database
				await Repository.AddSystemDictionaryAsync(entity);
			
				response.Model = entity.ToRequestModel();
			
				Logger?.LogInformation("The entity was created successfully");
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpPut("SystemDictionary")]
		public async Task<IActionResult> PutSystemDictionaryAsync(Int32? id, [FromBody]SystemDictionaryRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PutSystemDictionaryAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<SystemDictionaryRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetSystemDictionaryAsync(new SystemDictionary(id));
			
				if (entity != null)
				{
					// todo:  Check properties to update
					// Apply changes on entity
					entity.Keys = requestModel.Keys;
					entity.Name = requestModel.Name;
					entity.Value = requestModel.Value;
					entity.Remarks = requestModel.Remarks;
			
					// Save changes for entity in database
					await Repository.UpdateSystemDictionaryAsync(entity);
			
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

		[HttpDelete("SystemDictionary")]
		public async Task<IActionResult> DeleteSystemDictionaryAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(DeleteSystemDictionaryAsync));
			
			var response = new SingleResponse<SystemDictionaryRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetSystemDictionaryAsync(new SystemDictionary(id));
			
				if (entity != null)
				{
					// Remove entity from database
					await Repository.RemoveSystemDictionaryAsync(entity);
			
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

		[HttpGet("SystemLogs")]
		public async Task<IActionResult> GetSystemLogsAsync(Int32? pageSize = 10, Int32? pageNumber = 1)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetSystemLogsAsync));
			
			var response = new PagedResponse<SystemLogs>();
			
			try
			{
				// Get query from repository
				var query = Repository.GetSystemLogs();
			
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

		[HttpGet("SystemLogs/{id}")]
		public async Task<IActionResult> GetSystemLogsAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetSystemLogsAsync));
			
			var response = new SingleResponse<SystemLogsRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetSystemLogsAsync(new SystemLogs(id));
			
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

		[HttpPost("SystemLogs")]
		public async Task<IActionResult> PostSystemLogsAsync([FromBody]SystemLogsRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PostSystemLogsAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<SystemLogsRequestModel>();
			
			try
			{
				var entity = requestModel.ToEntity();
			
				// Add entity to database
				await Repository.AddSystemLogsAsync(entity);
			
				response.Model = entity.ToRequestModel();
			
				Logger?.LogInformation("The entity was created successfully");
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpPut("SystemLogs")]
		public async Task<IActionResult> PutSystemLogsAsync(Int32? id, [FromBody]SystemLogsRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PutSystemLogsAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<SystemLogsRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetSystemLogsAsync(new SystemLogs(id));
			
				if (entity != null)
				{
					// todo:  Check properties to update
					// Apply changes on entity
					entity.Methods = requestModel.Methods;
					entity.Grade = requestModel.Grade;
					entity.Source = requestModel.Source;
					entity.Args = requestModel.Args;
					entity.Errors = requestModel.Errors;
					entity.CreateBy = requestModel.CreateBy;
					entity.CreateTime = requestModel.CreateTime;
			
					// Save changes for entity in database
					await Repository.UpdateSystemLogsAsync(entity);
			
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

		[HttpDelete("SystemLogs")]
		public async Task<IActionResult> DeleteSystemLogsAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(DeleteSystemLogsAsync));
			
			var response = new SingleResponse<SystemLogsRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetSystemLogsAsync(new SystemLogs(id));
			
				if (entity != null)
				{
					// Remove entity from database
					await Repository.RemoveSystemLogsAsync(entity);
			
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

		[HttpGet("SystemMenu")]
		public async Task<IActionResult> GetSystemMenusAsync(Int32? pageSize = 10, Int32? pageNumber = 1)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetSystemMenusAsync));
			
			var response = new PagedResponse<SystemMenu>();
			
			try
			{
				// Get query from repository
				var query = Repository.GetSystemMenus();
			
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

		[HttpGet("SystemMenu/{id}")]
		public async Task<IActionResult> GetSystemMenuAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetSystemMenuAsync));
			
			var response = new SingleResponse<SystemMenuRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetSystemMenuAsync(new SystemMenu(id));
			
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

		[HttpPost("SystemMenu")]
		public async Task<IActionResult> PostSystemMenuAsync([FromBody]SystemMenuRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PostSystemMenuAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<SystemMenuRequestModel>();
			
			try
			{
				var entity = requestModel.ToEntity();
			
				// Add entity to database
				await Repository.AddSystemMenuAsync(entity);
			
				response.Model = entity.ToRequestModel();
			
				Logger?.LogInformation("The entity was created successfully");
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpPut("SystemMenu")]
		public async Task<IActionResult> PutSystemMenuAsync(Int32? id, [FromBody]SystemMenuRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PutSystemMenuAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<SystemMenuRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetSystemMenuAsync(new SystemMenu(id));
			
				if (entity != null)
				{
					// todo:  Check properties to update
					// Apply changes on entity
					entity.SiteNo = requestModel.SiteNo;
					entity.MenuIcon = requestModel.MenuIcon;
					entity.MenuName = requestModel.MenuName;
					entity.ParentId = requestModel.ParentId;
					entity.NodeValue = requestModel.NodeValue;
					entity.Areas = requestModel.Areas;
					entity.Controller = requestModel.Controller;
					entity.Action = requestModel.Action;
					entity.Urls = requestModel.Urls;
					entity.RouterName = requestModel.RouterName;
					entity.RouterPath = requestModel.RouterPath;
					entity.Component = requestModel.Component;
					entity.ShowAlways = requestModel.ShowAlways;
					entity.ShowHeader = requestModel.ShowHeader;
					entity.HideInBread = requestModel.HideInBread;
					entity.HideInMenu = requestModel.HideInMenu;
					entity.NotCache = requestModel.NotCache;
					entity.BeforeCloseName = requestModel.BeforeCloseName;
					entity.Sequence = requestModel.Sequence;
					entity.IsEnable = requestModel.IsEnable;
					entity.RowVers = requestModel.RowVers;
					entity.Remarks = requestModel.Remarks;
					entity.CreateBy = requestModel.CreateBy;
					entity.CreateTime = requestModel.CreateTime;
			
					// Save changes for entity in database
					await Repository.UpdateSystemMenuAsync(entity);
			
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

		[HttpDelete("SystemMenu")]
		public async Task<IActionResult> DeleteSystemMenuAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(DeleteSystemMenuAsync));
			
			var response = new SingleResponse<SystemMenuRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetSystemMenuAsync(new SystemMenu(id));
			
				if (entity != null)
				{
					// Remove entity from database
					await Repository.RemoveSystemMenuAsync(entity);
			
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

		[HttpGet("SystemRole")]
		public async Task<IActionResult> GetSystemRolesAsync(Int32? pageSize = 10, Int32? pageNumber = 1)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetSystemRolesAsync));
			
			var response = new PagedResponse<SystemRole>();
			
			try
			{
				// Get query from repository
				var query = Repository.GetSystemRoles();
			
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

		[HttpGet("SystemRole/{id}")]
		public async Task<IActionResult> GetSystemRoleAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetSystemRoleAsync));
			
			var response = new SingleResponse<SystemRoleRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetSystemRoleAsync(new SystemRole(id));
			
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

		[HttpPost("SystemRole")]
		public async Task<IActionResult> PostSystemRoleAsync([FromBody]SystemRoleRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PostSystemRoleAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<SystemRoleRequestModel>();
			
			try
			{
				var entity = requestModel.ToEntity();
			
				// Add entity to database
				await Repository.AddSystemRoleAsync(entity);
			
				response.Model = entity.ToRequestModel();
			
				Logger?.LogInformation("The entity was created successfully");
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpPut("SystemRole")]
		public async Task<IActionResult> PutSystemRoleAsync(Int32? id, [FromBody]SystemRoleRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PutSystemRoleAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<SystemRoleRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetSystemRoleAsync(new SystemRole(id));
			
				if (entity != null)
				{
					// todo:  Check properties to update
					// Apply changes on entity
					entity.RoleName = requestModel.RoleName;
					entity.IsEnable = requestModel.IsEnable;
					entity.Remarks = requestModel.Remarks;
					entity.CreateBy = requestModel.CreateBy;
					entity.CreateDate = requestModel.CreateDate;
			
					// Save changes for entity in database
					await Repository.UpdateSystemRoleAsync(entity);
			
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

		[HttpDelete("SystemRole")]
		public async Task<IActionResult> DeleteSystemRoleAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(DeleteSystemRoleAsync));
			
			var response = new SingleResponse<SystemRoleRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetSystemRoleAsync(new SystemRole(id));
			
				if (entity != null)
				{
					// Remove entity from database
					await Repository.RemoveSystemRoleAsync(entity);
			
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

		[HttpGet("SystemRoleDictionary")]
		public async Task<IActionResult> GetSystemRoleDictionariesAsync(Int32? pageSize = 10, Int32? pageNumber = 1, Int32? roleId = null)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetSystemRoleDictionariesAsync));
			
			var response = new PagedResponse<SystemRoleDictionary>();
			
			try
			{
				// Get query from repository
				var query = Repository.GetSystemRoleDictionaries(roleId);
			
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

		[HttpGet("SystemRoleDictionary/{id}")]
		public async Task<IActionResult> GetSystemRoleDictionaryAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetSystemRoleDictionaryAsync));
			
			var response = new SingleResponse<SystemRoleDictionaryRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetSystemRoleDictionaryAsync(new SystemRoleDictionary(id));
			
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

		[HttpPost("SystemRoleDictionary")]
		public async Task<IActionResult> PostSystemRoleDictionaryAsync([FromBody]SystemRoleDictionaryRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PostSystemRoleDictionaryAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<SystemRoleDictionaryRequestModel>();
			
			try
			{
				var entity = requestModel.ToEntity();
			
				// Add entity to database
				await Repository.AddSystemRoleDictionaryAsync(entity);
			
				response.Model = entity.ToRequestModel();
			
				Logger?.LogInformation("The entity was created successfully");
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpPut("SystemRoleDictionary")]
		public async Task<IActionResult> PutSystemRoleDictionaryAsync(Int32? id, [FromBody]SystemRoleDictionaryRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PutSystemRoleDictionaryAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<SystemRoleDictionaryRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetSystemRoleDictionaryAsync(new SystemRoleDictionary(id));
			
				if (entity != null)
				{
					// todo:  Check properties to update
					// Apply changes on entity
					entity.RoleId = requestModel.RoleId;
					entity.DictionaryKey = requestModel.DictionaryKey;
					entity.DictionaryValue = requestModel.DictionaryValue;
			
					// Save changes for entity in database
					await Repository.UpdateSystemRoleDictionaryAsync(entity);
			
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

		[HttpDelete("SystemRoleDictionary")]
		public async Task<IActionResult> DeleteSystemRoleDictionaryAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(DeleteSystemRoleDictionaryAsync));
			
			var response = new SingleResponse<SystemRoleDictionaryRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetSystemRoleDictionaryAsync(new SystemRoleDictionary(id));
			
				if (entity != null)
				{
					// Remove entity from database
					await Repository.RemoveSystemRoleDictionaryAsync(entity);
			
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

		[HttpGet("SystemRoleInMenu")]
		public async Task<IActionResult> GetSystemRoleInMenusAsync(Int32? pageSize = 10, Int32? pageNumber = 1)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetSystemRoleInMenusAsync));
			
			var response = new PagedResponse<SystemRoleInMenu>();
			
			try
			{
				// Get query from repository
				var query = Repository.GetSystemRoleInMenus();
			
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

		[HttpPost("SystemRoleInMenu")]
		public async Task<IActionResult> PostSystemRoleInMenuAsync([FromBody]SystemRoleInMenuRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PostSystemRoleInMenuAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<SystemRoleInMenuRequestModel>();
			
			try
			{
				var entity = requestModel.ToEntity();
			
				// Add entity to database
				await Repository.AddSystemRoleInMenuAsync(entity);
			
				response.Model = entity.ToRequestModel();
			
				Logger?.LogInformation("The entity was created successfully");
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpGet("SystemUsers")]
		public async Task<IActionResult> GetSystemUsersAsync(Int32? pageSize = 10, Int32? pageNumber = 1)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetSystemUsersAsync));
			
			var response = new PagedResponse<SystemUsers>();
			
			try
			{
				// Get query from repository
				var query = Repository.GetSystemUsers();
			
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

		[HttpGet("SystemUsers/{id}")]
		public async Task<IActionResult> GetSystemUsersAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetSystemUsersAsync));
			
			var response = new SingleResponse<SystemUsersRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetSystemUsersAsync(new SystemUsers(id));
			
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

		[HttpPost("SystemUsers")]
		public async Task<IActionResult> PostSystemUsersAsync([FromBody]SystemUsersRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PostSystemUsersAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<SystemUsersRequestModel>();
			
			try
			{
				var entity = requestModel.ToEntity();
			
				// Add entity to database
				await Repository.AddSystemUsersAsync(entity);
			
				response.Model = entity.ToRequestModel();
			
				Logger?.LogInformation("The entity was created successfully");
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpPut("SystemUsers")]
		public async Task<IActionResult> PutSystemUsersAsync(Int32? id, [FromBody]SystemUsersRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PutSystemUsersAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<SystemUsersRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetSystemUsersAsync(new SystemUsers(id));
			
				if (entity != null)
				{
					// todo:  Check properties to update
					// Apply changes on entity
					entity.UsersName = requestModel.UsersName;
					entity.LoginName = requestModel.LoginName;
					entity.Password = requestModel.Password;
					entity.MobilePhone = requestModel.MobilePhone;
					entity.Email = requestModel.Email;
					entity.LoginIp = requestModel.LoginIp;
					entity.LoginTime = requestModel.LoginTime;
					entity.IsEnable = requestModel.IsEnable;
					entity.Remarks = requestModel.Remarks;
					entity.CreateBy = requestModel.CreateBy;
					entity.CreateTime = requestModel.CreateTime;
			
					// Save changes for entity in database
					await Repository.UpdateSystemUsersAsync(entity);
			
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

		[HttpDelete("SystemUsers")]
		public async Task<IActionResult> DeleteSystemUsersAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(DeleteSystemUsersAsync));
			
			var response = new SingleResponse<SystemUsersRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetSystemUsersAsync(new SystemUsers(id));
			
				if (entity != null)
				{
					// Remove entity from database
					await Repository.RemoveSystemUsersAsync(entity);
			
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

		[HttpGet("SystemUsersDictionary")]
		public async Task<IActionResult> GetSystemUsersDictionariesAsync(Int32? pageSize = 10, Int32? pageNumber = 1, Int32? usersId = null)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetSystemUsersDictionariesAsync));
			
			var response = new PagedResponse<SystemUsersDictionary>();
			
			try
			{
				// Get query from repository
				var query = Repository.GetSystemUsersDictionaries(usersId);
			
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

		[HttpGet("SystemUsersDictionary/{id}")]
		public async Task<IActionResult> GetSystemUsersDictionaryAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetSystemUsersDictionaryAsync));
			
			var response = new SingleResponse<SystemUsersDictionaryRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetSystemUsersDictionaryAsync(new SystemUsersDictionary(id));
			
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

		[HttpPost("SystemUsersDictionary")]
		public async Task<IActionResult> PostSystemUsersDictionaryAsync([FromBody]SystemUsersDictionaryRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PostSystemUsersDictionaryAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<SystemUsersDictionaryRequestModel>();
			
			try
			{
				var entity = requestModel.ToEntity();
			
				// Add entity to database
				await Repository.AddSystemUsersDictionaryAsync(entity);
			
				response.Model = entity.ToRequestModel();
			
				Logger?.LogInformation("The entity was created successfully");
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpPut("SystemUsersDictionary")]
		public async Task<IActionResult> PutSystemUsersDictionaryAsync(Int32? id, [FromBody]SystemUsersDictionaryRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PutSystemUsersDictionaryAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<SystemUsersDictionaryRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetSystemUsersDictionaryAsync(new SystemUsersDictionary(id));
			
				if (entity != null)
				{
					// todo:  Check properties to update
					// Apply changes on entity
					entity.UserId = requestModel.UserId;
					entity.DictionaryKey = requestModel.DictionaryKey;
					entity.DictionaryValue = requestModel.DictionaryValue;
			
					// Save changes for entity in database
					await Repository.UpdateSystemUsersDictionaryAsync(entity);
			
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

		[HttpDelete("SystemUsersDictionary")]
		public async Task<IActionResult> DeleteSystemUsersDictionaryAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(DeleteSystemUsersDictionaryAsync));
			
			var response = new SingleResponse<SystemUsersDictionaryRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetSystemUsersDictionaryAsync(new SystemUsersDictionary(id));
			
				if (entity != null)
				{
					// Remove entity from database
					await Repository.RemoveSystemUsersDictionaryAsync(entity);
			
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

		[HttpGet("SystemUsersInMenu")]
		public async Task<IActionResult> GetSystemUsersInMenusAsync(Int32? pageSize = 10, Int32? pageNumber = 1)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetSystemUsersInMenusAsync));
			
			var response = new PagedResponse<SystemUsersInMenu>();
			
			try
			{
				// Get query from repository
				var query = Repository.GetSystemUsersInMenus();
			
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

		[HttpPost("SystemUsersInMenu")]
		public async Task<IActionResult> PostSystemUsersInMenuAsync([FromBody]SystemUsersInMenuRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PostSystemUsersInMenuAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<SystemUsersInMenuRequestModel>();
			
			try
			{
				var entity = requestModel.ToEntity();
			
				// Add entity to database
				await Repository.AddSystemUsersInMenuAsync(entity);
			
				response.Model = entity.ToRequestModel();
			
				Logger?.LogInformation("The entity was created successfully");
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpGet("SystemUsersInRole")]
		public async Task<IActionResult> GetSystemUsersInRolesAsync(Int32? pageSize = 10, Int32? pageNumber = 1)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetSystemUsersInRolesAsync));
			
			var response = new PagedResponse<SystemUsersInRole>();
			
			try
			{
				// Get query from repository
				var query = Repository.GetSystemUsersInRoles();
			
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

		[HttpPost("SystemUsersInRole")]
		public async Task<IActionResult> PostSystemUsersInRoleAsync([FromBody]SystemUsersInRoleRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PostSystemUsersInRoleAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<SystemUsersInRoleRequestModel>();
			
			try
			{
				var entity = requestModel.ToEntity();
			
				// Add entity to database
				await Repository.AddSystemUsersInRoleAsync(entity);
			
				response.Model = entity.ToRequestModel();
			
				Logger?.LogInformation("The entity was created successfully");
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpGet("SystemUsersRefreshToken")]
		public async Task<IActionResult> GetSystemUsersRefreshTokensAsync(Int32? pageSize = 10, Int32? pageNumber = 1)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetSystemUsersRefreshTokensAsync));
			
			var response = new PagedResponse<SystemUsersRefreshToken>();
			
			try
			{
				// Get query from repository
				var query = Repository.GetSystemUsersRefreshTokens();
			
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

		[HttpGet("SystemUsersRefreshToken/{id}")]
		public async Task<IActionResult> GetSystemUsersRefreshTokenAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetSystemUsersRefreshTokenAsync));
			
			var response = new SingleResponse<SystemUsersRefreshTokenRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetSystemUsersRefreshTokenAsync(new SystemUsersRefreshToken(id));
			
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

		[HttpPost("SystemUsersRefreshToken")]
		public async Task<IActionResult> PostSystemUsersRefreshTokenAsync([FromBody]SystemUsersRefreshTokenRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PostSystemUsersRefreshTokenAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<SystemUsersRefreshTokenRequestModel>();
			
			try
			{
				var entity = requestModel.ToEntity();
			
				// Add entity to database
				await Repository.AddSystemUsersRefreshTokenAsync(entity);
			
				response.Model = entity.ToRequestModel();
			
				Logger?.LogInformation("The entity was created successfully");
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpPut("SystemUsersRefreshToken")]
		public async Task<IActionResult> PutSystemUsersRefreshTokenAsync(Int32? id, [FromBody]SystemUsersRefreshTokenRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PutSystemUsersRefreshTokenAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<SystemUsersRefreshTokenRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetSystemUsersRefreshTokenAsync(new SystemUsersRefreshToken(id));
			
				if (entity != null)
				{
					// todo:  Check properties to update
					// Apply changes on entity
					entity.UsersId = requestModel.UsersId;
					entity.AccessToken = requestModel.AccessToken;
					entity.Expires = requestModel.Expires;
					entity.Active = requestModel.Active;
			
					// Save changes for entity in database
					await Repository.UpdateSystemUsersRefreshTokenAsync(entity);
			
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

		[HttpDelete("SystemUsersRefreshToken")]
		public async Task<IActionResult> DeleteSystemUsersRefreshTokenAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(DeleteSystemUsersRefreshTokenAsync));
			
			var response = new SingleResponse<SystemUsersRefreshTokenRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetSystemUsersRefreshTokenAsync(new SystemUsersRefreshToken(id));
			
				if (entity != null)
				{
					// Remove entity from database
					await Repository.RemoveSystemUsersRefreshTokenAsync(entity);
			
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
					entity.SiteNo = requestModel.SiteNo;
					entity.CategoryName = requestModel.CategoryName;
					entity.ParentId = requestModel.ParentId;
					entity.NodeValue = requestModel.NodeValue;
					entity.Controller = requestModel.Controller;
					entity.Action = requestModel.Action;
					entity.Urls = requestModel.Urls;
					entity.DocumentNumber = requestModel.DocumentNumber;
					entity.VirtualAccessNumber = requestModel.VirtualAccessNumber;
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

		[HttpGet("WebChannel")]
		public async Task<IActionResult> GetWebChannelsAsync(Int32? pageSize = 10, Int32? pageNumber = 1)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetWebChannelsAsync));
			
			var response = new PagedResponse<WebChannel>();
			
			try
			{
				// Get query from repository
				var query = Repository.GetWebChannels();
			
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

		[HttpGet("WebChannel/{id}")]
		public async Task<IActionResult> GetWebChannelAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetWebChannelAsync));
			
			var response = new SingleResponse<WebChannelRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetWebChannelAsync(new WebChannel(id));
			
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

		[HttpPost("WebChannel")]
		public async Task<IActionResult> PostWebChannelAsync([FromBody]WebChannelRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PostWebChannelAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<WebChannelRequestModel>();
			
			try
			{
				var entity = requestModel.ToEntity();
			
				// Add entity to database
				await Repository.AddWebChannelAsync(entity);
			
				response.Model = entity.ToRequestModel();
			
				Logger?.LogInformation("The entity was created successfully");
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpPut("WebChannel")]
		public async Task<IActionResult> PutWebChannelAsync(Int32? id, [FromBody]WebChannelRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PutWebChannelAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<WebChannelRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetWebChannelAsync(new WebChannel(id));
			
				if (entity != null)
				{
					// todo:  Check properties to update
					// Apply changes on entity
					entity.SiteNo = requestModel.SiteNo;
					entity.ChannelName = requestModel.ChannelName;
					entity.ChannelAddress = requestModel.ChannelAddress;
					entity.ChannelJs = requestModel.ChannelJs;
					entity.IsEnable = requestModel.IsEnable;
					entity.RowVers = requestModel.RowVers;
					entity.Remarks = requestModel.Remarks;
					entity.CreateBy = requestModel.CreateBy;
					entity.CreateTime = requestModel.CreateTime;
			
					// Save changes for entity in database
					await Repository.UpdateWebChannelAsync(entity);
			
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

		[HttpDelete("WebChannel")]
		public async Task<IActionResult> DeleteWebChannelAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(DeleteWebChannelAsync));
			
			var response = new SingleResponse<WebChannelRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetWebChannelAsync(new WebChannel(id));
			
				if (entity != null)
				{
					// Remove entity from database
					await Repository.RemoveWebChannelAsync(entity);
			
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
		public async Task<IActionResult> GetWebNewsAsync(Int32? pageSize = 10, Int32? pageNumber = 1, Int32? categoryId = null)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetWebNewsAsync));
			
			var response = new PagedResponse<WebNews>();
			
			try
			{
				// Get query from repository
				var query = Repository.GetWebNews(categoryId);
			
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
		public async Task<IActionResult> GetWebNewsAsync(Int32? id)
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
		public async Task<IActionResult> PutWebNewsAsync(Int32? id, [FromBody]WebNewsRequestModel requestModel)
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
					entity.SiteNo = requestModel.SiteNo;
					entity.SpecialCode = requestModel.SpecialCode;
					entity.CategoryId = requestModel.CategoryId;
					entity.CategoryName = requestModel.CategoryName;
					entity.NewsTitle = requestModel.NewsTitle;
					entity.CustomTitle = requestModel.CustomTitle;
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
					entity.ClickNumber = requestModel.ClickNumber;
					entity.AuditName = requestModel.AuditName;
					entity.AuditStatus = requestModel.AuditStatus;
					entity.AuditTime = requestModel.AuditTime;
					entity.PushStatus = requestModel.PushStatus;
					entity.PushName = requestModel.PushName;
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
		public async Task<IActionResult> DeleteWebNewsAsync(Int32? id)
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

		[HttpGet("WebNewsOperateLogs")]
		public async Task<IActionResult> GetWebNewsOperateLogsAsync(Int32? pageSize = 10, Int32? pageNumber = 1, Int32? newsId = null)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetWebNewsOperateLogsAsync));
			
			var response = new PagedResponse<WebNewsOperateLogs>();
			
			try
			{
				// Get query from repository
				var query = Repository.GetWebNewsOperateLogs(newsId);
			
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

		[HttpGet("WebNewsOperateLogs/{id}")]
		public async Task<IActionResult> GetWebNewsOperateLogsAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetWebNewsOperateLogsAsync));
			
			var response = new SingleResponse<WebNewsOperateLogsRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetWebNewsOperateLogsAsync(new WebNewsOperateLogs(id));
			
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

		[HttpPost("WebNewsOperateLogs")]
		public async Task<IActionResult> PostWebNewsOperateLogsAsync([FromBody]WebNewsOperateLogsRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PostWebNewsOperateLogsAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<WebNewsOperateLogsRequestModel>();
			
			try
			{
				var entity = requestModel.ToEntity();
			
				// Add entity to database
				await Repository.AddWebNewsOperateLogsAsync(entity);
			
				response.Model = entity.ToRequestModel();
			
				Logger?.LogInformation("The entity was created successfully");
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpPut("WebNewsOperateLogs")]
		public async Task<IActionResult> PutWebNewsOperateLogsAsync(Int32? id, [FromBody]WebNewsOperateLogsRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PutWebNewsOperateLogsAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<WebNewsOperateLogsRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetWebNewsOperateLogsAsync(new WebNewsOperateLogs(id));
			
				if (entity != null)
				{
					// todo:  Check properties to update
					// Apply changes on entity
					entity.NewsId = requestModel.NewsId;
					entity.OperateType = requestModel.OperateType;
					entity.OperateStatus = requestModel.OperateStatus;
					entity.Remarks = requestModel.Remarks;
					entity.CreateBy = requestModel.CreateBy;
					entity.CreateName = requestModel.CreateName;
					entity.CreateTime = requestModel.CreateTime;
			
					// Save changes for entity in database
					await Repository.UpdateWebNewsOperateLogsAsync(entity);
			
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

		[HttpDelete("WebNewsOperateLogs")]
		public async Task<IActionResult> DeleteWebNewsOperateLogsAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(DeleteWebNewsOperateLogsAsync));
			
			var response = new SingleResponse<WebNewsOperateLogsRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetWebNewsOperateLogsAsync(new WebNewsOperateLogs(id));
			
				if (entity != null)
				{
					// Remove entity from database
					await Repository.RemoveWebNewsOperateLogsAsync(entity);
			
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

		[HttpGet("WebNewsSensitive")]
		public async Task<IActionResult> GetWebNewsSensitivesAsync(Int32? pageSize = 10, Int32? pageNumber = 1)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetWebNewsSensitivesAsync));
			
			var response = new PagedResponse<WebNewsSensitive>();
			
			try
			{
				// Get query from repository
				var query = Repository.GetWebNewsSensitives();
			
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

		[HttpGet("WebNewsSensitive/{id}")]
		public async Task<IActionResult> GetWebNewsSensitiveAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetWebNewsSensitiveAsync));
			
			var response = new SingleResponse<WebNewsSensitiveRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetWebNewsSensitiveAsync(new WebNewsSensitive(id));
			
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

		[HttpPost("WebNewsSensitive")]
		public async Task<IActionResult> PostWebNewsSensitiveAsync([FromBody]WebNewsSensitiveRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PostWebNewsSensitiveAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<WebNewsSensitiveRequestModel>();
			
			try
			{
				var entity = requestModel.ToEntity();
			
				// Add entity to database
				await Repository.AddWebNewsSensitiveAsync(entity);
			
				response.Model = entity.ToRequestModel();
			
				Logger?.LogInformation("The entity was created successfully");
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpPut("WebNewsSensitive")]
		public async Task<IActionResult> PutWebNewsSensitiveAsync(Int32? id, [FromBody]WebNewsSensitiveRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PutWebNewsSensitiveAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<WebNewsSensitiveRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetWebNewsSensitiveAsync(new WebNewsSensitive(id));
			
				if (entity != null)
				{
					// todo:  Check properties to update
					// Apply changes on entity
					entity.SiteMark = requestModel.SiteMark;
					entity.NewId = requestModel.NewId;
					entity.NewTitleRecords = requestModel.NewTitleRecords;
					entity.CustomTitleRecords = requestModel.CustomTitleRecords;
					entity.ContentsRecords = requestModel.ContentsRecords;
					entity.IsEnable = requestModel.IsEnable;
					entity.Remarks = requestModel.Remarks;
					entity.CreateBy = requestModel.CreateBy;
					entity.CreateTime = requestModel.CreateTime;
			
					// Save changes for entity in database
					await Repository.UpdateWebNewsSensitiveAsync(entity);
			
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

		[HttpDelete("WebNewsSensitive")]
		public async Task<IActionResult> DeleteWebNewsSensitiveAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(DeleteWebNewsSensitiveAsync));
			
			var response = new SingleResponse<WebNewsSensitiveRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetWebNewsSensitiveAsync(new WebNewsSensitive(id));
			
				if (entity != null)
				{
					// Remove entity from database
					await Repository.RemoveWebNewsSensitiveAsync(entity);
			
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

		[HttpGet("WebSensitive")]
		public async Task<IActionResult> GetWebSensitivesAsync(Int32? pageSize = 10, Int32? pageNumber = 1)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetWebSensitivesAsync));
			
			var response = new PagedResponse<WebSensitive>();
			
			try
			{
				// Get query from repository
				var query = Repository.GetWebSensitives();
			
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

		[HttpGet("WebSensitive/{id}")]
		public async Task<IActionResult> GetWebSensitiveAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetWebSensitiveAsync));
			
			var response = new SingleResponse<WebSensitiveRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetWebSensitiveAsync(new WebSensitive(id));
			
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

		[HttpPost("WebSensitive")]
		public async Task<IActionResult> PostWebSensitiveAsync([FromBody]WebSensitiveRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PostWebSensitiveAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<WebSensitiveRequestModel>();
			
			try
			{
				var entity = requestModel.ToEntity();
			
				// Add entity to database
				await Repository.AddWebSensitiveAsync(entity);
			
				response.Model = entity.ToRequestModel();
			
				Logger?.LogInformation("The entity was created successfully");
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpPut("WebSensitive")]
		public async Task<IActionResult> PutWebSensitiveAsync(Int32? id, [FromBody]WebSensitiveRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PutWebSensitiveAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<WebSensitiveRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetWebSensitiveAsync(new WebSensitive(id));
			
				if (entity != null)
				{
					// todo:  Check properties to update
					// Apply changes on entity
					entity.SiteNo = requestModel.SiteNo;
					entity.Type = requestModel.Type;
					entity.TypeText = requestModel.TypeText;
					entity.SensitiveWords = requestModel.SensitiveWords;
					entity.Author = requestModel.Author;
					entity.Urls = requestModel.Urls;
					entity.RowVers = requestModel.RowVers;
					entity.IsEnable = requestModel.IsEnable;
					entity.Remarks = requestModel.Remarks;
					entity.CreateBy = requestModel.CreateBy;
					entity.CreateTime = requestModel.CreateTime;
			
					// Save changes for entity in database
					await Repository.UpdateWebSensitiveAsync(entity);
			
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

		[HttpDelete("WebSensitive")]
		public async Task<IActionResult> DeleteWebSensitiveAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(DeleteWebSensitiveAsync));
			
			var response = new SingleResponse<WebSensitiveRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetWebSensitiveAsync(new WebSensitive(id));
			
				if (entity != null)
				{
					// Remove entity from database
					await Repository.RemoveWebSensitiveAsync(entity);
			
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

		[HttpGet("WebSite")]
		public async Task<IActionResult> GetWebSitesAsync(Int32? pageSize = 10, Int32? pageNumber = 1)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetWebSitesAsync));
			
			var response = new PagedResponse<WebSite>();
			
			try
			{
				// Get query from repository
				var query = Repository.GetWebSites();
			
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

		[HttpGet("WebSite/{id}")]
		public async Task<IActionResult> GetWebSiteAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetWebSiteAsync));
			
			var response = new SingleResponse<WebSiteRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetWebSiteAsync(new WebSite(id));
			
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

		[HttpPost("WebSite")]
		public async Task<IActionResult> PostWebSiteAsync([FromBody]WebSiteRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PostWebSiteAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<WebSiteRequestModel>();
			
			try
			{
				var entity = requestModel.ToEntity();
			
				// Add entity to database
				await Repository.AddWebSiteAsync(entity);
			
				response.Model = entity.ToRequestModel();
			
				Logger?.LogInformation("The entity was created successfully");
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpPut("WebSite")]
		public async Task<IActionResult> PutWebSiteAsync(Int32? id, [FromBody]WebSiteRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PutWebSiteAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<WebSiteRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetWebSiteAsync(new WebSite(id));
			
				if (entity != null)
				{
					// todo:  Check properties to update
					// Apply changes on entity
					entity.SiteNo = requestModel.SiteNo;
					entity.SiteName = requestModel.SiteName;
					entity.SiteUrls = requestModel.SiteUrls;
					entity.LogoUrls = requestModel.LogoUrls;
					entity.Count = requestModel.Count;
					entity.Title = requestModel.Title;
					entity.Keywords = requestModel.Keywords;
					entity.Description = requestModel.Description;
					entity.RowVers = requestModel.RowVers;
					entity.IsEnable = requestModel.IsEnable;
					entity.Remarks = requestModel.Remarks;
					entity.CreateBy = requestModel.CreateBy;
					entity.CreateTime = requestModel.CreateTime;
			
					// Save changes for entity in database
					await Repository.UpdateWebSiteAsync(entity);
			
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

		[HttpDelete("WebSite")]
		public async Task<IActionResult> DeleteWebSiteAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(DeleteWebSiteAsync));
			
			var response = new SingleResponse<WebSiteRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetWebSiteAsync(new WebSite(id));
			
				if (entity != null)
				{
					// Remove entity from database
					await Repository.RemoveWebSiteAsync(entity);
			
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

		[HttpGet("WebSpecial")]
		public async Task<IActionResult> GetWebSpecialsAsync(Int32? pageSize = 10, Int32? pageNumber = 1)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetWebSpecialsAsync));
			
			var response = new PagedResponse<WebSpecial>();
			
			try
			{
				// Get query from repository
				var query = Repository.GetWebSpecials();
			
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

		[HttpGet("WebSpecial/{id}")]
		public async Task<IActionResult> GetWebSpecialAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(GetWebSpecialAsync));
			
			var response = new SingleResponse<WebSpecialRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetWebSpecialAsync(new WebSpecial(id));
			
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

		[HttpPost("WebSpecial")]
		public async Task<IActionResult> PostWebSpecialAsync([FromBody]WebSpecialRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PostWebSpecialAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<WebSpecialRequestModel>();
			
			try
			{
				var entity = requestModel.ToEntity();
			
				// Add entity to database
				await Repository.AddWebSpecialAsync(entity);
			
				response.Model = entity.ToRequestModel();
			
				Logger?.LogInformation("The entity was created successfully");
			}
			catch (Exception ex)
			{
				response.SetError(ex, Logger);
			}
			
			return response.ToHttpResponse();
		}

		[HttpPut("WebSpecial")]
		public async Task<IActionResult> PutWebSpecialAsync(Int32? id, [FromBody]WebSpecialRequestModel requestModel)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(PutWebSpecialAsync));
			
			// Validate request model
			if (!ModelState.IsValid)
				return BadRequest(requestModel);
			
			var response = new SingleResponse<WebSpecialRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetWebSpecialAsync(new WebSpecial(id));
			
				if (entity != null)
				{
					// todo:  Check properties to update
					// Apply changes on entity
					entity.SiteNo = requestModel.SiteNo;
					entity.SpecialCode = requestModel.SpecialCode;
					entity.Name = requestModel.Name;
					entity.DisplayType = requestModel.DisplayType;
					entity.IsEnable = requestModel.IsEnable;
					entity.RowVers = requestModel.RowVers;
					entity.Remarks = requestModel.Remarks;
					entity.CreateBy = requestModel.CreateBy;
					entity.CreateTime = requestModel.CreateTime;
			
					// Save changes for entity in database
					await Repository.UpdateWebSpecialAsync(entity);
			
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

		[HttpDelete("WebSpecial")]
		public async Task<IActionResult> DeleteWebSpecialAsync(Int32? id)
		{
			Logger?.LogDebug("'{0}' has been invoked", nameof(DeleteWebSpecialAsync));
			
			var response = new SingleResponse<WebSpecialRequestModel>();
			
			try
			{
				// Retrieve entity by id
				var entity = await Repository.GetWebSpecialAsync(new WebSpecial(id));
			
				if (entity != null)
				{
					// Remove entity from database
					await Repository.RemoveWebSpecialAsync(entity);
			
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
