using Microsoft.EntityFrameworkCore;
using Roadway.Domain.CarsAggregate;

namespace Roadway.Data.Contexts
{
    public class RoadwayContext : DbContext
    {
        public RoadwayContext(DbContextOptions options) : base(options)
        {
            
        }
        public virtual DbSet<Car> Cars { get; set; }

        public virtual DbSet<CarType> CarTypes { get; set; }
    }
}