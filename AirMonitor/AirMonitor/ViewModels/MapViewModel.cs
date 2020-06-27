using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirMonitor.Core.Application.Location;
using AirMonitor.Core.Application.Measurement.Service;
using AirMonitor.Core.Domain.Installation;
using AirMonitor.Core.Domain.Measurement;
using AirMonitor.Views;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace AirMonitor.ViewModels
{
    public class MapViewModel : AbstractViewModel
    {
        private INavigation _navigation;
        private IMeasurementsService _measurementsService;
        private ILocationService _locationService;

        public MapViewModel(INavigation navigation, ILocationService locationService, IMeasurementsService measurementsService)
        {
            _navigation = navigation;
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

        private Pin MapPin(Measurement measurement)
        {
            var pin = new Pin
            {
                Address = measurement.Installation.Address.Description,
                Type = PinType.Place,
                Position = MapPosition(measurement.Installation.Location),
                Label = $"CAQI: {measurement.CurrentDisplayValue}"
            };
            pin.MarkerClicked += async (s, args) => { OnGoToDetails(measurement); };
            return pin;
        }
        
        private void OnGoToDetails(Measurement item)
        {
            _navigation.PushAsync(new DetailsPage(item));
        }
    }
}
