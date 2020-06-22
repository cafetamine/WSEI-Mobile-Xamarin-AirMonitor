using AirMonitor.Core.Application.Installation.Repository;
using AirMonitor.Core.Domain.Installation;
using AirMonitor.Persistence.Entity.Installation;
using AirMonitor.Persistence.Utility;

namespace AirMonitor.Persistence.Repository.Installation
{
    public class LocationRepository : ILocationRepository
    {
        private readonly IDbConnection _connection;

        public LocationRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public LocationMapping FindById(long id)
            => _connection.Get.Get<LocationEntity>(id)?.ToDomain();

        public LocationMapping Save(LocationMapping location)
        {
            if (_connection.Get.Insert(LocationEntity.FromDomain(location)) > 0)
            {
                return location.WithId(_connection.LastIndex);
            }
            return null;
        }
    }
}
