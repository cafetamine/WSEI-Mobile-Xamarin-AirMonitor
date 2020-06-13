using Newtonsoft.Json;

namespace AirMonitor.Client.Airly.Api.Installation
{
    public class ApiInstallation
    {
        public int Id { get; set; }
        public ApiLocation Location { get; set; }
        public ApiAddress Address { get; set; }
        public double Elevation { get; set; }
        public ApiSponsor Sponsor { get; set; }

        [JsonProperty(PropertyName = "airly")]
        public bool IsAirlyInstallation { get; set; }
        
        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}
