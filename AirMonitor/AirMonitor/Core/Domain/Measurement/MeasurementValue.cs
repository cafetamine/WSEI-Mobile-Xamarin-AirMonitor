namespace AirMonitor.Core.Domain.Measurement
{
    public class MeasurementValue
    {
        public long? Id { get; }
        public string Name { get; }
        public double Value { get; }

        public MeasurementValue(long? id, string name, double value)
        {
            Id = id;
            Name = name;
            Value = value;
        }

        public static MeasurementValue Create(string name, double value)
            => new MeasurementValue(null, name, value);
    }
}
