namespace AirMonitor.Core.Domain.Installation
{
    public class LocationMapping
    {
        public long? Id { get; private set; }
        public double Latitude { get; }
        public double Longitude { get; }

        public LocationMapping(long? id, double latitude, double longitude)
        {
            Id = id;
            Latitude = latitude;
            Longitude = longitude;
        }

        public LocationMapping WithId(long id)
        {
            Id = id;
            return this;
        }

        public static LocationMapping Create(double latitude, double longitude)
            => new LocationMapping(null, latitude, longitude);
    }
}
