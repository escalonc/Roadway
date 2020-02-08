using System.Threading.Tasks;
using FluentAssertions;
using Roadway.Data.Tests.Contexts;
using Xunit;

namespace Roadway.Data.Tests.Repositories.EfCoreTests
{
    public class AddEntity : InMemoryDatabaseContextFixture
    {
        [Fact]
        public async Task Add_Entity_IncreaseCountByOne()
        {
            var repository = new TestRepository(TestContext);
            var entityStub = new TestEntity("Example");

            await repository.AddAsync(entityStub);
            var entitiesAmount = repository.Count();

            entitiesAmount.Should().Be(1);
        }
    }
}