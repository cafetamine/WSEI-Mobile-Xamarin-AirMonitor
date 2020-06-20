namespace AirMonitor.Core.Domain.Installation
{
    public class Sponsor
    {
        public long Id { get; }
        public string Name { get; }
        public string Description { get; }
        // TODO Picasso?
        public string SponsorLogoUrl { get; }
        public string SponsorWebsiteUrl { get; }
        public string DisplayName { get; }

        public Sponsor(long id,
                       string name,
                       string description,
                       string sponsorLogoUrl,
                       string sponsorWebsiteUrl,
                       string displayName)
        {
            Id = id;
            Name = name;
            Description = description;
            SponsorLogoUrl = sponsorLogoUrl;
            SponsorWebsiteUrl = sponsorWebsiteUrl;
            DisplayName = displayName;
        }
    }
}
