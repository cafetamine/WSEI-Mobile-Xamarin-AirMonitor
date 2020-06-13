namespace AirMonitor.Client.Airly.Api.Measurement
{
    public class ApiAirQualityStandard
    {
        public string Name { get; set; }
        public string Pollutant { get; set; }
        public double Limit { get; set; }
        public double Percent { get; set; }
        public string Averaging { get; set; }
    }
}
