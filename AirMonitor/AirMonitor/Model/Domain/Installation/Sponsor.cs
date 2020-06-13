using AirMonitor.Client.Airly.Api.Installation;

namespace AirMonitor.Model.Domain.Installation
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

        private Sponsor(long id,
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
        
        public static Sponsor FromApi(ApiSponsor sponsor)
            => new Sponsor(sponsor.Id,
                           sponsor.Name,
                           sponsor.Description,
                           sponsor.SponsorLogoUrl,
                           sponsor.SponsorWebsiteUrl,
                           sponsor.DisplayName);
    }
}
