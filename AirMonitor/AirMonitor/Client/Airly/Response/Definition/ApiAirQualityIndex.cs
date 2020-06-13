namespace AirMonitor.Client.Airly.Response.Definition
{
    public class ApiAirQualityIndex
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public string Level { get; set; }
        public string Description { get; set; }
        public string Advice { get; set; }
        public string Color { get; set; }
    }
}
