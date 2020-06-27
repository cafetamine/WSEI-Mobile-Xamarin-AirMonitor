using AirMonitor.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace AirMonitor.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            InitializeComponent();
            
            BindingContext = new MapViewModel();
        }
        
        private void OnPinTapped(object sender, PinClickedEventArgs e)
        {
            //ViewModel.InfoWindowClickedCommand.Execute((sender as Pin).Address);
        }
    }
}
