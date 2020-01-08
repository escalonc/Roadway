using Roadway.Domain.Contracts;

namespace Roadway.Domain.Aggregates.Cars
{
    public class CarType : BaseEntity, IAggregateRoot
    {
        public CarType(string name)
        {
            Name = name;
        }

        private CarType()
        {
        }

        public string Name { get; set; }
    }
}