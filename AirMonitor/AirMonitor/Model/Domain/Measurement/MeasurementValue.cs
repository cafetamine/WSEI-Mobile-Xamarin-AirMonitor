using AirMonitor.Client.Airly.Api.Installation;

namespace AirMonitor.Model.Domain.Measurement
{
    public class MeasurementValue
    {
        public string Name { get; }
        public double Value { get; }

        private MeasurementValue(string name, double value)
        {
            Name = name;
            Value = value;
        }
        
        public static MeasurementValue FromApi(ApiMeasurementValue value)
            => new MeasurementValue(value.Name, value.Value);
    }
}
