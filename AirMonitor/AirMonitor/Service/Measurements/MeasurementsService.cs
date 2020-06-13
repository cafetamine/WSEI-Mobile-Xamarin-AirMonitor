using System.Collections.Generic;
using System.Threading.Tasks;
using AirMonitor.Client.Airly;
using AirMonitor.Client.Airly.Api.Measurement;

namespace AirMonitor.Service.Measurements
{
    public class MeasurementsService : IMeasurementsService
    {
        private readonly IAirlyClient _client;
        
        public MeasurementsService(IAirlyClient client)
        {
            _client = client;
        }

        public async Task<List<ApiMeasurement>> GetMeasurements(Xamarin.Essentials.Location location, int maxResults = 3)
        {
            var installations = await _client.GetInstallations(location, maxResults);
            var data = await _client.GetMeasurementsForInstallations(installations);
            return new List<ApiMeasurement>(data);
        }
    }
}
