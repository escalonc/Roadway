namespace Roadway.Domain.Aggregates.Cars.Builder.Steps
{
    public interface IVersionBuilderStep
    {
        IYearBuilderStep SetVersion(string version);
    }
}