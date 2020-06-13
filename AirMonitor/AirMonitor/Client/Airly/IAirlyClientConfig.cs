namespace AirMonitor.Client.Airly
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
