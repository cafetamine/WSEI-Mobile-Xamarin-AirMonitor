using System.Collections.Generic;
using System.Threading.Tasks;
using AirMonitor.Client.Airly;
using AirMonitor.Model.Domain.Installation;
using AirMonitor.Model.Domain.Measurement;

namespace AirMonitor.Service.Measurements
{
    public class MeasurementsService : IMeasurementsService
    {
        private readonly IAirlyClient _client;
        
        public MeasurementsService(IAirlyClient client)
        {
            _client = client;
        }

        public async Task<List<Measurement>> GetMeasurements(LocationMapping location, int maxResults = 3)
        {
            var apiInstallations = await _client.GetInstallations(location, maxResults);
            var installations = AirlyApiAdapter.FromApi(apiInstallations);
            var measurements = new List<Measurement>();

            foreach (var installation in installations)
            {
                var measurement = await _client.GetMeasurementForInstallation(installation.Id);
                if (measurement != null)
                {
                    measurements.Add(AirlyApiAdapter.FromApi(measurement, installation));
                }
            }

            return new List<Measurement>(measurements);
        }
    }
}
