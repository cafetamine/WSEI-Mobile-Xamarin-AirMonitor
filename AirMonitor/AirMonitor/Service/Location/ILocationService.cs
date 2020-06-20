using System.Threading.Tasks;

namespace AirMonitor.Service.Location
{
    public interface ILocationService
    {
        Task<Xamarin.Essentials.Location> GetLocation();
    }
}
