using System.Collections.Generic;
using System.Threading.Tasks;
using AirMonitor.Client.Airly.Api.Installation;
using AirMonitor.Client.Airly.Api.Measurement;
using Xamarin.Essentials;

namespace AirMonitor.Client.Airly
{
    public interface IAirlyClient
    {
        Task<IEnumerable<ApiInstallation>> GetInstallations(Location location, double maxDistanceInKm = 3, int maxResults = -1);

        Task<IEnumerable<ApiMeasurement>> GetMeasurementsForInstallations(IEnumerable<ApiInstallation> installations);
    }
}
