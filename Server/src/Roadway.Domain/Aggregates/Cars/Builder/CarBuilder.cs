using Roadway.Domain.Aggregates.Customers;

namespace Roadway.Domain.Aggregates.Cars.Builder
{
    public class CarBuilder : ICarBuilder
    {
        public CarBuilder(string vin)
        {
            Vin = vin;
        }

        public string Vin { get; }
        public string LicensePlate { get; private set; }
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public string Version { get; private set; }
        public ushort Year { get; private set; }
        public string Color { get; private set; }
        public Fuels Fuel { get; private set; }
        public Sizes Size { get; private set; }
        public Uses Use { get; private set; }
        public CarType Type { get; private set; }

        public Customer Customer { get; private set; }

        public ICarBuilder SetLicensePlate(string licensePlate)
        {
            LicensePlate = licensePlate;
            return this;
        }

        public ICarBuilder SetBrand(string brand)
        {
            Brand = brand;
            return this;
        }

        public ICarBuilder SetColor(string color)
        {
            Color = color;
            return this;
        }

        public ICarBuilder SetFuel(Fuels fuel)
        {
            Fuel = fuel;
            return this;
        }

        public ICarBuilder SetModel(string model)
        {
            Model = model;
            return this;
        }

        public ICarBuilder SetSize(Sizes size)
        {
            Size = size;
            return this;
        }

        public ICarBuilder SetUse(Uses use)
        {
            Use = use;
            return this;
        }

        public ICarBuilder SetVersion(string version)
        {
            Version = version;
            return this;
        }

        public ICarBuilder SetYear(ushort year)
        {
            Year = year;
            return this;
        }

        public ICarBuilder SetCustomer(Customer customer)
        {
            Customer = customer;
            return this;
        }

        public ICarBuilder SetType(CarType type)
        {
            Type = type;
            return this;
        }

        public Car Build()
        {
            return new Car
            (
                Vin,
                LicensePlate,
                Brand,
                Model,
                Version,
                Year,
                Color,
                Fuel,
                Size,
                Use,
                Type,
                Customer
            );
        }
    }
}