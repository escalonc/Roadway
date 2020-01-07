using Roadway.Domain.Aggregates.Cars.Builder.Steps;

namespace Roadway.Domain.Aggregates.Cars.Builder
{
    public interface ICarBuilder :
        ICarTypeBuilderStep, 
        IColorBuilderStep,
        IBrandBuilderStep,
        IFuelBuilderStep,
        ILicensePlateBuilderStep,
        IModelBuilderStep,
        ISizeBuilderStep,
        IUseBuilderStep,
        IVersionBuilderStep, 
        IYearBuilderStep,
        IFinalBuilderStep
    {
    }
}