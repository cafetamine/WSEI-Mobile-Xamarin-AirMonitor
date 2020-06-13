using System;
using System.Collections.Generic;
using System.Linq;
using AirMonitor.Client.Airly.Api.Measurement;

namespace AirMonitor.Model.Domain.Measurement
{
    public class MeasurementItem
    {
        public DateTime FromDateTime { get; }
        public DateTime TillDateTime { get; }
        public List<MeasurementValue> Values { get; }
        public List<AirQualityIndex> Indexes { get; }
        public List<AirQualityStandard> Standards { get; }

        private MeasurementItem(DateTime fromDateTime,
                                DateTime tillDateTime,
                                List<MeasurementValue> values,
                                List<AirQualityIndex> indexes,
                                List<AirQualityStandard> standards)
        {
            FromDateTime = fromDateTime;
            TillDateTime = tillDateTime;
            Values = values;
            Indexes = indexes;
            Standards = standards;
        }
        
        public static MeasurementItem FromApi(ApiMeasurementItem item)
            => new MeasurementItem(item.FromDateTime,
                                   item.TillDateTime,
                                   item.Values.Select(MeasurementValue.FromApi).ToList(),
                                   item.Indexes.Select(AirQualityIndex.FromApi).ToList(),
                                   item.Standards.Select(AirQualityStandard.FromApi).ToList());
    }
}
