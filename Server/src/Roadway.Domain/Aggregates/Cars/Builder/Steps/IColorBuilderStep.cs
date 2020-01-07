namespace Roadway.Domain.Aggregates.Cars.Builder.Steps
{
    public interface IColorBuilderStep
    {
        IFuelBuilderStep SetColor(string color);
    }
}