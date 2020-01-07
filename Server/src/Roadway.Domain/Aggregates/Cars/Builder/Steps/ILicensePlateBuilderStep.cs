namespace Roadway.Domain.Aggregates.Cars.Builder.Steps
{
    public interface ILicensePlateBuilderStep
    {
        IBrandBuilderStep SetLicensePlate(string licensePlate);
    }
}