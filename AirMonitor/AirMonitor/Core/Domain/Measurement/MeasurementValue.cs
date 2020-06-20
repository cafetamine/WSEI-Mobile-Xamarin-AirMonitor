namespace AirMonitor.Core.Domain.Measurement
{
    public class MeasurementValue
    {
        public string Name { get; }
        public double Value { get; }

        public MeasurementValue(string name, double value)
        {
            Name = name;
            Value = value;
        }
    }
}
