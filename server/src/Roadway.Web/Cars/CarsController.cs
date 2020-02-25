using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Roadway.Core.Cars;
using Roadway.Domain.Aggregates.Cars;
using Roadway.Domain.Aggregates.Cars.Builder;
using Roadway.Domain.Aggregates.Customers;

namespace Roadway.Web.Cars
{
    [Route("[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ILogger<CarsController> _logger;
        private readonly ICarService _carService;

        public CarsController(ICarService carService, ILogger<CarsController> logger)
        {
            _carService = carService;
            _logger = logger;
        }

        // GET: api/Cars
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] {"value1", "value2"};
        }

        // GET: api/Cars/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Cars
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CarRequestModel car)
        {

            var carInfo = new CarBuilder(car.Vin)
                .SetBrand(car.Brand)
                .SetColor(car.Color)
                .SetFuel((Fuels) car.Fuel)
                .SetModel(car.Model)
                .SetSize((Sizes) car.Size)
                .SetType(new CarType {Id = car.CarTypeId.Value})
                .SetUse((Uses) car.Use)
                .SetVersion(car.Version)
                .SetYear(car.Year.Value)
                .SetLicensePlate(car.LicensePlate)
                .SetCustomer(new Customer {Id = car.CustomerId.Value})
                .Build();

            await _carService.CreateAsync(carInfo);

            return CreatedAtAction(nameof(Get), new {id = carInfo.Id}, carInfo);
        }

        // PUT: api/Cars/5
        [HttpPut("{id}")]
        public void Put(int? id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int? id)
        {
        }
    }
}