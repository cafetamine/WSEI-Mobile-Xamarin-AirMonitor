using System.Threading.Tasks;
using AirMonitor.Infrastructure.DI;
using AirMonitor.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace AirMonitor.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage : ContentPage
    {
        private const int DefaultRadius = 1;

        private MapViewModel ViewModel => BindingContext as MapViewModel;
        
        public MapPage()
        {
            InitializeComponent();

            BindingContext = ViewModelFactory.MakeMapViewModel(Navigation);
        }
        
        protected override void OnAppearing()
        {
            MeasurementsMap.Pins.Clear();
            CenterOnUser();
            ViewModel.Initialize();
            ViewModel.Pins.ForEach(pin => MeasurementsMap.Pins.Add(pin));
            base.OnAppearing();
        }

        private async Task CenterOnUser(int radius = DefaultRadius)
        {
            MoveTo(await ViewModel.GetCurrentPosition(), radius);
        }

        private void MoveTo(Position position, int radius)
        {
            MeasurementsMap.MoveToRegion(MapSpan.FromCenterAndRadius(position,  Distance.FromKilometers(radius)));
        }
    }
}
