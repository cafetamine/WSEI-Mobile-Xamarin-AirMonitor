namespace AirMonitor.Core.Domain.Measurement
{
    public class AirQualityIndex
    {
        public string Name { get; }
        public double? Value { get; }
        public string Level { get; }
        public string Description { get; }
        public string Advice { get; }
        public string Color { get; }

        public AirQualityIndex(string name,
                               double? value,
                               string level,
                               string description,
                               string advice,
                               string color)
        {
            Name = name;
            Value = value;
            Level = level;
            Description = description;
            Advice = advice;
            Color = color;
        }
    }
}
