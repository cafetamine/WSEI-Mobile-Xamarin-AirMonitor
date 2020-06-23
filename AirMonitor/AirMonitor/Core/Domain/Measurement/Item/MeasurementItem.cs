using System;
using System.Collections.Generic;

namespace AirMonitor.Core.Domain.Measurement.Item
{
    public class MeasurementItem
    {
        public long? Id { get; private set; }
        public MeasurementItemType Type { get; }
        public DateTime FromDateTime { get; }
        public DateTime TillDateTime { get; }
        public List<MeasurementValue> Values { get; private set; }
        public List<AirQualityIndex> Indexes { get; private set; }
        public List<AirQualityStandard> Standards { get; private set; }

        public MeasurementItem(long? id,
                               MeasurementItemType type,
                               DateTime fromDateTime,
                               DateTime tillDateTime,
                               List<MeasurementValue> values,
                               List<AirQualityIndex> indexes,
                               List<AirQualityStandard> standards)
        {
            Id = id;
            Type = type;
            FromDateTime = fromDateTime;
            TillDateTime = tillDateTime;
            Values = values;
            Indexes = indexes;
            Standards = standards;
        }

        public MeasurementItem WithId(long id)
        {
            Id = id;
            return this;
        }

        public MeasurementItem WithValues(List<MeasurementValue> values)
        {
            Values = values;
            return this;
        }
        
        public MeasurementItem WithIndexes(List<AirQualityIndex> indexes)
        {
            Indexes = indexes;
            return this;
        }
        
        public MeasurementItem WithStandards(List<AirQualityStandard> standards)
        {
            Standards = standards;
            return this;
        }

        public static MeasurementItem Create(MeasurementItemType type,
                                             DateTime fromDateTime,
                                             DateTime tillDateTime,
                                             List<MeasurementValue> values,
                                             List<AirQualityIndex> indexes,
                                             List<AirQualityStandard> standards)
            => new MeasurementItem(null, type, fromDateTime, tillDateTime, values, indexes, standards);
    }
}
