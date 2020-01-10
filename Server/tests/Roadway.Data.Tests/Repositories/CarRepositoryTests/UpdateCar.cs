using System.Threading.Tasks;
using FluentAssertions;
using Roadway.Data.Repositories;
using Roadway.Data.Tests.Contexts;
using Roadway.Domain.Aggregates.Cars;
using Roadway.Domain.Aggregates.Cars.Builder;
using Xunit;

namespace Roadway.Data.Tests.Repositories.CarRepositoryTests
{
    public class UpdateCar : InMemoryRoadwayContextFixture
    {
        [Fact]
        public async Task Update_Car_ChangeInformation()
        {
            var repository = new CarRepository(RoadwayContext);

            var carStub = new CarBuilder("123")
                .SetBrand("Toyota")
                .SetColor("blue")
                .SetFuel(Fuels.Diesel)
                .SetModel("Corolla")
                .SetSize(Sizes.Large)
                .SetType(new CarType("Example"))
                .SetUse(Uses.Government)
                .SetVersion("American")
                .SetYear(1997)
                .SetLicensePlate("AAAA")
                .Build();

            await repository.AddAsync(carStub);
            carStub.Brand = "Mazda";
            carStub.Color = "Mazda";
            carStub.Fuel = Fuels.Electric;
            carStub.Model = "Mazda";
            carStub.Size = Sizes.Large;
            carStub.CarType = new CarType("Example 2");
            carStub.Use = Uses.Personal;
            carStub.Version = "Japanese";
            carStub.Year = 1990;
            carStub.LicensePlate = "BBBBB";

            await repository.UpdateAsync(carStub);
            var selectedCar = await repository.FirstOrDefaultAsync(c => c.Vin == "123");

            selectedCar.Should().BeEquivalentTo(carStub);
        }
    }
}