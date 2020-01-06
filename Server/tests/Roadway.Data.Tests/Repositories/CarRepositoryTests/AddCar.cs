using System.Threading.Tasks;
using FluentAssertions;
using Roadway.Data.Repositories;
using Roadway.Data.Tests.Contexts;
using Roadway.Domain.Aggregates.Cars;
using Xunit;

namespace Roadway.Data.Tests.Repositories.CarRepositoryTests
{
    public class AddCar : InMemoryRoadwayContextFixture
    {
        [Fact]
        public async Task Insert_Car_IncreaseCountByOne()
        {
             
        }
    }
}