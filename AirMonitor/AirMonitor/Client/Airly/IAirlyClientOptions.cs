namespace AirMonitor.Client.Airly
{
    public interface IAirlyClientOptions
    {
        string GetUrl(AirlyApiClientFunction function, string query);
    }
}