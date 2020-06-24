using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirMonitor.Client.Airly.Api.Installation;
using AirMonitor.Client.Airly.Api.Measurement;
using AirMonitor.Core.Domain.Installation;
using Newtonsoft.Json;

namespace AirMonitor.Client.Airly.Mock
{
    public class AirlyMockedClient : IAirlyClient
    {
        public async Task<List<ApiInstallation>> GetInstallations(LocationMapping location, double maxDistanceInKm = 3, int maxResults = -1)
        {
            var json = AirlyMockedInstallationsJson.Get();
            var installations = JsonConvert.DeserializeObject<IEnumerable<ApiInstallation>>(json);
            return installations.ToList();
        }

        public async Task<ApiMeasurement> GetMeasurementForInstallation(long installationId)
        {
            var json = AirlyApiMockedMeasurementJson.Get(installationId);
            var measurement = JsonConvert.DeserializeObject<ApiMeasurement>(json);
            return measurement;
        }
    }
}