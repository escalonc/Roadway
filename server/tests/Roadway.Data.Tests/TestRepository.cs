using Roadway.Data.Repositories;

namespace Roadway.Data.Tests
{
    public class TestRepository : EfRepository<TestEntity>
    {
        public TestRepository(TestContext context) : base(context)
        {
        }
    }
}