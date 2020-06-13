using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using AirMonitor.Client.Airly.Response;
using AirMonitor.Service.Location;
using AirMonitor.Service.Measurements;
using AirMonitor.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AirMonitor.ViewModels
{
    public class HomeViewModel : AbstractViewModel
    {
        private readonly INavigation _navigation;
        private readonly ILocationService _locationService;
        private readonly IMeasurementsService _measurementsService;
        
        private bool _isBusy;

        private Location _location;
        private List<ApiMeasurementResponse> _items;

        public HomeViewModel(INavigation navigation, ILocationService locationService, IMeasurementsService measurementsService)
        {
            _navigation = navigation;
            _locationService = locationService;
            _measurementsService = measurementsService;
            
            Initialize();
        }
        
        public bool IsBusy
        {
            get => _isBusy;
            set => SetProperty(ref _isBusy, value);
        }

        public Location Location
        {
            get => _location;
            set => SetProperty(ref _location, value);
        }
        
        public List<ApiMeasurementResponse> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }

        private async Task Initialize()
        {
            IsBusy = true;

            Location = await _locationService.GetLocation();
            Items = await _measurementsService.GetMeasurements(Location, 3);

            IsBusy = false;
        }

        private ICommand _goToDetailsCommand;
        public ICommand GoToDetailsCommand =>
            _goToDetailsCommand ?? (_goToDetailsCommand = new Command(OnGoToDetails));
        
        private void OnGoToDetails() => _navigation.PushAsync(new DetailsPage());
    }
}
