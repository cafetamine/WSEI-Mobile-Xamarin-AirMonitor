using System;
using System.Collections.Generic;

namespace AirMonitor.Core.Domain.Measurement
{
    public class MeasurementItem
    {
        public long? Id { get; }
        public DateTime FromDateTime { get; }
        public DateTime TillDateTime { get; }
        public List<MeasurementValue> Values { get; }
        public List<AirQualityIndex> Indexes { get; }
        public List<AirQualityStandard> Standards { get; }

        public MeasurementItem(long? id,
                               DateTime fromDateTime,
                               DateTime tillDateTime,
                               List<MeasurementValue> values,
                               List<AirQualityIndex> indexes,
                               List<AirQualityStandard> standards)
        {
            Id = id;
            FromDateTime = fromDateTime;
            TillDateTime = tillDateTime;
            Values = values;
            Indexes = indexes;
            Standards = standards;
        }
        
        public static MeasurementItem Create(DateTime fromDateTime,
                                             DateTime tillDateTime,
                                             List<MeasurementValue> values,
                                             List<AirQualityIndex> indexes,
                                             List<AirQualityStandard> standards)
            => new MeasurementItem(null, fromDateTime, tillDateTime, values, indexes, standards);
    }
}
