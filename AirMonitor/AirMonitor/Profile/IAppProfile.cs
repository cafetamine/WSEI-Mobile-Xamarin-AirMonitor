using AirMonitor.Profile.Client;

namespace AirMonitor.Profile
{
    public interface IAppProfile
    {
        IClientConfig ClientConfiguration { get; }
    }
}
