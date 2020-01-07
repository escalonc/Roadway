namespace Roadway.Domain.Aggregates.Cars.Builder.Steps
{
    public interface IUseBuilderStep
    {
        ICarTypeBuilderStep SetUse(Uses use);
    }
}