using System.Collections.Generic;
using AirMonitor.Core.Application.Measurement.Repository.Item;
using AirMonitor.Core.Domain.Measurement.Item;
using AirMonitor.Persistence.Utility;

namespace AirMonitor.Persistence.Repository.Measurement.Item
{
    public class AirQualityIndexRepository : IAirQualityIndexRepository
    {
        private readonly IDbConnection _connection;

        public AirQualityIndexRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public List<AirQualityIndex> SaveAllFromMeasurementItem(MeasurementItem item)
        {
            throw new System.NotImplementedException();
        }

        public List<AirQualityIndex> FindAllyMeasurementItemId(long measurementItemId)
        {
            throw new System.NotImplementedException();
        }
    }
}
