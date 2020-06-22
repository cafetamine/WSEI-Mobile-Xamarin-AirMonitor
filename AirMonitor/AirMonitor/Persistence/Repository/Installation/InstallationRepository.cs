using System;
using System.Collections.Generic;
using System.Linq;
using AirMonitor.Core.Application.Installation.Repository;
using AirMonitor.Persistence.Entity.Installation;
using AirMonitor.Persistence.Utility;
using CommonServiceLocator;
using InstallationDomain = AirMonitor.Core.Domain.Installation.Installation;

namespace AirMonitor.Persistence.Repository.Installation
{
    public class InstallationRepository : IInstallationRepository
    {
        private readonly IDbConnection _connection;
        private readonly ILocationRepository _locationRepository;
        private readonly IAddressRepository _addressRepository;
        private readonly ISponsorRepository _sponsorRepository;

        public InstallationRepository(IDbConnection connection,
                                      ILocationRepository locationRepository,
                                      IAddressRepository addressRepository,
                                      ISponsorRepository sponsorRepository)
        {
            _connection = connection;
            _locationRepository = locationRepository;
            _addressRepository = addressRepository;
            _sponsorRepository = sponsorRepository;
        }

        public InstallationDomain FindById(long id)
            => FindReferences(_connection.Get.Get<InstallationEntity>(id));

        public List<InstallationDomain> FindAll()
            => _connection.Get.Table<InstallationEntity>().Select(FindReferences).ToList();
            

        public InstallationDomain Save(InstallationDomain installation)
        {
            installation = installation.WithLocation(_locationRepository.Save(installation.Location))
                                       .WithAddress(_addressRepository.Save(installation.Address))
                                       .WithSponsor(_sponsorRepository.Save(installation.Sponsor));
            return _connection.Get.InsertOrReplace(InstallationEntity.FromDomain(installation)) > 0 ? installation : null;
        }

        public List<InstallationDomain> SaveAll(List<InstallationDomain> installations)
            => installations.Select(Save).ToList();

        private InstallationDomain FindReferences(InstallationEntity installation)
        {
            if (installation == null)
            {
                return null;
            }
            var location = _locationRepository.FindById(installation.LocationRef) ?? throw new ArgumentException("Location is null");
            var address = _addressRepository.FindById(installation.AddressRef)    ?? throw new ArgumentException("Address is null");
            var sponsor = _sponsorRepository.FindById(installation.SponsorRef)    ?? throw new ActivationException("Sponsor is null");

            return installation.toDomain(location, address, sponsor);
        }
    }
}
