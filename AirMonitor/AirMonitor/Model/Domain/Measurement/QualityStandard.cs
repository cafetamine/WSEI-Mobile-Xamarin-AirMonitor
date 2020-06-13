using AirMonitor.Client.Airly.Api.Measurement;

namespace AirMonitor.Model.Domain.Measurement
{
    public class AirQualityStandard
    {
        public string Name { get; }
        public string Pollutant { get; }
        public double Limit { get; }
        public double Percent { get; }
        public string Averaging { get; }

        private AirQualityStandard(string name,
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
        
        public static AirQualityStandard FromApi(ApiAirQualityStandard standard)
            => new AirQualityStandard(standard.Name,
                                      standard.Pollutant,
                                      standard.Limit,
                                      standard.Percent,
                                      standard.Averaging);
    }
}
