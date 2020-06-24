using AirMonitor.Core.Domain.Measurement.Item;

namespace AirMonitor.Persistence.Measurement.Item.AirQuality
{
    public class AirQualityIndexEntity
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public double? Value { get; set; }
        public string Level { get; set; }
        public string Description { get; set; }
        public string Advice { get; set; }
        public string Color { get; set;  }
        public long MeasurementItemRef { get; set; }

        public AirQualityIndexEntity()
        {
            // for serialization
        }

        private AirQualityIndexEntity(long? id,
                                     string name,
                                     double? value,
                                     string level,
                                     string description,
                                     string advice,
                                     string color,
                                     long measurementItemRef)
        {
            Id = id;
            Name = name;
            Value = value;
            Level = level;
            Description = description;
            Advice = advice;
            Color = color;
            MeasurementItemRef = measurementItemRef;
        }

        public AirQualityIndex ToDomain()
            => new AirQualityIndex(Id, Name, Value, Level, Description, Advice, Color);

        public static AirQualityIndexEntity FromDomain(AirQualityIndex index, long measurementItemRef)
            => new AirQualityIndexEntity(index.Id,
                                         index.Name,
                                         index.Value,
                                         index.Level,
                                         index.Description,
                                         index.Advice,
                                         index.Color,
                                         measurementItemRef);
    }
}
