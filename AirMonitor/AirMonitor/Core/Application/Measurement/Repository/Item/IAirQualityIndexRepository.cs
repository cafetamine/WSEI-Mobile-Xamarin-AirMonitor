using System.Collections.Generic;
using AirMonitor.Core.Domain.Measurement.Item;

namespace AirMonitor.Core.Application.Measurement.Repository.Item
{
    public interface IAirQualityIndexRepository
    {
        List<AirQualityIndex> SaveAllFromMeasurementItem(MeasurementItem item);

        List<AirQualityIndex> FindAllyMeasurementItemId(long measurementItemId);
    }
}
