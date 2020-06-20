using System;
using System.Collections.Generic;
using System.Linq;
using AirMonitor.Core.Application.Installation;
using AirMonitor.Core.Application.Installation.Repository;
using AirMonitor.Persistence.Entity.Installation;
using AirMonitor.Persistence.Utility;

namespace AirMonitor.Persistence.Repository.Installation
{
    public class InstallationRepository : IInstallationRepository
    {
        private IDbConnection _connection;
        private IAddressRepository _addressRepository;
        private ILocationRepository _locationRepository;
        private ISponsorRepository _sponsorRepository;

        public InstallationRepository(IDbConnection connection,
                                      IAddressRepository addressRepository,
                                      ILocationRepository locationRepository,
                                      ISponsorRepository sponsorRepository)
        {
            _connection = connection;
            _addressRepository = addressRepository;
            _locationRepository = locationRepository;
            _sponsorRepository = sponsorRepository;
        }
        
        public List<Core.Domain.Installation.Installation> FindAll()
        {
            var installations = _connection.Get.Table<InstallationEntity>();
            _connection.Get.Close();

            return installations.Select(FindReferences).ToList();
        }

        public Core.Domain.Installation.Installation FindById(long id)
        {
            var installation = _connection.Get.Get<InstallationEntity>(id);
            _connection.Get.Close();

            return FindReferences(installation ?? throw new ArgumentException($"Installation Id({id}) does not exist in database"));
        }

        public bool Save(Core.Domain.Installation.Installation installation)
        {
            if (SaveReferences(installation))
            {
                var successFlag = _connection.Get.Insert(InstallationEntity.FromDomain(installation));
                _connection.Get.Close();
                return successFlag > 0;
            }
            return false;
        }

        private Core.Domain.Installation.Installation FindReferences(InstallationEntity installation)
            => installation.toDomain(
                _locationRepository.FindById(installation.LocationRef) ?? throw new ArgumentException("Location from reference is null"),
                _addressRepository.FindById(installation.AddressRef),
                _sponsorRepository.FindById(installation.SponsorRef) ?? throw new ArgumentException("Sponsor from reference is null"));
        
        private bool SaveReferences(Core.Domain.Installation.Installation installation)
            => _locationRepository.Save(installation.Location) 
            && _addressRepository.Save(installation.Address)
            && _sponsorRepository.Save(installation.Sponsor);
    }
}
