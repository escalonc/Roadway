using System;
using Microsoft.Data.Sqlite;
using Roadway.Data.Contexts;

namespace Roadway.Data.Tests.Contexts
{
    public class InMemoryRoadwayContextFixture : IDisposable
    {
        protected readonly RoadwayContext RoadwayContext;
        private readonly SqliteConnection _connection;

        protected InMemoryRoadwayContextFixture()
        {
            _connection = new SqliteConnection("DataSource=:memory:");
            _connection.Open();
            RoadwayContext = InMemoryRoadwayContextFactory.Create(_connection);
        }

        public void Dispose()
        {
            RoadwayContext.Database.EnsureDeleted();
            _connection.Close();
        }
    }
}