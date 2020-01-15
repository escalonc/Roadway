using Microsoft.EntityFrameworkCore;

namespace Roadway.Data.Tests
{
    public class TestContext : DbContext
    {
        public TestContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TestEntity> TestEntities { get; set; }
    }
}