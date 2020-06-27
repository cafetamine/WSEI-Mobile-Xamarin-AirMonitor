using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirMonitor.Core.Application.Location;
using AirMonitor.Core.Application.Measurement.Service;
using AirMonitor.Core.Domain.Installation;
using AirMonitor.Core.Domain.Measurement;
using Xamarin.Forms.Maps;

namespace AirMonitor.ViewModels
{
    public class MapViewModel : AbstractViewModel
    {
        private IMeasurementsService _measurementsService;
        private ILocationService _locationService;

        public MapViewModel(ILocationService locationService, IMeasurementsService measurementsService)
        {
            _measurementsService = measurementsService;
            _locationService = locationService;
        }

        public void Initialize()
        {
            IsBusy = true;
            
            Measurements = _measurementsService.ReadMeasurements();

            IsBusy = false;
        }

        private bool _isBusy;

        public bool IsBusy
        {
            get => _isBusy;
            set => SetProperty(ref _isBusy, value);
        }

        private List<Measurement> _measurements;
        public List<Measurement> Measurements
        {
            get => _measurements;
            set => SetProperty(ref _measurements, value);
        }

        public List<Pin> Pins
            => Measurements.Select(MapPin).ToList();

        public Task<Position> GetCurrentPosition()
            => _locationService.GetLocation().ContinueWith(location => MapPosition(location.Result));

        private static Position MapPosition(LocationMapping location)
            => new Position(location.Latitude, location.Longitude);

        private static Pin MapPin(Measurement measurement)
            => new Pin
            {
                Address = measurement.Installation.Address.Description,
                Type = PinType.Place,
                Position = MapPosition(measurement.Installation.Location),
                Label = $"CAQI: {measurement.CurrentDisplayValue}"
            };
    }
}
