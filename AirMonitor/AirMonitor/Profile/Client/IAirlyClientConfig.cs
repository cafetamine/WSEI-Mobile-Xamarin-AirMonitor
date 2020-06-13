namespace AirMonitor.Profile.Client
{
    public interface IAirlyClientConfig
    {
        bool IsSecure { get; }
        string HostAddress { get; }
        string ApiPrefix { get; }
        string ApiVersion { get; }
        string ApiKey { get; }
    }
}
