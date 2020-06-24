using System.Collections.Generic;
using AirMonitor.Core.Domain.Measurement.Item;

namespace AirMonitor.Core.Application.Measurement.Repository.Item
{
    public interface IMeasurementItemValueRepository
    {
        List<MeasurementValue> SaveAllFromMeasurementItem(MeasurementItem item);

        List<MeasurementValue> FindAllyMeasurementItemId(long measurementItemId);
        
        void DeleteAll();
    }
}
