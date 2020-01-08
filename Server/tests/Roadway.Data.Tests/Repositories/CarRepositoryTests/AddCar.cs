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
        public async Task Add_Car_IncreaseCountByOne()
        {
            var repository = new CarRepository(RoadwayContext);

            var carStub = new CarBuilder("123")
                .SetLicensePlate("123")
                .SetBrand("Toyota")
                .SetModel("Corolla")
                .SetVersion("American")
                .SetYear(1997)
                .SetColor("Blue")
                .SetFuel(Fuels.Diesel)
                .SetSize(Sizes.Medium)
                .SetUse(Uses.Personal)
                .SetType(new CarType("Normal"))
                .Build();

            await repository.AddAsync(carStub);
            var carsAmount = repository.Count();

            carsAmount.Should().Be(1);
        }
    }
}