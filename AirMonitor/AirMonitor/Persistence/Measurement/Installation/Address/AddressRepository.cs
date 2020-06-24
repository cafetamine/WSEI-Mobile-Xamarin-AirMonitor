using System;
using AirMonitor.Core.Application.Installation.Repository;
using AirMonitor.Persistence.Utility;

namespace AirMonitor.Persistence.Measurement.Installation.Address
{
    public class AddressRepository : IAddressRepository
    {
        private readonly IDbConnection _connection;

        public AddressRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public Core.Domain.Installation.Address FindById(long id)
            => _connection.Get.Get<AddressEntity>(id)?.ToDomain();

        public Core.Domain.Installation.Address Save(Core.Domain.Installation.Address address)
        {
            if (_connection.Get.InsertOrReplace(AddressEntity.FromDomain(address)) > 0)
            {
                return address.WithId(_connection.LastIndex);
            }
            return null;
        }
    }
}
