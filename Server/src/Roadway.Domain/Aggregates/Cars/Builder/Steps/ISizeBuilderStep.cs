namespace Roadway.Domain.Aggregates.Cars.Builder.Steps
{
    public interface ISizeBuilderStep
    {
        IUseBuilderStep SetSize(Sizes size);
    }
}