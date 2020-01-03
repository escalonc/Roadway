using Microsoft.EntityFrameworkCore;
using Roadway.Data.Contexts;

namespace Roadway.Data.Tests.Contexts
{
    public class InMemoryRoadwayContextFactory
    {
        public static RoadwayContext Create()
        {
            var options = new DbContextOptionsBuilder<RoadwayContext>()
                .UseInMemoryDatabase(databaseName: "RoadwayTest")
                .Options;
            var dbContext = new RoadwayContext(options);

            return dbContext;
        }
    }
}