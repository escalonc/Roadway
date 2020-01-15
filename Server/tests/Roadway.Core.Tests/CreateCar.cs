using System;
using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using Moq;
using Roadway.Core.Cars;
using Roadway.Core.Exceptions;
using Roadway.Domain.Aggregates.Cars;
using Roadway.Domain.Aggregates.Cars.Builder;
using Roadway.Domain.Aggregates.Customers;
using Xunit;

namespace Roadway.Core.Tests
{
    public class CreateCar
    {
        private readonly Car _stubCar;
        private readonly Customer _stubCustomer;

        public CreateCar()
        {
            _stubCustomer = new Customer(3, "Mark", "", "Foster", "");
            _stubCar = new CarBuilder("123")
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
                .SetCustomer(_stubCustomer)
                .Build();
        }

        [Fact]
        public async Task Create_Car_CallRepository()
        {
            var carRepositoryMock = new Mock<ICarRepository>();
            var customerRepositoryMock = new Mock<ICustomerRepository>();

            customerRepositoryMock
                .Setup(m => m.FindById(It.Is<int>(i => i == 3)))
                .ReturnsAsync(
                    _stubCustomer);

            var carService = new CarService(carRepositoryMock.Object, customerRepositoryMock.Object);
            await carService.Create(_stubCar);

            carRepositoryMock.Verify(car => car.AddAsync(_stubCar), Times.Once);
        }

        [Fact]
        public void Create_Throws_CustomerNotFound()
        {
            var carRepositoryMock = new Mock<ICarRepository>();
            var customerRepositoryMock = new Mock<ICustomerRepository>();

            customerRepositoryMock
                .Setup(m => m.FindById(It.Is<int>(i => i == 2)))
                .ReturnsAsync(
                    _stubCustomer);

            var carService = new CarService(carRepositoryMock.Object, customerRepositoryMock.Object);
            Func<Task> createCar = async () => { await carService.Create(_stubCar); };

            createCar.Should().Throw<CustomerNotFoundException>();
        }
    }
}