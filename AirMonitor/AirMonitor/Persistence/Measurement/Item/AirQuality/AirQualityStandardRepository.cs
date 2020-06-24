using System;
using System.Collections.Generic;
using System.Linq;
using AirMonitor.Core.Application.Measurement.Repository.Item;
using AirMonitor.Core.Domain.Measurement.Item;
using AirMonitor.Persistence.Utility;

namespace AirMonitor.Persistence.Measurement.Item.AirQuality
{
    public class AirQualityStandardRepository : IAirQualityStandardRepository
    {
        private readonly IDbConnection _connection;

        public AirQualityStandardRepository(IDbConnection connection)
        {
            _connection = connection;
        }
        
        public List<AirQualityStandard> SaveAllFromMeasurementItem(MeasurementItem item)
            => item.Standards.Select(standard => Save(standard, item.Id ?? throw new ArgumentException("MeasurementItem id is null")))
                             .ToList();

        public List<AirQualityStandard> FindAllyMeasurementItemId(long measurementItemId)
            => _connection.Get.Table<AirQualityStandardEntity>()
                              .Where(standard => standard.MeasurementItemRef == measurementItemId)
                              .Select(standard => standard.ToDomain())
                              .ToList();

        private AirQualityStandard Save(AirQualityStandard standard, long measurementItemId)
        {
            if (_connection.Get.Insert(AirQualityStandardEntity.FromDomain(standard, measurementItemId)) > 0)
            {
                return standard.WithId(_connection.LastIndex);
            }
            return null;
        }
    }
}
