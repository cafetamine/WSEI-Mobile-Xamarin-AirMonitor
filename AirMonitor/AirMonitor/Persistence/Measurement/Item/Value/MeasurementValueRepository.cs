using System;
using System.Collections.Generic;
using System.Linq;
using AirMonitor.Core.Application.Measurement.Repository.Item;
using AirMonitor.Core.Domain.Measurement.Item;
using AirMonitor.Persistence.Utility;

namespace AirMonitor.Persistence.Measurement.Item.Value
{
    public class MeasurementValueRepository : IMeasurementItemValueRepository
    {
        private readonly IDbConnection _connection;

        public MeasurementValueRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public List<MeasurementValue> SaveAllFromMeasurementItem(MeasurementItem item)
            => item.Values.Select(value => Save(value, item.Id ?? throw new ArgumentException("MeasurementItem id is null")))
                          .ToList();

        public List<MeasurementValue> FindAllyMeasurementItemId(long measurementItemId)
            => _connection.Get.Table<MeasurementValueEntity>()
                              .Where(value => value.MeasurementItemRef == measurementItemId)
                              .Select(value => value.ToDomain())
                              .ToList();

        private MeasurementValue Save(MeasurementValue value, long measurementItemId)
        {
            if (_connection.Get.Insert(MeasurementValueEntity.FromDomain(value, measurementItemId)) > 0)
            {
                return value.WithId(_connection.LastIndex);
            }
            return null;
        }
    }
}
