namespace Roadway.Domain.CarsAggregate
{
    public class CarType : BaseEntity, IAggregateRoot
    {
        public string Name { get; }
    }
}