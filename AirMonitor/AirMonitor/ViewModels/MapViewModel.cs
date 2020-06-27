using System.Collections.Generic;
using AirMonitor.Core.Domain.Map;

namespace AirMonitor.ViewModels
{
    public class MapViewModel : AbstractViewModel
    {
        private List<MapLocation> _mapLocations;
        public List<MapLocation> MapLocations
        {
            get => _mapLocations;
            set=> SetProperty(ref _mapLocations, value);
        }
    }
}
