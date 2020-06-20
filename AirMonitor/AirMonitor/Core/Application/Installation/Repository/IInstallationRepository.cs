using System.Collections.Generic;

namespace AirMonitor.Core.Application.Installation.Repository
{
    public interface IInstallationRepository
    {
        List<Domain.Installation.Installation> FindAll();

        Domain.Installation.Installation FindById(long id);

        // TODO returning id?
        bool Save(Domain.Installation.Installation installation);
    }
}
