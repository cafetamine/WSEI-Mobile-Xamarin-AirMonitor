using System.Collections.Generic;
using AirMonitor.Core.Domain.Measurement.Item;
using InstallationDomain = AirMonitor.Core.Domain.Installation.Installation;

namespace AirMonitor.Core.Domain.Measurement
{
    public class Measurement
    {
        public long? Id { get; private set; }
        public int CurrentDisplayValue { get; }
        public MeasurementItem Current { get; private set; }
        public List<MeasurementItem> History { get; private set; }
        public List<MeasurementItem> Forecast { get; private set; }
        public InstallationDomain Installation { get; private set; }

        public Measurement(long? id,
                           int currentDisplayValue,
                           MeasurementItem current,
                           List<MeasurementItem> history,
                           List<MeasurementItem> forecast,
                           InstallationDomain installation)
        {
            Id = id;
            CurrentDisplayValue = currentDisplayValue;
            Current = current;
            History = history;
            Forecast = forecast;
            Installation = installation;
        }

        public Measurement WIthId(long id)
        {
            Id = id;
            return this;
        }

        public Measurement WithCurrent(MeasurementItem current)
        {
            Current = current;
            return this;
        }

        public Measurement WithHistory(List<MeasurementItem> history)
        {
            History = history;
            return this;
        }
        
        public Measurement WithForecast(List<MeasurementItem> forecast)
        {
            Forecast = forecast;
            return this;
        }

        public Measurement WithInstallation(InstallationDomain installation)
        {
            Installation = installation;
            return this;
        }
        
        public static Measurement Create(int currentDisplayValue,
                                         MeasurementItem current,
                                         List<MeasurementItem> history,
                                         List<MeasurementItem> forecast,
                                         Installation.Installation installation)
            => new Measurement(null, currentDisplayValue, current, history, forecast, installation);
    }
}
