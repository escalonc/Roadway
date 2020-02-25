using System.Threading.Tasks;
using FluentAssertions;
using Roadway.Data.Tests.Contexts;
using Xunit;

namespace Roadway.Data.Tests.Repositories.EfCoreTests
{
    public class UpdateEntity : InMemoryDatabaseContextFixture
    {
        [Fact]
        public async Task Update_Entity_ChangeInformation()
        {
            var repository = new TestRepository(TestContext);

            var entityStub = new TestEntity("Example");
            await repository.AddAsync(entityStub);
            
            entityStub.Name = "123";
            await repository.UpdateAsync(entityStub);
            var expectedEntity = await repository.FirstOrDefaultAsync(c => c.Id == entityStub.Id);

            expectedEntity.Should().BeEquivalentTo(entityStub);
        }
    }
}