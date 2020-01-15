using Microsoft.EntityFrameworkCore;
using Roadway.Data.Repositories;

namespace Roadway.Data.Tests
{
    public class TestRepository : EfRepository<TestEntity>
    {
        public TestRepository(DbContext context) : base(context)
        {
        }
    }
}