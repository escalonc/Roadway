using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Roadway.Domain.Aggregates.Cars;

namespace Roadway.Core.Cars
{
    public interface ICarService
    {
        Task Create(Car car);
    }
}