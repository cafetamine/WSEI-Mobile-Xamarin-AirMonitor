using Newtonsoft.Json;

namespace AirMonitor.Client.Airly.Api.Installation
{
    public struct ApiAddress
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string DisplayAddress1 { get; set; }
        public string DisplayAddress2 { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}
