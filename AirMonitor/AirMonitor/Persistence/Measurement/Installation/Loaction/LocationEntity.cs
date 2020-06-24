using AirMonitor.Core.Domain.Installation;
using SQLite;

namespace AirMonitor.Persistence.Measurement.Installation.Loaction
{
    public class LocationEntity
    {
        [PrimaryKey, AutoIncrement]
        public long? Id { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public LocationEntity()
        {
            // for serialization
        }

        private LocationEntity(long? id, double latitude, double longitude)
        {
            Id = id;
            Latitude = latitude;
            Longitude = longitude;
        }
        
        public LocationMapping ToDomain()
            => new LocationMapping(Id, Latitude, Longitude);
        
        public static LocationEntity FromDomain(LocationMapping location)
            => new LocationEntity(location.Id, location.Latitude, location.Longitude);
    }
}