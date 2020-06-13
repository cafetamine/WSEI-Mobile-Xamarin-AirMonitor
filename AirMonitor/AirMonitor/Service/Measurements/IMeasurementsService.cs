using System.Collections.Generic;
using System.Threading.Tasks;
using AirMonitor.Client.Airly.Response;

namespace AirMonitor.Service.Measurements
{
    public interface IMeasurementsService
    {
        Task<List<ApiMeasurementResponse>> GetMeasurements(Xamarin.Essentials.Location location, int maxResults = 3);
    }
}
