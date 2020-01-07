namespace Roadway.Domain.Aggregates.Cars.Builder.Steps
{
    public interface IBrandBuilderStep
    {
        IModelBuilderStep SetBrand(string model);
    }
}