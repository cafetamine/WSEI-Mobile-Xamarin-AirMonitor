using System;
using System.Threading.Tasks;
using AirMonitor.Core.Application.Location;
using AirMonitor.Core.Domain.Installation;
using Xamarin.Essentials;

namespace AirMonitor.Infrastructure.Location
{
    public class LocationService : ILocationService
    {
        public async Task<LocationMapping> GetLocation()
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
                    return new LocationMapping(location.Latitude, location.Longitude); 
                }

                return null;
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
