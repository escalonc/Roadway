using Roadway.Domain;
using Roadway.Domain.Contracts;

namespace Roadway.Data.Tests
{
    public class TestEntity : BaseEntity, IAggregateRoot
    {
        private TestEntity()
        {
        }

        public TestEntity(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}