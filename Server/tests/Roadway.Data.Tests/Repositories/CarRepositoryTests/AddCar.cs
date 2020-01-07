using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Roadway.Data.Repositories;
using Roadway.Data.Tests.Contexts;
using Roadway.Domain.Aggregates.Cars;
using Roadway.Domain.Aggregates.Cars.Builder;
using Xunit;

namespace Roadway.Data.Tests.Repositories.CarRepositoryTests
{
    public class AddCar : InMemoryRoadwayContextFixture
    {
        [Fact]
        public void Add_Car_IncreaseCountByOne()
        {
            var repository = new CarRepository(RoadwayContext);
            
            var car = new CarBuilder("123")
                .SetLicensePlate("123")
                .SetBrand("Toyota")
                .SetModel("Corolla")
                .SetVersion("American")
                .SetYear(1997)
                .SetColor("Blue")
                .SetFuel(Fuels.Diesel)
                .SetSize(Sizes.Medium)
                .SetUse(Uses.Personal)
                .SetType(new CarType("Ass"))
                .Build();
            
            // var car = new Car("123", "xyz", "Toyota", "Corolla", "American", 1997, "Yellow", Fuels.Diesel, Sizes.Large, Uses.Personal, new CarType("Add"));

            // await repository.AddAsync(car);
            // var selectedCar = await repository
            //     .FirstOrDefaultAsync(x => x.Brand.Equals("Toyota"));

             RoadwayContext.Cars.Add(car);
            var selectedCar = RoadwayContext.Cars.AsEnumerable().FirstOrDefault(x => x.Brand.Equals("Toyota"));
            
            selectedCar.Should().NotBeNull();
        }
    }
}