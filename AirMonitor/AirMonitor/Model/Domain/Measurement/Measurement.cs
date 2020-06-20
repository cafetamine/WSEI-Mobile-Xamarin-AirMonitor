using System.Collections.Generic;

namespace AirMonitor.Model.Domain.Measurement
{
    public class Measurement
    {
        public int CurrentDisplayValue { get; }
        public MeasurementItem Current { get; }
        public List<MeasurementItem> History { get; }
        public List<MeasurementItem> Forecast { get; }
        public Installation.Installation Installation { get; }

        public Measurement(int currentDisplayValue,
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
    }
}
