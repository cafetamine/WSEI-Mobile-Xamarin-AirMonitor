using AirMonitor.Client.Airly.Response.Definition;
using Newtonsoft.Json;
using Xamarin.Essentials;

namespace AirMonitor.Client.Airly.Response
{
    public class ApiInstallationResponse
    {
        public string Id { get; set; }
        public Location Location { get; set; }
        public ApiAddress Address { get; set; }
        public double Elevation { get; set; }

        [JsonProperty(PropertyName = "airly")]
        public bool IsAirlyInstallation { get; set; }
    }
}
