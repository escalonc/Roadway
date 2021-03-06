using Roadway.Domain.Aggregates.Customers;
using Roadway.Domain.Contracts;

namespace Roadway.Domain.Aggregates.Cars
{
    public class Car : BaseEntity, IAggregateRoot
    {
        public Car(string vin, string licensePlate, string brand, string model, string version, ushort year,
            string color, Fuels fuel, Sizes size, Uses use, CarType carType, Customer customer)
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
            Customer = customer;
        }

        private Car()
        {
        }

        public string Vin { get; private set; }

        public string LicensePlate { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public string Version { get; set; }

        public ushort Year { get; set; }

        public string Color { get; set; }

        public string Bank { get; set; }

        public string Insurance { get; set; }

        public Fuels Fuel { get; set; }

        public Sizes Size { get; set; }

        public Uses Use { get; set; }

        public CarType CarType { get; set; }

        public Customer Customer { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Car car && this.Vin.Equals(car.Vin);
        }

        public override int GetHashCode()
        {
            return Vin.GetHashCode();
        }
    }

    public enum Uses
    {
        Personal = 1,
        Rental = 2,
        Government = 3,
        Official = 4,
    }

    public enum Sizes
    {
        Small = 1,
        Medium = 2,
        Large = 3,
        ExtraLarge = 4
    }

    public enum Fuels
    {
        Gasoline = 1,
        Diesel = 2,
        Electric = 3,
        Mixed = 4
    }
}