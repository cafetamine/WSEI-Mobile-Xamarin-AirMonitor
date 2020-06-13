using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AirMonitor.Client.Airly;
using Newtonsoft.Json.Linq;

// TODO [ASAP'cos'SHAME] refactor
namespace AirMonitor
{
    public class AppProfile
    {
        private const string ConfigFile = "AppProfile.json";

        private const string ClientKey = "client";

        private readonly ClientConfig _clientConfig;
        private ClientConfig ClientConfiguration => _clientConfig;

        private AppProfile(ClientConfig clientConfig)
        {
            _clientConfig = clientConfig;
        }

        public static async Task<AppProfile> Load()
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

        public class ClientConfig
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
                
                public const string IsSecureKey = "isSecure";
                public const bool IsSecureDefault = true;

                public const string HostAddressKey = "HostAddress";
                public const string HostAddressDefault = "airapi.airly.eu";
                
                public const string ApiPrefixKey = "ApiPrefix";
                public const string ApiPrefixDefault = null;
                
                public const string ApiVersionKey = "ApiVersion";
                public const string ApiVersionDefault = "v2";
                
                public const string ApiKeyKey = "ApiKey";
                public const string ApiKeyDefault = "";
                
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
                        isSecure:    ReadBool(  json, IsSecureKey,    IsSecureDefault),
                        hostAddress: ReadString(json, HostAddressKey, HostAddressDefault),
                        apiPrefix:   ReadString(json, ApiPrefixKey,   ApiPrefixDefault),
                        apiVersion:  ReadString(json, ApiVersionKey,  ApiVersionDefault),
                        apiKey:      ReadString(json, ApiKeyKey,      ApiKeyDefault));

                private static string ReadString(JObject json, string key, string defaultValue) 
                    => json.ContainsKey(key) ? json[ClientKey][AirlyKey][key].Value<string>() : defaultValue;
        
                private static bool ReadBool(JObject json, string key, bool defaultValue = false) 
                    => json.ContainsKey(key) ? json[ClientKey][AirlyKey][key].Value<bool>() : defaultValue;
            }
        }
    }
}
