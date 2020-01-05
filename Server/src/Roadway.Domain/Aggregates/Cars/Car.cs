using Roadway.Domain.Contracts;

namespace Roadway.Domain.Aggregates.Cars
{
    public class Car : BaseEntity, IAggregateRoot
    {
        public Car(
            string vin,
            string licensePlate,
            string brand,
            string model,
            string version,
            ushort year,
            string color,
            Fuels fuel,
            Sizes size,
            Uses use,
            CarType carType
        )
        {
            Vin = vin;
            LicensePlate = licensePlate;
            Brand = brand;
            Model = model;
            Version = version;
            Year = year;
            Color = color;
            Fuel = fuel;
            Size = size;
            Use = use;
            CarType = carType;
        }

        public string Vin { get; }

        public string LicensePlate { get; }

        public string Brand { get; }

        public string Model { get; }

        public string Version { get; }

        public ushort Year { get; }

        public string Color { get; }

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