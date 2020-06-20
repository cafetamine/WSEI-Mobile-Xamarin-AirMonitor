using System;
using System.Collections.Generic;
using System.Linq;
using AirMonitor.Client.Airly.Api.Installation;
using AirMonitor.Client.Airly.Api.Measurement;
using AirMonitor.Core.Domain.Installation;
using AirMonitor.Core.Domain.Measurement;

// TODO should not be here, client should not be aware of core
namespace AirMonitor.Client.Airly
{
    public static class AirlyApiAdapter
    {
        public static Installation FromApi(ApiInstallation installation)
            => AirlyApiInstallationAdapter.FromApi(installation);
        
        public static IList<Installation> FromApi(IEnumerable<ApiInstallation> installations)
            => installations.Select(AirlyApiInstallationAdapter.FromApi).ToList();

        public static Measurement FromApi(ApiMeasurement measurement, Installation installation)
            => AirlyApiMeasurementAdapter.FromApi(measurement, installation);

        private static class AirlyApiInstallationAdapter
        {
            internal static Installation FromApi(ApiInstallation installation)
                => new Installation(installation.Id,
                                    AirlyApiLocationAdapter.FromApi(installation.Location),
                                    AirlyApiAddressAdapter.FromApi(installation.Address),
                                    installation.Elevation,
                                    AirlyApiSponsorAdapter.FromApi(installation.Sponsor),
                                    installation.IsAirlyInstallation);
            
            private static class AirlyApiLocationAdapter
            {
                internal static LocationMapping FromApi(ApiLocation location)
                    => new LocationMapping(location.Latitude, location.Longitude);
            }
        
            private static class AirlyApiAddressAdapter
            {
                internal static Address FromApi(ApiAddress address)
                    => new Address(address.Country,
                                   address.City,
                                   address.Street,
                                   address.Number,
                                   address.DisplayAddress1,
                                   address.DisplayAddress2);
            }

            private static class AirlyApiSponsorAdapter
            {
                public static Sponsor FromApi(ApiSponsor sponsor)
                    => new Sponsor(sponsor.Id,
                                   sponsor.Name,
                                   sponsor.Description,
                                   sponsor.SponsorLogoUrl,
                                   sponsor.SponsorWebsiteUrl,
                                   sponsor.DisplayName);
            }
        }

        private static class AirlyApiMeasurementAdapter
        {
            internal static Measurement FromApi(ApiMeasurement measurement, Installation installation)
                => new Measurement(CalculateCurrentDisplayValue(measurement),
                                   AirlyApiMeasurementItemAdapter.FromApi(measurement.Current),
                                   measurement.History.Select(AirlyApiMeasurementItemAdapter.FromApi).ToList(),
                                   measurement.Forecast.Select(AirlyApiMeasurementItemAdapter.FromApi).ToList(),
                                   installation);

            private static int CalculateCurrentDisplayValue(ApiMeasurement measurement)
                => (int) Math.Round(measurement.Current?.Indexes?.FirstOrDefault()?.Value ?? 0);

            private static class AirlyApiMeasurementItemAdapter
            {
                internal static MeasurementItem FromApi(ApiMeasurementItem item)
                    => new MeasurementItem(item.FromDateTime,
                                           item.TillDateTime,
                                           item.Values.Select(AirlyApiMeasurementValueAdapter.FromApi).ToList(),
                                           item.Indexes.Select(AirlyApiQualityIndexApiAdapter.FromApi).ToList(),
                                           item.Standards.Select(AirlyApiQualityStandardApiAdapter.FromApi).ToList());

                private static class AirlyApiMeasurementValueAdapter
                {
                    internal static MeasurementValue FromApi(ApiMeasurementValue value)
                        => new MeasurementValue(value.Name, value.Value);
                }

                private static class AirlyApiQualityIndexApiAdapter
                {
                    internal static AirQualityIndex FromApi(ApiAirQualityIndex index)
                        => new AirQualityIndex(index.Name,
                                               index.Value,
                                               index.Level,
                                               index.Description,
                                               index.Advice,
                                               index.Color);
                }

                private static class AirlyApiQualityStandardApiAdapter
                {
                    internal static AirQualityStandard FromApi(ApiAirQualityStandard standard)
                        => new AirQualityStandard(standard.Name,
                                                  standard.Pollutant,
                                                  standard.Limit,
                                                  standard.Percent,
                                                  standard.Averaging);
                }
            }
        }
    }
}
