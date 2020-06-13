using System;
using System.Threading.Tasks;
using System.Windows.Input;
using AirMonitor.Client.Airly;
using AirMonitor.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace AirMonitor.ViewModels
{
    public class HomeViewModel : AbstractViewModel
    {
        private readonly INavigation _navigation;
        private readonly IAirlyClient _airlyClient;
        private bool _isBusy;
        private bool _isLocked;
        private Location _location;

        public HomeViewModel(INavigation navigation, IAirlyClient airlyClient)
        {
            _navigation = navigation;
            _airlyClient = airlyClient;
            
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

        private async Task Initialize()
        {
            IsBusy = true;

            var location = await GetLocation();

            IsBusy = false;
        }
        
        private async Task<Location> GetLocation()
        {
            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync();

                if (location == null)
                {
                    var request = new GeolocationRequest(GeolocationAccuracy.Medium);
                    location = await Geolocation.GetLocationAsync(request);
                }

                if (location != null)
                {
                    Location = location;
                }

                return location;
            }
            // TODO handle no location -- ErrorPage
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
            return null;
        }
        

        private ICommand _goToDetailsCommand;
        public ICommand GoToDetailsCommand =>
            _goToDetailsCommand ?? (_goToDetailsCommand = new Command(OnGoToDetails));
        
        private void OnGoToDetails() => _navigation.PushAsync(new DetailsPage());
    }
}
