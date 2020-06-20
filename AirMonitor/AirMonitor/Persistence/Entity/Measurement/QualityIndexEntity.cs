using AirMonitor.Core.Domain.Measurement;
using SQLite;

namespace AirMonitor.Persistence.Entity.Measurement
{
    public class AirQualityIndexEntity
    {
        [PrimaryKey, AutoIncrement]
        public long? Id { get; set; }
        public string Name { get; }
        public double? Value { get; }
        public string Level { get; }
        public string Description { get; }
        public string Advice { get; }
        public string Color { get; }

        private AirQualityIndexEntity(long? id,
                                      string name,
                                      double? value,
                                      string level,
                                      string description,
                                      string advice,
                                      string color)
        {
            Id = id;
            Name = name;
            Value = value;
            Level = level;
            Description = description;
            Advice = advice;
            Color = color;
        }
        
        public AirQualityIndex ToDomain()
            => new AirQualityIndex(Id, Name, Value, Level, Description, Advice, Color);
        
        public static AirQualityIndexEntity FromDomain(AirQualityIndex index)
            => new AirQualityIndexEntity(index.Id,
                                         index.Name,
                                         index.Value,
                                         index.Level,
                                         index.Description,
                                         index.Advice,
                                         index.Color);
    }
}
