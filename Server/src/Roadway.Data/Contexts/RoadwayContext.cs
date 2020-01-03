using Microsoft.EntityFrameworkCore;
using Roadway.Domain.CarsAggregate;

namespace Roadway.Data.Contexts
{
    public class RoadwayContext : DbContext
    {
        public virtual DbSet<Car> Cars { get; set; }

        public virtual DbSet<CarType> CarTypes { get; set; }
    }
}