using System;
using System.Net.Http;
using AirMonitor.Client.Util;

namespace AirMonitor.Client.Airly.Client
{
    public class AirlyClientFactory
    {
        private static IAirlyClient CreateClient(IAirlyClientConfig config)
        {
            return new AirlyClient(config, CreateClientOptions(config), CreateHttpClient(config));
        }

        private static IAirlyClientOptions CreateClientOptions(IAirlyClientConfig config)
            => new AirlyClientOptions(config);

        private static HttpClient CreateHttpClient(IAirlyClientConfig config)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(HttpUrlBuilder.GetBaseUrl(config.IsSecure, config.HostAddress, config.ApiPrefix, config.ApiVersion));

            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("Accept-Encoding", "gzip");
            client.DefaultRequestHeaders.Add("apikey", config.ApiKey);

            return client;
        }
    }
}
