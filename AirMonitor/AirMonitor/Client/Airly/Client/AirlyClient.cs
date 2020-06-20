using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using AirMonitor.Client.Airly.Api.Installation;
using AirMonitor.Client.Airly.Api.Measurement;
using AirMonitor.Client.Util;
using AirMonitor.Model.Domain.Installation;
using AirMonitor.Profile.Client;
using Newtonsoft.Json;

namespace AirMonitor.Client.Airly.Client
{
    public class AirlyClient : IAirlyClient
    {
        private readonly IAirlyClientConfig _config;
        private readonly AirlyClientOptions _options;
        private readonly HttpClient _httpClient;

        public AirlyClient(IAirlyClientConfig config, AirlyClientOptions options, HttpClient httpClient)
        {
            _config = config;
            _options = options;
            _httpClient = httpClient; 
        }

        public async Task<IEnumerable<ApiInstallation>> GetInstallations(LocationMapping location, double maxDistanceInKm = 3, int maxResults = -1)
        {
            if (location == null)
            {
                System.Diagnostics.Debug.WriteLine("No location data.");
                return null;
            }

            var query = HttpUrlBuilder.GetQuery(new Dictionary<string, object>
            {
                { "lat", location.Latitude },
                { "lng", location.Longitude },
                { "maxDistanceKM", maxDistanceInKm },
                { "maxResults", maxResults }
            });
            var url = _options.GetUrl(AirlyApiClientFunction.GetInstallations, query);
            var response = await GetHttpResponseAsync<IEnumerable<ApiInstallation>>(url);
            return response;
        }

        public async Task<ApiMeasurement> GetMeasurementForInstallation(ApiInstallation installation)
        {
            if (installation == null)
            {
                System.Diagnostics.Debug.WriteLine("Installation is null.");
                return null;
            }

            var query = HttpUrlBuilder.GetQuery(new Dictionary<string, object>
            {
                { "installationId", installation.Id }
            });
            var url = _options.GetUrl(AirlyApiClientFunction.GetMeasurements, query);

            var response = await GetHttpResponseAsync<ApiMeasurement>(url);
            
            return response;
        }

        private async Task<T> GetHttpResponseAsync<T>(string url)
        {
            try
            {
                var response = await _httpClient.GetAsync(url);

                if (response.Headers.TryGetValues("X-RateLimit-Limit-day", out var dayLimit) &&
                    response.Headers.TryGetValues("X-RateLimit-Remaining-day", out var dayLimitRemaining))
                {
                    System.Diagnostics.Debug.WriteLine($"Day limit: {dayLimit?.FirstOrDefault()}, remaining: {dayLimitRemaining?.FirstOrDefault()}");
                }

                switch ((int)response.StatusCode)
                {
                    // TODO handle 301 and 404
                    case 200:
                        var content = await response.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<T>(content);
                        return result;
                    case 429: // too many requests
                        System.Diagnostics.Debug.WriteLine("Too many requests");
                        break;
                    default:
                        var errorContent = await response.Content.ReadAsStringAsync();
                        System.Diagnostics.Debug.WriteLine($"Response error: {errorContent}");
                        return default;
                }
            }
            catch (JsonReaderException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
            catch (WebException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }

            return default;
        }
    }
}
