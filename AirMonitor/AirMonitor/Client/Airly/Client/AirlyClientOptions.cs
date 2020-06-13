using AirMonitor.Client.Util;
using AirMonitor.Profile.Client;

namespace AirMonitor.Client.Airly.Client
{
    public class AirlyClientOptions : IAirlyClientOptions
    {
        private readonly IAirlyClientConfig _config;

        public AirlyClientOptions(IAirlyClientConfig config)
        {
            _config = config;
        }

        public string GetUrl(AirlyApiClientFunction function, string query)
            => HttpUrlBuilder.GetUrl(_config.IsSecure, _config.HostAddress, _config.ApiPrefix, _config.ApiVersion, function.ApiPath, query);
    }
}
