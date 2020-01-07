using System;
using Roadway.Data.Contexts;

namespace Roadway.Data.Tests.Contexts
{
    public class InMemoryRoadwayContextFixture : IDisposable
    {
        protected readonly RoadwayContext RoadwayContext;

        protected InMemoryRoadwayContextFixture()
        {
            RoadwayContext = InMemoryRoadwayContextFactory.Create();
        }

        public void Dispose()
        {
            RoadwayContext.Database.EnsureDeleted();
        }
    }
}