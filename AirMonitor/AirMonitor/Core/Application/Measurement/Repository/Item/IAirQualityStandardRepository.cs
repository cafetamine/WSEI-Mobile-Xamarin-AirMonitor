using System.Collections.Generic;
using AirMonitor.Core.Domain.Measurement.Item;

namespace AirMonitor.Core.Application.Measurement.Repository.Item
{
    public interface IAirQualityStandardRepository
    {
        List<AirQualityStandard> SaveAllFromMeasurementItem(MeasurementItem item);

        List<AirQualityStandard> FindAllyMeasurementItemId(long measurementItemId);
    }
}
