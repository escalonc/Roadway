namespace Roadway.Domain.CarsAggreate
{
    public class Car : BaseEntity, IAggregateRoot
    {
        public ushort Year { get; }

        public string Vin { get; }

        public string LicensePlate { get; }

        public string Color { get; }

        public string Brand { get; }

        public string Model { get; }

        public string Version { get; }

        public Fuels Fuel { get; }

        public Sizes Size { get; }
        
        public Uses Use { get; }
        
        public CarType CarType { get; }
        
    }

    public enum Uses
    {
        Personal,
        Rental,
        Government,
        Official
    }

    public enum Sizes
    {
        Small,
        Medium,
        Large,
        ExtraLarge
    }

    public enum Fuels
    {
        Gasoline,
        Diesel,
        Electric,
        Mixed
    }
}