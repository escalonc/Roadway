using Roadway.Domain.Contracts;

namespace Roadway.Domain.Aggregates.Cars
{
    public class Car : BaseEntity, IAggregateRoot
    {
        public Car(string vin, string licensePlate, string brand, string model, string version, ushort year,
            string color, Fuels fuel, Sizes size, Uses use, CarType carType)
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

        private Car()
        {
        }

        public string Vin { get; set; }

        public string LicensePlate { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public string Version { get; set; }

        public ushort Year { get; set; }

        public string Color { get; set; }

        public Fuels Fuel { get; set; }

        public Sizes Size { get; set; }

        public Uses Use { get; set; }

        public CarType CarType { get; set; }
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