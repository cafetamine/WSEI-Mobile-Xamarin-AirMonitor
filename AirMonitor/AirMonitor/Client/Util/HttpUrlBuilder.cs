using System;
using System.Collections.Generic;
using System.Globalization;
using System.Web;

namespace AirMonitor.Client.Util
{
    public static class HttpUrlBuilder
    {
        public static string GetUrl(bool isSecure,
                                    string hostAddress,
                                    string apiPrefix,
                                    string apiVersion,
                                    string apiPath,
                                    string query)
        {
            var apiUrl = $"{GetProtocol(isSecure)}://{hostAddress}/{GetApiPrefix(apiPrefix)}{apiVersion}/";
            var builder = new UriBuilder(apiUrl);
            builder.Port = -1;
            builder.Path += apiPath;
            builder.Query = query;
            
            return builder.ToString();
        }
        
        public static string GetBaseUrl(bool isSecure,
                                        string hostAddress,
                                        string apiPrefix,
                                        string apiVersion) 
            => $"{GetProtocol(isSecure)}://{hostAddress}/{GetApiPrefix(apiPrefix)}{apiVersion}/";

        public static string GetQuery(IDictionary<string, object> queryParams)
        {
            if (queryParams == null)
            {
                return null;
            }

            var query = HttpUtility.ParseQueryString(string.Empty);
            
            foreach (var arg in queryParams)
            {
                if (arg.Value is double number)
                {
                    query[arg.Key] = number.ToString(CultureInfo.InvariantCulture);
                }
                else
                {
                    query[arg.Key] = arg.Value?.ToString();
                }
            }
            return query.ToString();
        }

        private static string GetProtocol(bool isSecure) => isSecure ? "https" : "http";

        private static string GetApiPrefix(string apiPrefix) => string.IsNullOrEmpty(apiPrefix) ?  "" : $"{apiPrefix}/";
    }
}
