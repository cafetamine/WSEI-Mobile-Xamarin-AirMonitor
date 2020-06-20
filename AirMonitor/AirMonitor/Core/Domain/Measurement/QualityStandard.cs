namespace AirMonitor.Core.Domain.Measurement
{
    public class AirQualityStandard
    {
        public long? Id { get; }
        public string Name { get; }
        public string Pollutant { get; }
        public double Limit { get; }
        public double Percent { get; }
        public string Averaging { get; }

        public AirQualityStandard(long? id,
                                  string name,
                                  string pollutant,
                                  double limit,
                                  double percent,
                                  string averaging)
        {
            Id = id;
            Name = name;
            Pollutant = pollutant;
            Limit = limit;
            Percent = percent;
            Averaging = averaging;
        }

        public static AirQualityStandard Create(string name,
                                                string pollutant,
                                                double limit,
                                                double percent,
                                                string averaging)
            => new AirQualityStandard(null, name, pollutant, limit, percent, averaging);
    }
}
