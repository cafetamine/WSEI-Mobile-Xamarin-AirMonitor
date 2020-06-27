using System;
using System.Collections.Generic;
using AirMonitor.Core.Domain.Measurement.Item;
using SQLite;

namespace AirMonitor.Persistence.Measurement.Item
{
    public class MeasurementItemEntity
    {
        [PrimaryKey, AutoIncrement]
        public long? Id { get; set; }
        public int Type { get; set; }
        public DateTime FromDateTime { get; set; }
        public DateTime TillDateTime { get; set; }
        public long MeasurementRef { get; set; }

        public MeasurementItemEntity()
        {
            // for serialization
        }

        private MeasurementItemEntity(long? id,
                                      int type,
                                      DateTime fromDateTime,
                                      DateTime tillDateTime,
                                      long measurementRef)
        {
            Id = id;
            Type = type;
            FromDateTime = fromDateTime;
            TillDateTime = tillDateTime;
            MeasurementRef = measurementRef;
        }

        public MeasurementItem ToDomain(List<MeasurementValue> values,
                                        List<AirQualityIndex> indexes,
                                        List<AirQualityStandard> standards)
            => new MeasurementItem(Id,
                                   (MeasurementItemType)Type,
                                   FromDateTime,
                                   TillDateTime,
                                   values,
                                   indexes,
                                   standards);

        public static MeasurementItemEntity FromDomain(MeasurementItem item, long measurementRef)
            => new MeasurementItemEntity(item.Id,
                                         (int)item.Type,
                                         item.FromDateTime,
                                         item.TillDateTime,
                                         measurementRef);
    }
}
