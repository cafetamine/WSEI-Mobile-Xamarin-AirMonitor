namespace AirMonitor.Model.Domain.Installation
{
    public class LocationMapping
    {
        public double Latitude { get; }
        public double Longitude { get; }

        public LocationMapping(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}
