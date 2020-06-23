using System.Collections.Generic;
using AirMonitor.Core.Application.Measurement.Repository;
using AirMonitor.Persistence.Utility;

namespace AirMonitor.Persistence.Repository.Measurement
{
    public class MeasurementRepository : IMeasurementRepository
    {
        private readonly IDbConnection _connection;

        public MeasurementRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public Core.Domain.Measurement.Measurement FindById(long id)
        {
            throw new System.NotImplementedException();
        }

        public List<Core.Domain.Measurement.Measurement> FindAll()
        {
            throw new System.NotImplementedException();
        }

        public Core.Domain.Measurement.Measurement Save(Core.Domain.Measurement.Measurement measurement)
        {
            throw new System.NotImplementedException();
        }

        public List<Core.Domain.Measurement.Measurement> SaveAll(List<Core.Domain.Measurement.Measurement> measurements)
        {
            throw new System.NotImplementedException();
        }
    }
}
