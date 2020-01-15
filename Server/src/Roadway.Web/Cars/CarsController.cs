using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Roadway.Core.Cars;
using Roadway.Domain.Aggregates.Cars;

namespace Roadway.Web.Cars
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : Controller
    {
        private readonly ICarService _carService;
        private readonly ILogger<CarsController> _logger;

        public CarsController(ICarService carService, ILogger<CarsController> logger)
        {
            _carService = carService;
            _logger = logger;
        }
        
        [HttpPost]
        public IActionResult Post([FromBody]CarRequestViewModel car)
        {
            return Json(new {Name = " "});
        }
    }
}