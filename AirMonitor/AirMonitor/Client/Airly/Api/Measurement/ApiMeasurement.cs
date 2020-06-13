using AirMonitor.Client.Airly.Api.Installation;

namespace AirMonitor.Client.Airly.Api.Measurement
{
    public class ApiMeasurement
    {
        public int CurrentDisplayValue { get; set; }
        public ApiMeasurementItem Current { get; set; }
        public ApiMeasurementItem[] History { get; set; }
        public ApiMeasurementItem[] Forecast { get; set; }
        public ApiInstallation Installation { get; set; }
    }
}
