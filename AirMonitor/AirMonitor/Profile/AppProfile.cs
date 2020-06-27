using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AirMonitor.Profile.Client;
using Newtonsoft.Json.Linq;

// TODO [ASAP'cos'SHAME] refactor
namespace AirMonitor.Profile
{
    public class AppProfile : IAppProfile
    {
        private const string ConfigFile = "AppProfileDev.json";

        private readonly ClientConfig _clientConfig;
        public IClientConfig ClientConfiguration => _clientConfig;

        private AppProfile(ClientConfig clientConfig)
        {
            _clientConfig = clientConfig;
        }

        public static async Task<IAppProfile> Load()
        {
            var assembly = Assembly.GetAssembly(typeof(App));
            var resourceNames = assembly.GetManifestResourceNames();
            var configName = resourceNames.FirstOrDefault(s => s.Contains(ConfigFile));

            using (var stream = assembly.GetManifestResourceStream(configName))
            {
                using (var reader = new StreamReader(stream))
                {
                    var json = await reader.ReadToEndAsync();
                    var dynamicJson = JObject.Parse(json);

                    return new AppProfile(ClientConfig.FromJson(dynamicJson));
                }
            }
        }

        public class ClientConfig : IClientConfig
        {
            private readonly IAirlyClientConfig _airlyConfig;
            public IAirlyClientConfig AirlyClientConfiguration => _airlyConfig;

            private ClientConfig(IAirlyClientConfig airlyConfig)
            {
                _airlyConfig = airlyConfig;
            }

            public static ClientConfig FromJson(JObject json)
                => new ClientConfig(AirlyClientConfig.FromJson(json));

            private class AirlyClientConfig : IAirlyClientConfig
            {
                private const string ClientKey = "client";
                private const string AirlyKey = "airly";
                
                private static readonly string IsSecureKey = $"{ClientKey}.{AirlyKey}.isSecure";
                private const bool IsSecureDefault = true;

                private static readonly string HostAddressKey = $"{ClientKey}.{AirlyKey}.HostAddress";
                private const string HostAddressDefault = "airapi.airly.eu";
                
                private static readonly string ApiPrefixKey = $"{ClientKey}.{AirlyKey}.ApiPrefix";
                private const string ApiPrefixDefault = null;
                
                private static readonly string ApiVersionKey = $"{ClientKey}.{AirlyKey}.ApiVersion";
                private const string ApiVersionDefault = "v2";
                
                private static readonly string ApiKeyKey = $"{ClientKey}.{AirlyKey}.ApiKey";
                private const string ApiKeyDefault = "";
                
                public bool IsSecure { get; }
                public string HostAddress { get; }
                public string ApiPrefix { get; }
                public string ApiVersion { get; }
                public string ApiKey { get; }

                private AirlyClientConfig(string hostAddress,
                                         bool isSecure,
                                         string apiVersion,
                                         string apiPrefix,
                                         string apiKey)
                {
                    HostAddress = hostAddress;
                    IsSecure = isSecure;
                    ApiVersion = apiVersion;
                    ApiPrefix = apiPrefix;
                    ApiKey = apiKey;
                }

                public static AirlyClientConfig FromJson(JObject json)
                    => new AirlyClientConfig(
                        isSecure:    Read(json, IsSecureKey,    IsSecureDefault),
                        hostAddress: Read(json, HostAddressKey, HostAddressDefault),
                        apiPrefix:   Read(json, ApiPrefixKey,   ApiPrefixDefault),
                        apiVersion:  Read(json, ApiVersionKey,  ApiVersionDefault),
                        apiKey:      Read(json, ApiKeyKey,      ApiKeyDefault));

                private static T Read<T>(JObject json, string path, T defaultValue)
                {
                    var value = json.SelectToken(path);
                    return value != null ? value.Value<T>() : defaultValue;
                }
            }
        }
    }
}
