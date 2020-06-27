using Newtonsoft.Json;

namespace AirMonitor.Client.Airly.Api.Installation
{
    public class ApiSponsor
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        [JsonProperty(PropertyName = "logo")]
        public string SponsorLogoUrl { get; set; }
        
        [JsonProperty(PropertyName = "link")]
        public string SponsorWebsiteUrl { get; set; }
        
        public string DisplayName { get; set; }
        
        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}
