namespace AirMonitor.Core.Domain.Measurement.Item
{
    public class AirQualityIndex
    {
        public long? Id { get; private set; }
        public string Name { get; }
        public double? Value { get; }
        public string Level { get; }
        public string Description { get; }
        public string Advice { get; }
        public string Color { get; }

        public AirQualityIndex(long? id,
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
        
        public AirQualityIndex WithId(long id)
        {
            Id = id;
            return this;
        }

        public static AirQualityIndex Create(string name,
                                             double? value,
                                             string level,
                                             string description,
                                             string advice,
                                             string color)
            => new AirQualityIndex(null, name, value, level, description, advice, color);
    }
}
