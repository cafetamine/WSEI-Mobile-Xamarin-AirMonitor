using System.Collections.Generic;
using AirMonitor.Core.Domain.Measurement.Item;

namespace AirMonitor.Core.Application.Measurement.Repository.Item
{
    public interface IMeasurementItemRepository
    {
        List<MeasurementItem> FindAllByMeasurementId(long measurementId);
        
        MeasurementItem Save(MeasurementItem item);

        List<MeasurementItem> SaveAll(List<MeasurementItem> measurements);
    }
}
