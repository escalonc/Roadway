using System;
using Roadway.Data.Contexts;

namespace Roadway.Data.Tests.Contexts
{
    public class InMemoryRoadwayContextFixture : IDisposable
    {
        protected readonly RoadwayContext DatabaseContext;

        protected InMemoryRoadwayContextFixture()
        {
            DatabaseContext = InMemoryRoadwayContextFactory.Create();
        }

        public void Dispose()
        {
            DatabaseContext.Database.EnsureDeleted();
        }
    }
}