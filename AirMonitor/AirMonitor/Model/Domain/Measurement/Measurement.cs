using System.Collections.Generic;
using System.Linq;
using AirMonitor.Client.Airly.Api.Measurement;

namespace AirMonitor.Model.Domain.Measurement
{
    public class Measurement
    {
        public int CurrentDisplayValue { get; }
        public MeasurementItem Current { get; }
        public List<MeasurementItem> History { get; }
        public List<MeasurementItem> Forecast { get; }
        public Installation.Installation Installation { get; }

        private Measurement(int currentDisplayValue,
                            MeasurementItem current,
                            List<MeasurementItem> history,
                            List<MeasurementItem> forecast,
                            Installation.Installation installation)
        {
            CurrentDisplayValue = currentDisplayValue;
            Current = current;
            History = history;
            Forecast = forecast;
            Installation = installation;
        }
        
        public static Measurement FromApi(ApiMeasurement measurement)
            => new Measurement(measurement.CurrentDisplayValue,
                               MeasurementItem.FromApi(measurement.Current),
                               measurement.History.Select(MeasurementItem.FromApi).ToList(),
                               measurement.Forecast.Select(MeasurementItem.FromApi).ToList(),
                               Domain.Installation.Installation.FromApi(measurement.Installation));
    }
}