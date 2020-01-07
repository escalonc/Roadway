namespace Roadway.Domain.Aggregates.Cars.Builder.Steps
{
    public interface IModelBuilderStep
    {
        IVersionBuilderStep SetModel(string model);
    }
}