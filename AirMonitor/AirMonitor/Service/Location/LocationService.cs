using System;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace AirMonitor.Service.Location
{
    public class LocationService : ILocationService
    {
        public async Task<Xamarin.Essentials.Location> GetLocation()
        {
            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync();

                if (location == null)
                {
                    var request = new GeolocationRequest(GeolocationAccuracy.Medium);
                    location = await Geolocation.GetLocationAsync(request);
                }
                if (location != null)
                {
                    System.Diagnostics.Debug.WriteLine($"Location(latitude={location.Latitude}, longitude={location.Longitude})");
                }
                return location;
            }
            // TODO handle no location -- ErrorPage
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
            return null;
        }
    }
}
