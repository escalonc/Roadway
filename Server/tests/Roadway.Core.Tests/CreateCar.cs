using System.Linq;
using System.Threading.Tasks;
using Moq;
using Roadway.Core.Cars;
using Roadway.Domain.Aggregates.Cars;
using Roadway.Domain.Aggregates.Cars.Builder;
using Roadway.Domain.Aggregates.Customers;
using Xunit;

namespace Roadway.Core.Tests
{
    public class CreateCar
    {
        [Fact]
        public async Task Create_Car_CallRepository()
        {
            var carRepositoryMock = new Mock<ICarRepository>();
            var customerRepositoryMock = new Mock<ICustomerRepository>();

            customerRepositoryMock
                .Setup(m => m.FindById(It.Is<int>(i => i == 3)))
                .ReturnsAsync(
                    new Customer(3, "AAA", "", "Foster", ""));

            var carService = new CarService(carRepositoryMock.Object, customerRepositoryMock.Object);

            var fakeCar = new CarBuilder("123")
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
                .SetCustomer(new Customer(3, "Mark", "", "Foster", ""))
                .Build();

            await carService.Create(fakeCar);

            carRepositoryMock.Verify(car => car.AddAsync(fakeCar), Times.Once);
        }
    }
}