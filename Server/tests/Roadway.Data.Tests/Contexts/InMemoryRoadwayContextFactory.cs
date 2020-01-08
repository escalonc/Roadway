using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Roadway.Data.Contexts;

namespace Roadway.Data.Tests.Contexts
{
    public static class InMemoryRoadwayContextFactory
    {
        public static RoadwayContext Create(SqliteConnection connection)
        {
            var options = new DbContextOptionsBuilder<RoadwayContext>()
                .UseSqlite(connection)
                .Options;
            
            var dbContext = new RoadwayContext(options);
            dbContext.Database.EnsureCreated();

            return dbContext;
        }
    }
}