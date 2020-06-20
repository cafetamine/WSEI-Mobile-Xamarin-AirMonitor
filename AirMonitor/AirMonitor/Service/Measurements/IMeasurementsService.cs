using System.Collections.Generic;
using System.Threading.Tasks;
using AirMonitor.Model.Domain.Measurement;

namespace AirMonitor.Service.Measurements
{
    public interface IMeasurementsService
    {
        Task<List<Measurement>> GetMeasurements(Xamarin.Essentials.Location location, int maxResults = 3);
    }
}
