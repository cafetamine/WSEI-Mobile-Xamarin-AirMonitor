using AirMonitor.Core.Domain.Installation;
using SQLite;

namespace AirMonitor.Persistence.Entity.Installation
{
    public class SponsorEntity
    {
        [PrimaryKey]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SponsorLogoUrl { get; set; }
        public string SponsorWebsiteUrl { get; set; }
        public string DisplayName { get; set; }

        public SponsorEntity()
        {
            // for serialization
        }

        private SponsorEntity(long id,
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
        
        public Sponsor ToDomain()
            => new Sponsor(Id,
                           Name, 
                           Description, 
                           SponsorLogoUrl,
                           SponsorWebsiteUrl,
                           DisplayName);

        public static SponsorEntity FromDomain(Sponsor sponsor)
            => new SponsorEntity(sponsor.Id,
                                 sponsor.Name,
                                 sponsor.Description,
                                 sponsor.SponsorLogoUrl,
                                 sponsor.SponsorWebsiteUrl,
                                 sponsor.DisplayName);
    }
}
