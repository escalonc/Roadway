using System.Collections.Generic;
using System.Threading.Tasks;
using Roadway.Core.Exceptions;
using Roadway.Domain.Aggregates.Cars;
using Roadway.Domain.Aggregates.Customers;

namespace Roadway.Core.Cars
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        private readonly ICustomerRepository _customerRepository;

        public CarService(ICarRepository carRepository, ICustomerRepository customerRepository)
        {
            _carRepository = carRepository;
            _customerRepository = customerRepository;
        }

        public async Task Create(Car car)
        {
            var customer = await _customerRepository.FindById(car.Customer.Id);

            if (customer == null)
            {
                throw new CustomerNotFoundException();
            }
            
            await _carRepository.AddAsync(car);
        }
    }
}