using AirMonitor.Core.Domain.Installation;

namespace AirMonitor.Core.Application.Installation.Repository
{
    public interface ISponsorRepository
    {
        Sponsor FindById(long id);

        // TODO returning id?
        bool Save(Sponsor sponsor);
    }
}
