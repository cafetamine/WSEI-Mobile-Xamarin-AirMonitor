namespace AirMonitor.Model.Domain.Measurement
{
    public class AirQualityStandard
    {
        public string Name { get; }
        public string Pollutant { get; }
        public double Limit { get; }
        public double Percent { get; }
        public string Averaging { get; }

        public AirQualityStandard(string name,
                                  string pollutant,
                                  double limit,
                                  double percent,
                                  string averaging)
        {
            Name = name;
            Pollutant = pollutant;
            Limit = limit;
            Percent = percent;
            Averaging = averaging;
        }
    }
}
