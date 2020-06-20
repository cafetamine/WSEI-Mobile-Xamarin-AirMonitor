using AirMonitor.Core.Domain.Installation;

namespace AirMonitor.Core.Application.Installation
{
    public interface ILocationRepository
    {
        LocationMapping FindById(long id);

        // TODO returning id?
        bool Save(LocationMapping location);
    }
}