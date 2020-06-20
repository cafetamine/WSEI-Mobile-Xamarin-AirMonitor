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

        public Installation(int id,
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
    }
}
