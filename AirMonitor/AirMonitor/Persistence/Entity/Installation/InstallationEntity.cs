using System;
using AirMonitor.Core.Domain.Installation;
using SQLite;

namespace AirMonitor.Persistence.Entity.Installation
{
    public class InstallationEntity
    {
        [PrimaryKey]
        public int Id { get; set; }
        public long LocationRef { get; set; }
        public long AddressRef { get; set; }
        public double Elevation { get; set; }
        public long SponsorRef { get; set; }
        public bool IsAirlyInstallation { get; set; }

        public InstallationEntity()
        {
            // for serialization
        }
        
        private InstallationEntity(int id,
                                   long locationRef,
                                   long addressRef,
                                   double elevation,
                                   long sponsorRef,
                                   bool isAirlyInstallation)
        {
            Id = id;
            LocationRef = locationRef;
            AddressRef = addressRef;
            Elevation = elevation;
            SponsorRef = sponsorRef;
            IsAirlyInstallation = isAirlyInstallation;
        }

        public Core.Domain.Installation.Installation toDomain(LocationMapping location,
                                                              Address address,
                                                              Sponsor sponsor)
            => new Core.Domain.Installation.Installation(Id,
                                                         location,
                                                         address,
                                                         Elevation,
                                                         sponsor,
                                                         IsAirlyInstallation);

        public static InstallationEntity FromDomain(Core.Domain.Installation.Installation installation)
            => new InstallationEntity(installation.Id,
                                      installation.Location.Id ?? throw new ArgumentException("Location reference set to null"),
                                      installation.Address.Id ?? throw new ArgumentException("Address reference set to null"),
                                      installation.Elevation,
                                      installation.Sponsor.Id, // sponsor id is set from airly api
                                      installation.IsAirlyInstallation);
    }
}