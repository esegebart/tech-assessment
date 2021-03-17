using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace InventoryService.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class Test : ControllerBase
	{ 
		[HttpGet]
		public string Get()
		{
			return "Success!";
		}

		[HttpDelete]
		public string Delete()
        {
			return "Deleted!";
        }
	}
}
