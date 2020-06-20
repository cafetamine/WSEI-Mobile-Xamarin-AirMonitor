namespace AirMonitor.Profile.Client
{
    public interface IClientConfig
    {
        IAirlyClientConfig AirlyClientConfiguration { get; }
    }
}
