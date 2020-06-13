namespace AirMonitor.Model.Api.Airly
{
    public class Measurement
    {
        public int CurrentDisplayValue { get; set; }
        public MeasurementItem Current { get; set; }
        public MeasurementItem[] History { get; set; }
        public MeasurementItem[] Forecast { get; set; }
        public ApiInstallation ApiInstallation { get; set; }
    }
}
