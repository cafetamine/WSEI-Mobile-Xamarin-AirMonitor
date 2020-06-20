using AirMonitor.Core.Domain.Measurement;
using SQLite;

namespace AirMonitor.Persistence.Entity.Measurement
{
    public class AirQualityStandardEntity
    {
        [PrimaryKey, AutoIncrement]
        public long? Id { get; set; }
        public string Name { get; set; }
        public string Pollutant { get; set; }
        public double Limit { get; set; }
        public double Percent { get; set; }
        public string Averaging { get; set; }
        
        

        private AirQualityStandardEntity(long? id,
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
        
        public AirQualityStandard ToDomain()
            => new AirQualityStandard(Id, Name, Pollutant, Limit, Percent, Averaging);

        public static AirQualityStandardEntity FromDomain(AirQualityStandard standard)
            => new AirQualityStandardEntity(standard.Id,
                                            standard.Name,
                                            standard.Pollutant,
                                            standard.Limit,
                                            standard.Percent,
                                            standard.Averaging);
    }
}
