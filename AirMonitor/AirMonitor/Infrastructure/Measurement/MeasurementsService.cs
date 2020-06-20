using System.Collections.Generic;
using System.Threading.Tasks;
using AirMonitor.Client.Airly;
using AirMonitor.Core.Application.Measurement;
using AirMonitor.Core.Domain.Installation;

namespace AirMonitor.Infrastructure.Measurement
{
    public class MeasurementsService : IMeasurementsService
    {
        private readonly IAirlyClient _client;
        
        public MeasurementsService(IAirlyClient client)
        {
            _client = client;
        }

        public async Task<List<Core.Domain.Measurement.Measurement>> GetMeasurements(LocationMapping location, int maxResults = 3)
        {
            var apiInstallations = await _client.GetInstallations(location, maxResults);
            var installations = AirlyApiAdapter.FromApi(apiInstallations);
            var measurements = new List<Core.Domain.Measurement.Measurement>();

            foreach (var installation in installations)
            {
                var measurement = await _client.GetMeasurementForInstallation(installation.Id);
                if (measurement != null)
                {
                    measurements.Add(AirlyApiAdapter.FromApi(measurement, installation));
                }
            }

            return new List<Core.Domain.Measurement.Measurement>(measurements);
        }
    }
}
