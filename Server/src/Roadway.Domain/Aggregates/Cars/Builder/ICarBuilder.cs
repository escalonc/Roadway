using Roadway.Domain.Aggregates.Customers;

namespace Roadway.Domain.Aggregates.Cars.Builder
{
    public interface ICarBuilder 
    {
        ICarBuilder SetBrand(string model);
        
        ICarBuilder SetType(CarType type);
        
        ICarBuilder SetColor(string color);
        
        ICarBuilder SetFuel(Fuels fuel);
        
        ICarBuilder SetLicensePlate(string licensePlate);
        
        ICarBuilder SetModel(string model);
        
        ICarBuilder SetSize(Sizes size);
        
        ICarBuilder SetUse(Uses use);
        
        ICarBuilder SetVersion(string version);
        
        ICarBuilder SetYear(ushort year);

        ICarBuilder SetCustomer(Customer customer);
        
        Car Build();
    }
}