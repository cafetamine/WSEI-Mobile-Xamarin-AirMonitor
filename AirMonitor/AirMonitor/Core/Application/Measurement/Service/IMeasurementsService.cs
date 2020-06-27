using System.Collections.Generic;
using System.Threading.Tasks;
using AirMonitor.Core.Domain.Installation;
using MeasurementDomain = AirMonitor.Core.Domain.Measurement.Measurement;

namespace AirMonitor.Core.Application.Measurement.Service
{
    public interface IMeasurementsService
    {
        Task<List<MeasurementDomain>> GetMeasurements(LocationMapping location, int maxResults = 3);

        List<MeasurementDomain> ReadMeasurements();
    }
}
