using AirMonitor.Core.Domain.Measurement;
using AirMonitor.Infrastructure.DI;
using AirMonitor.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AirMonitor.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        private HomeViewModel ViewModel => BindingContext as HomeViewModel;

        public HomePage()
        {
            InitializeComponent();

            BindingContext = ViewModelFactory.MakeHomeViewModel(Navigation);
        }

        private void ListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            ViewModel.GoToDetailsCommand.Execute(e.Item as Measurement);
        }
    }
}
