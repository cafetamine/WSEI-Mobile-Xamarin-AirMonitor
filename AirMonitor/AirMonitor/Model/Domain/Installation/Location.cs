using AirMonitor.Client.Airly.Api.Installation;

namespace AirMonitor.Model.Domain.Installation
{
    public class Location
    {
        public double Latitude { get; }
        public double Longitude { get; }

        private Location(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
        
        public static Location FromApi(ApiLocation location)
            => new Location(location.Latitude, location.Longitude);
    }
    
}
