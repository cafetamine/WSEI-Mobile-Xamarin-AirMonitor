using System.Collections.Generic;
using AirMonitor.Core.Application.Measurement.Repository.Item;
using AirMonitor.Core.Domain.Measurement.Item;
using AirMonitor.Persistence.Utility;

namespace AirMonitor.Persistence.Repository.Measurement.Item
{
    public class MeasurementValueRepository : IMeasurementItemValueRepository
    {
        private readonly IDbConnection _connection;

        public MeasurementValueRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public List<MeasurementValue> SaveAllFromMeasurementItem(MeasurementItem item)
        {
            throw new System.NotImplementedException();
        }

        public List<MeasurementValue> FindAllyMeasurementItemId(long measurementItemId)
        {
            throw new System.NotImplementedException();
        }
    }
}
