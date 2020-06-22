using System.Collections.Generic;
using AirMonitor.Core.Domain.Measurement.Item;

namespace AirMonitor.Core.Domain.Measurement
{
    public class Measurement
    {
        public long? Id { get; set; }
        public int CurrentDisplayValue { get; }
        public MeasurementItem Current { get; }
        public List<MeasurementItem> History { get; }
        public List<MeasurementItem> Forecast { get; }
        public Installation.Installation Installation { get; }

        public Measurement(long? id,
                           int currentDisplayValue,
                           MeasurementItem current,
                           List<MeasurementItem> history,
                           List<MeasurementItem> forecast,
                           Installation.Installation installation)
        {
            Id = id;
            CurrentDisplayValue = currentDisplayValue;
            Current = current;
            History = history;
            Forecast = forecast;
            Installation = installation;
        }
        
        public static Measurement Create(int currentDisplayValue,
                                         MeasurementItem current,
                                         List<MeasurementItem> history,
                                         List<MeasurementItem> forecast,
                                         Installation.Installation installation)
            => new Measurement(null, currentDisplayValue, current, history, forecast, installation);
    }
}
