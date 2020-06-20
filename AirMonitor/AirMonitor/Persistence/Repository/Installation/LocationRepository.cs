using AirMonitor.Core.Application.Installation;
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
        {
            var location = _connection.Get.Get<LocationEntity>(id);
            _connection.Get.Close();
            return location?.ToDomain();
        }

        public bool Save(LocationMapping location)
        {
            var successFlag = _connection.Get.Insert(LocationEntity.FromDomain(location));
            _connection.Get.Close();
            return successFlag > 0;
        }
    }
}
