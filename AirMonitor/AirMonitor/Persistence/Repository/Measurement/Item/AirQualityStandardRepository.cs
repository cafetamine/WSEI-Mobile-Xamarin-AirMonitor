using System.Collections.Generic;
using AirMonitor.Core.Application.Measurement.Repository.Item;
using AirMonitor.Core.Domain.Measurement.Item;
using AirMonitor.Persistence.Utility;

namespace AirMonitor.Persistence.Repository.Measurement.Item
{
    public class AirQualityStandardRepository : IAirQualityStandardRepository
    {
        private readonly IDbConnection _connection;

        public AirQualityStandardRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public List<AirQualityStandard> SaveAllFromMeasurementItem(MeasurementItem item)
        {
            throw new System.NotImplementedException();
        }

        public List<AirQualityStandard> FindAllyMeasurementItemId(long measurementItemId)
        {
            throw new System.NotImplementedException();
        }
    }
}
