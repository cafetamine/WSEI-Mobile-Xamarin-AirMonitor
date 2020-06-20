using AirMonitor.Core.Application.Installation;
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
        {
            var address = _connection.Get.Get<AddressEntity>(id);
            _connection.Get.Close();
            return address.ToDomain();
        }

        public bool Save(Address address)
        {
            var successFlag = _connection.Get.Insert(AddressEntity.FromDomain(address));
            _connection.Get.Close();
            return successFlag > 0;
        }
    }
}
