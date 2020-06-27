using Xamarin.Forms.Maps;
using MeasurementDomain = AirMonitor.Core.Domain.Measurement.Measurement;

namespace AirMonitor.Core.Domain.Map
{
    public class MapLocation
    {
        public string AddressDescription { get; }
        public string StatusDescription { get; }
        // TODO Core should not be aware of Xamarin.Forms.Maps
        public Position Position { get; }

        public MapLocation(string addressDescription, string statusDescription, Position position)
        {
            AddressDescription = addressDescription;
            StatusDescription = statusDescription;
            Position = position;
        }
        
        public static MapLocation Create(MeasurementDomain measurement)
            => new MapLocation(measurement.Installation.Address.Description,
                               $"CAQI: " + measurement.CurrentDisplayValue,
                               new Position(measurement.Installation.Location.Latitude, measurement.Installation.Location.Longitude));
    }
}
