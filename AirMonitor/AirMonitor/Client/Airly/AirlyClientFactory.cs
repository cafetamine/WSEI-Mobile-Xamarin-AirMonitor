using System;
using System.Net.Http;
using AirMonitor.Client.Airly.Client;
using AirMonitor.Client.Util;
using AirMonitor.Profile.Client;

namespace AirMonitor.Client.Airly
{
    public static class AirlyClientFactory
    {
        public static IAirlyClient CreateClient(IAirlyClientConfig config)
            => new AirlyClient(config, CreateClientOptions(config), CreateHttpClient(config));

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
