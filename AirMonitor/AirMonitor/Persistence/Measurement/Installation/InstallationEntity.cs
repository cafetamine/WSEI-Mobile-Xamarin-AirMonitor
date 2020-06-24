using System;
using AirMonitor.Core.Domain.Installation;
using SQLite;
using InstallationDomain = AirMonitor.Core.Domain.Installation.Installation;

namespace AirMonitor.Persistence.Measurement.Installation
{
    public class InstallationEntity
    {
        [PrimaryKey]
        public long Id { get; set; }
        public double Elevation { get; set; }
        public bool IsAirlyInstallation { get; set; }
        public long LocationRef { get; set; }
        public long AddressRef { get; set; }
        public long SponsorRef { get; set; }
        

        public InstallationEntity()
        {
            // for serialization
        }
        
        private InstallationEntity(long id,
                                   double elevation,
                                   bool isAirlyInstallation,
                                   long locationRef,
                                   long addressRef,
                                   long sponsorRef)
        {
            Id = id;
            Elevation = elevation;
            IsAirlyInstallation = isAirlyInstallation;
            LocationRef = locationRef;
            AddressRef = addressRef;
            SponsorRef = sponsorRef;
            
        }

        public InstallationDomain toDomain(LocationMapping location,
                                           Core.Domain.Installation.Address address,
                                           Core.Domain.Installation.Sponsor sponsor)
            => new InstallationDomain(Id,
                                      Elevation,
                                      IsAirlyInstallation,
                                      location,
                                      address,
                                      sponsor);

        public static InstallationEntity FromDomain(InstallationDomain installation)
            => new InstallationEntity(installation.Id,
                                      installation.Elevation,
                                      installation.IsAirlyInstallation,
                                      installation.Location.Id ?? throw new ArgumentException("Location reference set to null"),
                                      installation.Address.Id ?? throw new ArgumentException("Address reference set to null"),
                                      installation.Sponsor.Id);
    }
}
