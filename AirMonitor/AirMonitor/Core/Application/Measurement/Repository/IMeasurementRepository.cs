using System.Collections.Generic;
using MeasurementDomain = AirMonitor.Core.Domain.Measurement.Measurement;

namespace AirMonitor.Core.Application.Measurement.Repository
{
    public interface IMeasurementRepository
    {
        MeasurementDomain FindById(long id);

        List<MeasurementDomain> FindAll();

        MeasurementDomain Save(MeasurementDomain measurement);

        List<MeasurementDomain> SaveAll(List<MeasurementDomain> measurements);

        void DeleteAll();
    }
}
