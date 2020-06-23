namespace AirMonitor.Core.Domain.Measurement.Item
{
    public class MeasurementValue
    {
        public long? Id { get; private set; }
        public string Name { get; }
        public double Value { get; }

        public MeasurementValue(long? id, string name, double value)
        {
            Id = id;
            Name = name;
            Value = value;
        }
        
        public MeasurementValue WithId(long id)
        {
            Id = id;
            return this;
        }

        public static MeasurementValue Create(string name, double value)
            => new MeasurementValue(null, name, value);
    }
}
