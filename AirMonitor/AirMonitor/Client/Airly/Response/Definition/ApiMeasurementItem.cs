using System;

namespace AirMonitor.Client.Airly.Response.Definition
{
    public class ApiMeasurementItem
    {
        public DateTime FromDateTime { get; set; }
        public DateTime TillDateTime { get; set; }
        public ApiMeasurementValue[] Values { get; set; }
        public ApiAirQualityIndex[] Indexes { get; set; }
        public ApiAirQualityStandard[] Standards { get; set; }
    }
}
