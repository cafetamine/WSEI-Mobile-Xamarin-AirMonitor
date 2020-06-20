using System.Threading.Tasks;
using AirMonitor.Model.Domain.Installation;

namespace AirMonitor.Service.Location
{
    public interface ILocationService
    {
        Task<LocationMapping> GetLocation();
    }
}
