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

namespace Northwind.WebAPI.Controllers
{
	[Route("api/[controller]")]
	public class Controller : Controller
	{
		protected readonly IRepository Repository;
		protected ILogger Logger;

		public Controller(IRepository repository, ILogger<Controller> logger)
		{
			Repository = repository;
			Logger = logger;
		}

		protected override void Dispose(Boolean disposing)
		{
			Repository?.Dispose();
			
			base.Dispose(disposing);
		}
	}
}
