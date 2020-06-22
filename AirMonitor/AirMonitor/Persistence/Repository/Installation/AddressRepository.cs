using AirMonitor.Core.Application.Installation.Repository;
using AirMonitor.Core.Domain.Installation;
using AirMonitor.Persistence.Entity.Installation;
using AirMonitor.Persistence.Utility;

namespace AirMonitor.Persistence.Repository.Installation
{
    public class AddressRepository : IAddressRepository
    {
        private readonly IDbConnection _connection;

        public AddressRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public Address FindById(long id)
            => _connection.Get.Get<AddressEntity>(id)?.ToDomain();

        public Address Save(Address address)
        {
            if (_connection.Get.InsertOrReplace(AddressEntity.FromDomain(address)) > 0)
            {
                return address.WithId(_connection.LastIndex);
            }
            return null;
        }
    }
}
