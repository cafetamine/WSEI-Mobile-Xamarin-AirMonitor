using AirMonitor.Core.Domain.Measurement;
using SQLite;

namespace AirMonitor.Persistence.Entity.Measurement
{
    public class MeasurementValueEntity
    {
        [PrimaryKey, AutoIncrement]
        public long? Id { get; set; }
        public string Name { get; }
        public double Value { get; }

        private MeasurementValueEntity(long? id, string name, double value)
        {
            Id = id;
            Name = name;
            Value = value;
        }
        
        public MeasurementValue ToDomain()
            => new MeasurementValue(Id, Name, Value);
        
        public static MeasurementValueEntity FromDomain(MeasurementValue value)
            => new MeasurementValueEntity(value.Id, value.Name, value.Value);
    }
}
