using Microsoft.EntityFrameworkCore;
using Roadway.Domain.Aggregates.Cars;

namespace Roadway.Data.Contexts
{
    public class RoadwayContext : DbContext
    {
        public RoadwayContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<CarType> CarTypes { get; set; }
    }
}