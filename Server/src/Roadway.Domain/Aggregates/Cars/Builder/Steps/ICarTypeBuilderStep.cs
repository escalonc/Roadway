namespace Roadway.Domain.Aggregates.Cars.Builder.Steps
{
    public interface ICarTypeBuilderStep
    {
        IFinalBuilderStep SetType(CarType type);
    }
}