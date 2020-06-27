using AirMonitor.Core.Domain.Installation;

namespace AirMonitor.Core.Application.Installation.Repository
{
    public interface ILocationRepository
    {
        LocationMapping FindById(long id);

        LocationMapping Save(LocationMapping location);
    }
}
