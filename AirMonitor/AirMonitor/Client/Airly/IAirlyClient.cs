using System.Collections.Generic;
using System.Threading.Tasks;
using AirMonitor.Client.Airly.Api.Installation;
using AirMonitor.Client.Airly.Api.Measurement;
using AirMonitor.Core.Domain.Installation;

namespace AirMonitor.Client.Airly
{
    public interface IAirlyClient
    {
        Task<IEnumerable<ApiInstallation>> GetInstallations(LocationMapping location, double maxDistanceInKm = 3, int maxResults = -1);

        Task<ApiMeasurement> GetMeasurementForInstallation(int installationId);
    }
}
