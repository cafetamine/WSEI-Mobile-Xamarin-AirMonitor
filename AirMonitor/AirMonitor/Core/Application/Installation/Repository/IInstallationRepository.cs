using System.Collections.Generic;
using InstallationDomain = AirMonitor.Core.Domain.Installation.Installation;

namespace AirMonitor.Core.Application.Installation.Repository
{
    public interface IInstallationRepository
    {
        InstallationDomain FindById(long id);

        List<InstallationDomain> FindAll();

        InstallationDomain Save(InstallationDomain installation);

        List<InstallationDomain> SaveAll(List<InstallationDomain> installations);
    }
}
