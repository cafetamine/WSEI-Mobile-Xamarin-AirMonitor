using Newtonsoft.Json;

namespace AirMonitor.Client.Airly.Api.Installation
{
    public class ApiLocation
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        
        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}
