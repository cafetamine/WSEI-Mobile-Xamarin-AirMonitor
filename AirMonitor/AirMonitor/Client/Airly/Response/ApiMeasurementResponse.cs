using AirMonitor.Client.Airly.Response.Definition;

namespace AirMonitor.Client.Airly.Response
{
    public class ApiMeasurementResponse
    {
        public int CurrentDisplayValue { get; set; }
        public ApiMeasurementItem Current { get; set; }
        public ApiMeasurementItem[] History { get; set; }
        public ApiMeasurementItem[] Forecast { get; set; }
        public ApiInstallationResponse Installation { get; set; }
    }
}
