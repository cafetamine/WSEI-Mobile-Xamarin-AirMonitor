namespace AirMonitor.Core.Domain.Installation
{
    public class Installation
    {
        public long Id { get; }
        public double Elevation { get; }
        public bool IsAirlyInstallation { get; }
        public LocationMapping Location { get; private set; }
        public Address Address { get; private set; }
        public Sponsor Sponsor { get; private set; }
        

        public Installation(long id,
                            double elevation,
                            bool isAirlyInstallation,
                            LocationMapping location,
                            Address address,
                            Sponsor sponsor)
        {
            Id = id;
            Location = location;
            Address = address;
            Elevation = elevation;
            Sponsor = sponsor;
            IsAirlyInstallation = isAirlyInstallation;
        }

        public Installation WithLocation(LocationMapping location)
        {
            Location = location;
            return this;
        }
        
        public Installation WithAddress(Address address)
        {
            Address = address;
            return this;
        }
        
        public Installation WithSponsor(Sponsor sponsor)
        {
            Sponsor = sponsor;
            return this;
        }

        public static Installation Create(long id,
                                          double elevation,
                                          bool isAirlyInstallation,
                                          LocationMapping location,
                                          Address address,
                                          Sponsor sponsor)
            => new Installation(id, elevation, isAirlyInstallation, location, address,  sponsor);
    }
}
