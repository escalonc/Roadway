namespace Roadway.Domain.Aggregates.Cars.Builder.Steps
{
    public interface IFuelBuilderStep
    {
        ISizeBuilderStep SetFuel(Fuels fuel);
        
    }
}