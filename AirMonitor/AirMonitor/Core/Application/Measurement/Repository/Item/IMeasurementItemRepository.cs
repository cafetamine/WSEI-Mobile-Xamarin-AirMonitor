using System.Collections.Generic;
using AirMonitor.Core.Domain.Measurement.Item;
using MeasurementDomain = AirMonitor.Core.Domain.Measurement.Measurement;

namespace AirMonitor.Core.Application.Measurement.Repository.Item
{
    public interface IMeasurementItemRepository
    {
        List<MeasurementItem> FindAllByMeasurementId(long measurementId);

        List<MeasurementItem> SaveAll(List<MeasurementItem> items, long measurementId);

        MeasurementItem Save(MeasurementItem item, long measurementId);
        
        void DeleteAll();
    }
}
