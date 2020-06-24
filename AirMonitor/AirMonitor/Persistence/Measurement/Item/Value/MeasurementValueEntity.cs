using AirMonitor.Core.Domain.Measurement.Item;

namespace AirMonitor.Persistence.Measurement.Item.Value
{
    public class MeasurementValueEntity
    {
        public long? Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public long MeasurementItemRef { get; set; }

        public MeasurementValueEntity()
        {
            // for serialization
        }

        private MeasurementValueEntity(long? id, string name, double value, long measurementItemRef)
        {
            Id = id;
            Name = name;
            Value = value;
            MeasurementItemRef = measurementItemRef;
        }

        public MeasurementValue ToDomain()
            => new MeasurementValue(Id, Name, Value);

        public static MeasurementValueEntity FromDomain(MeasurementValue value, long measurementItemRef)
            => new MeasurementValueEntity(value.Id, value.Name, value.Value, measurementItemRef);
    }
}
