using AirMonitor.Core.Domain.Measurement.Item;
using SQLite;

namespace AirMonitor.Persistence.Measurement.Item.AirQuality
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
        public long MeasurementItemRef { get; set; }

        public AirQualityStandardEntity()
        {
            // for serialization
        }

        private AirQualityStandardEntity(long? id,
                                         string name,
                                         string pollutant,
                                         double limit,
                                         double percent,
                                         string averaging,
                                         long measurementItemRef)
        {
            Id = id;
            Name = name;
            Pollutant = pollutant;
            Limit = limit;
            Percent = percent;
            Averaging = averaging;
            MeasurementItemRef = measurementItemRef;
        }

        public AirQualityStandard ToDomain()
            => new AirQualityStandard(Id, Name, Pollutant, Limit, Percent, Averaging);

        public static AirQualityStandardEntity FromDomain(AirQualityStandard standard, long measurementItemRef)
            => new AirQualityStandardEntity(standard.Id,
                                            standard.Name,
                                            standard.Pollutant,
                                            standard.Limit,
                                            standard.Percent,
                                            standard.Averaging,
                                            measurementItemRef);
    }
}
