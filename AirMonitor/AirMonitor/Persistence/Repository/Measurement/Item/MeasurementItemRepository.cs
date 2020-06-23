using System.Collections.Generic;
using AirMonitor.Core.Application.Measurement.Repository.Item;
using AirMonitor.Core.Domain.Measurement.Item;
using AirMonitor.Persistence.Utility;

namespace AirMonitor.Persistence.Repository.Measurement.Item
{
    public class MeasurementItemRepository : IMeasurementItemRepository
    {
        private readonly IDbConnection _connection;

        public MeasurementItemRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public List<MeasurementItem> FindAllByMeasurementId(long measurementId)
        {
            throw new System.NotImplementedException();
        }

        public MeasurementItem Save(MeasurementItem item)
        {
            throw new System.NotImplementedException();
        }

        public List<MeasurementItem> SaveAll(List<MeasurementItem> measurements)
        {
            throw new System.NotImplementedException();
        }
    }
}
