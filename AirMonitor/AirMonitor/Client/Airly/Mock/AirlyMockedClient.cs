using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AirMonitor.Client.Airly.Api.Installation;
using AirMonitor.Client.Airly.Api.Measurement;
using AirMonitor.Core.Domain.Installation;
using Newtonsoft.Json;

namespace AirMonitor.Client.Airly.Mock
{
    public class AirlyMockedClient : IAirlyClient
    {
        public async Task<IEnumerable<ApiInstallation>> GetInstallations(LocationMapping location, double maxDistanceInKm = 3, int maxResults = -1)
        {
            Console.WriteLine("XXX_I");
            var json = AirlyMockedInstallationsJson.Get();
            var installations = JsonConvert.DeserializeObject<IEnumerable<ApiInstallation>>(json);
            Console.WriteLine(installations);
            return installations;
        }

        public async Task<ApiMeasurement> GetMeasurementForInstallation(int installationId)
        {
            Console.WriteLine("XXX_M");
            var json = AirlyApiMockedMeasurementJson.Get(installationId);
            var measurement = JsonConvert.DeserializeObject<ApiMeasurement>(json);
            Console.WriteLine(measurement);
            return measurement;
        }
    }
}