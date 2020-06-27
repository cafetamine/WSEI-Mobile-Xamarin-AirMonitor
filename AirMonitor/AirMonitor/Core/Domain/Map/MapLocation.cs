using AirMonitor.Core.Domain.Installation;
using MeasurementDomain = AirMonitor.Core.Domain.Measurement.Measurement;

namespace AirMonitor.Core.Domain.Map
{
    public class MapLocation
    {
        public string AddressDescription { get; }
        public string StatusDescription { get; }
        public LocationMapping Location { get; }

        public MapLocation(string addressDescription, string statusDescription, LocationMapping location)
        {
            AddressDescription = addressDescription;
            StatusDescription = statusDescription;
            Location = location;
        }
        
        public static MapLocation Create(MeasurementDomain measurement)
            => new MapLocation(measurement.Installation.Address.Description,
                               $"CAQI: " + measurement.CurrentDisplayValue,
                               measurement.Installation.Location);
    }
}
