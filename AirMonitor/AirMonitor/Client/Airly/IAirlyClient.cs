using System.Collections.Generic;
using System.Threading.Tasks;
using AirMonitor.Client.Airly.Api.Installation;
using AirMonitor.Client.Airly.Api.Measurement;
using AirMonitor.Model.Domain.Installation;

namespace AirMonitor.Client.Airly
{
    public interface IAirlyClient
    {
        Task<IEnumerable<ApiInstallation>> GetInstallations(LocationMapping location, double maxDistanceInKm = 3, int maxResults = -1);

        Task<ApiMeasurement> GetMeasurementForInstallation(ApiInstallation installation);
        
//        Task<IEnumerable<ApiMeasurement>> GetMeasurementsForInstallations(IEnumerable<ApiInstallation> installations);
    }
}
