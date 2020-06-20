using System.Threading.Tasks;
using AirMonitor.Core.Domain.Installation;

namespace AirMonitor.Core.Application.Location
{
    public interface ILocationService
    {
        Task<LocationMapping> GetLocation();
    }
}
