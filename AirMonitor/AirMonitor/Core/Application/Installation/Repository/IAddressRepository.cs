using AirMonitor.Core.Domain.Installation;

namespace AirMonitor.Core.Application.Installation.Repository
{
    public interface IAddressRepository
    {
        Address FindById(long id);

        // TODO returning id?
        bool Save(Address address);
    }
}
