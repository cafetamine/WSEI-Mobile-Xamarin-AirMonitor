using System.Collections.Generic;
using System.Threading.Tasks;
using AirMonitor.Client.Airly;
using AirMonitor.Core.Application.Measurement.Repository;
using AirMonitor.Core.Application.Measurement.Service;
using AirMonitor.Core.Domain.Installation;
using MeasurementDomain = AirMonitor.Core.Domain.Measurement.Measurement;

namespace AirMonitor.Infrastructure.Measurement
{
    public class MeasurementsService : IMeasurementsService
    {
        private readonly IAirlyClient _client;
        private readonly IMeasurementRepository _measurementRepository;
        
        public MeasurementsService(IAirlyClient client, IMeasurementRepository measurementRepository)
        {
            _client = client;
            _measurementRepository = measurementRepository;
        }

        public async Task<List<MeasurementDomain>> GetMeasurements(LocationMapping location, int maxResults = 3)
        {
            var apiInstallations = await _client.GetInstallations(location, maxResults);
            var installations = AirlyApiAdapter.FromApi(apiInstallations);
            var measurements = new List<MeasurementDomain>();

            foreach (var installation in installations)
            {
                var measurement = await _client.GetMeasurementForInstallation(installation.Id);
                if (measurement != null)
                {
                    measurements.Add(AirlyApiAdapter.FromApi(measurement, installation));
                }
            }
            
            // TODO async
            measurements = _measurementRepository.SaveAll(measurements);

            return new List<MeasurementDomain>(measurements);
        }
    }
}
