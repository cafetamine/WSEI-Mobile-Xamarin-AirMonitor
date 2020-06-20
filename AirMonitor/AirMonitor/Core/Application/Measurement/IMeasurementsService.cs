using System.Collections.Generic;
using System.Threading.Tasks;
using AirMonitor.Core.Domain.Installation;

namespace AirMonitor.Core.Application.Measurement
{
    public interface IMeasurementsService
    {
        Task<List<Domain.Measurement.Measurement>> GetMeasurements(LocationMapping location, int maxResults = 3);
    }
}
