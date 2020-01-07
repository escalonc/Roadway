namespace Roadway.Domain.Aggregates.Cars.Builder.Steps
{
    public interface IYearBuilderStep
    {
        IColorBuilderStep SetYear(ushort year);
    }
}