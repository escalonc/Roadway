using Roadway.Domain.Aggregates.Cars.Builder.Steps;

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
        
        public IBrandBuilderStep SetLicensePlate(string licensePlate)
        {
            LicensePlate = licensePlate;
            return this;
        }
        
        public IModelBuilderStep SetBrand(string brand)
        {
            Brand = brand;
            return this;
        }

        public IFuelBuilderStep SetColor(string color)
        {
            Color = color;
            return this;
        }

        public ISizeBuilderStep SetFuel(Fuels fuel)
        {
            Fuel = fuel;
            return this;
        }

        public IVersionBuilderStep SetModel(string model)
        {
            Model = model;
            return this;
        }

        public IUseBuilderStep SetSize(Sizes size)
        {
            Size = size;
            return this;
        }

        public ICarTypeBuilderStep SetUse(Uses use)
        {
            Use = use;
            return this;
        }

        public IYearBuilderStep SetVersion(string version)
        {
            Version = version;
            return this;
        }

        public IColorBuilderStep SetYear(ushort year)
        {
            Year = year;
            return this;
        }
        
        public IFinalBuilderStep SetType(CarType type)
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
                Type
            );
        }
    }
}