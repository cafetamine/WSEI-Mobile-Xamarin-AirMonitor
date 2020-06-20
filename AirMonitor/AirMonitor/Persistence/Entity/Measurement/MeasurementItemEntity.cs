using System;
using System.Collections.Generic;
using System.Linq;
using AirMonitor.Core.Domain.Measurement;
using SQLite;

namespace AirMonitor.Persistence.Entity.Measurement
{
    // TODO references
    public class MeasurementItemEntity
    {
        [PrimaryKey, AutoIncrement]
        public long? Id { get; set; }
        public DateTime FromDateTime { get; }
        public DateTime TillDateTime { get; }

        private MeasurementItemEntity(long? id,
                                      DateTime fromDateTime,
                                      DateTime tillDateTime)
        {
            Id = id;
            FromDateTime = fromDateTime;
            TillDateTime = tillDateTime;
        }
        
        public MeasurementItem ToDomain(IEnumerable<MeasurementValueEntity> values,
                                        IEnumerable<AirQualityIndexEntity> indexes,
                                        IEnumerable<AirQualityStandardEntity> standards)
            => new MeasurementItem(Id,
                                   FromDateTime,
                                   TillDateTime,
                                   values.Select(value => value.ToDomain()).ToList(),
                                   indexes.Select(index => index.ToDomain()).ToList(),
                                   standards.Select(standard => standard.ToDomain()).ToList());
        
        public static MeasurementItemEntity FromDomain(MeasurementItem item)
            => new MeasurementItemEntity(item.Id,
                                         item.FromDateTime,
                                         item.TillDateTime);
    }
}
