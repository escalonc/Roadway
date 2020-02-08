using Microsoft.EntityFrameworkCore;
using Roadway.Domain.Aggregates.Cars;

namespace Roadway.Data.Repositories
{
    public class CarRepository : EfRepository<Car>, ICarRepository
    {
        public CarRepository(DbContext context) : base(context)
        {
        }
    }
}