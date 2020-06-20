namespace AirMonitor.Core.Domain.Installation
{
    public class LocationMapping
    {
        public long? Id { get; }
        public double Latitude { get; }
        public double Longitude { get; }

        public LocationMapping(long? id, double latitude, double longitude)
        {
            Id = id;
            Latitude = latitude;
            Longitude = longitude;
        }
        
        public static LocationMapping Create(double latitude, double longitude)
            => new LocationMapping(null, latitude, longitude);
    }
}
