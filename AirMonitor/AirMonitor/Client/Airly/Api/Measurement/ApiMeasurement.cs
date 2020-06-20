using AirMonitor.Client.Airly.Api.Installation;

namespace AirMonitor.Client.Airly.Api.Measurement
{
    public class ApiMeasurement
    {
        public ApiMeasurementItem Current { get; set; }
        public ApiMeasurementItem[] History { get; set; }
        public ApiMeasurementItem[] Forecast { get; set; }
    }
}
