namespace Roadway.Domain.CarsAggreate
{
    public class CarType : BaseEntity, IAggregateRoot
    {
        public string Name { get; }
    }
}