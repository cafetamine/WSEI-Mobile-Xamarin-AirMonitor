using AirMonitor.Client.Airly.Api.Installation;

namespace AirMonitor.Model.Domain.Installation
{
    public class Installation
    {
        public int Id { get; }
        public Location Location { get; }
        public Address Address { get; }
        public double Elevation { get; }
        public Sponsor Sponsor { get; }
        public bool IsAirlyInstallation { get; }

        private Installation(int id,
                             Location location,
                             Address address,
                             double elevation,
                             Sponsor sponsor,
                             bool isAirlyInstallation)
        {
            Id = id;
            Location = location;
            Address = address;
            Elevation = elevation;
            Sponsor = sponsor;
            IsAirlyInstallation = isAirlyInstallation;
        }
        
        public static Installation FromApi(ApiInstallation installation)
            => new Installation(installation.Id,
                                Location.FromApi(installation.Location),
                                Address.FromApi(installation.Address),
                                installation.Elevation,
                                Sponsor.FromApi(installation.Sponsor),
                                installation.IsAirlyInstallation);
    }
}
