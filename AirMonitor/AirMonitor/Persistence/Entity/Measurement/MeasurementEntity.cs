using System;
using System.Collections.Generic;
using System.Linq;
using AirMonitor.Core.Domain.Measurement.Item;
using MeasurementDomain = AirMonitor.Core.Domain.Measurement.Measurement;
using InstallationDomain = AirMonitor.Core.Domain.Installation.Installation;

namespace AirMonitor.Persistence.Entity.Measurement
{
    public class MeasurementEntity
    {
        public long? Id { get; set; }
        public int CurrentDisplayValue { get; set; }
        public long InstallationRef { get; set;}

        public MeasurementEntity()
        {
            // for serialization
        }

        private MeasurementEntity(long? id,
                                 int currentDisplayValue,
                                 long installationRef)
        {
            Id = id;
            CurrentDisplayValue = currentDisplayValue;
            InstallationRef = installationRef;
        }

        public MeasurementDomain ToDomain(MeasurementItem current,
                                          List<MeasurementItem> history,
                                          List<MeasurementItem> forecast,
                                          InstallationDomain installation)
            => new MeasurementDomain(Id, CurrentDisplayValue, current, history, forecast, installation);

        public MeasurementDomain ToDomain(List<MeasurementItem> items, InstallationDomain installation)
        {
            var current = items.First(item => item.Type == MeasurementItemType.Current) ?? throw new ArgumentException("Measurement.Current is null");
            var history = items.Where(item => item.Type == MeasurementItemType.History).ToList();
            var forecast = items.Where(item => item.Type == MeasurementItemType.Forecast).ToList();
            return ToDomain(current, history, forecast, installation);
        }

        public static MeasurementEntity FromDomain(MeasurementDomain measurement)
            => new MeasurementEntity(measurement.Id, measurement.CurrentDisplayValue, measurement.Installation.Id);
    }
}
