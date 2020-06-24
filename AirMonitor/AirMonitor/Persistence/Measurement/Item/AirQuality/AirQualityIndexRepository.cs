using System;
using System.Collections.Generic;
using System.Linq;
using AirMonitor.Core.Application.Measurement.Repository.Item;
using AirMonitor.Core.Domain.Measurement.Item;
using AirMonitor.Persistence.Utility;

namespace AirMonitor.Persistence.Measurement.Item.AirQuality
{
    public class AirQualityIndexRepository : IAirQualityIndexRepository
    {
        private readonly IDbConnection _connection;

        public AirQualityIndexRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public List<AirQualityIndex> SaveAllFromMeasurementItem(MeasurementItem item)
            => item.Indexes.Select(index => Save(index, index.Id ?? throw new ArgumentException("MeasurementItem id is null")))
                           .ToList();

        public List<AirQualityIndex> FindAllyMeasurementItemId(long measurementItemId)
            => _connection.Get.Table<AirQualityIndexEntity>()
                              .Where(index => index.MeasurementItemRef == measurementItemId)
                              .Select(index => index.ToDomain())
                              .ToList();

        private AirQualityIndex Save(AirQualityIndex index, long measurementItemId)
        {
            if (_connection.Get.Insert(AirQualityIndexEntity.FromDomain(index, measurementItemId)) > 0)
            {
                return index.WithId(_connection.LastIndex);
            }
            return null;
        }
    }
}
