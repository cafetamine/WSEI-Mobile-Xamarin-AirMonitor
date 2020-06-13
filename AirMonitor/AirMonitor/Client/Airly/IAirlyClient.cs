using System.Collections.Generic;
using System.Threading.Tasks;
using AirMonitor.Client.Airly.Response;
using Xamarin.Essentials;

namespace AirMonitor.Client.Airly
{
    public interface IAirlyClient
    {
        Task<IEnumerable<ApiInstallationResponse>> GetInstallations(Location location, double maxDistanceInKm = 3, int maxResults = -1);

        Task<IEnumerable<ApiMeasurementResponse>> GetMeasurementsForInstallations(IEnumerable<ApiInstallationResponse> installations);
    }
}
