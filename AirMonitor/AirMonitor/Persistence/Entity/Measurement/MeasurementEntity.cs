using System;
using System.Collections.Generic;
using AirMonitor.Core.Domain.Measurement;
using SQLite;

namespace AirMonitor.Persistence.Entity.Measurement
{
    public class MeasurementEntity
    {
        [PrimaryKey, AutoIncrement]
        public long? Id { get; set; }
        public int CurrentDisplayValue { get; set; }
        public long CurrentRef { get; set; }
        public long InstallationRef { get; set; }
        
        public MeasurementEntity()
        {
            // for serialization
        }

        private MeasurementEntity(long? id,
                                  int currentDisplayValue,
                                  long currentRef,
                                  long installationRef)
        {
            Id = id;
            CurrentDisplayValue = currentDisplayValue;
            CurrentRef = currentRef;
            InstallationRef = installationRef;
        }

        // TODO temporary logic let's see sqlite framework first
        public Core.Domain.Measurement.Measurement ToDomain(MeasurementItem current,
                                                            List<MeasurementItem> history,
                                                            List<MeasurementItem> forecast,
                                                            Core.Domain.Installation.Installation installation)
            => new Core.Domain.Measurement.Measurement(Id,
                                                       CurrentDisplayValue,
                                                       current,
                                                       history,
                                                       forecast,
                                                       installation);
        
        public static MeasurementEntity FromDomain(Core.Domain.Measurement.Measurement measurement)
            => new MeasurementEntity(measurement.Id,
                                     measurement.CurrentDisplayValue,
                                     measurement.Current.Id ?? throw new ArgumentException("Current reference is set to null"),
                                     measurement.Installation.Id); // Installation id comes from airly api
    }
}