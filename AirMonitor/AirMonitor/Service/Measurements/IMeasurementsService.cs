using System.Collections.Generic;
using System.Threading.Tasks;
using AirMonitor.Client.Airly.Api.Measurement;

namespace AirMonitor.Service.Measurements
{
    public interface IMeasurementsService
    {
        Task<List<ApiMeasurement>> GetMeasurements(Xamarin.Essentials.Location location, int maxResults = 3);
    }
}
