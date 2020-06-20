using System;
using AirMonitor.Infrastructure;
using AirMonitor.Infrastructure.DI;
using AirMonitor.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AirMonitor.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        private HomeViewModel _viewModel => BindingContext as HomeViewModel;

        public HomePage()
        {
            InitializeComponent();

            BindingContext = ViewModelFactory.MakeHomeViewModel(Navigation);
        }
        
        private async void OnNavigationButtonTapped(object sender, EventArgs e)  
        {
            await Navigation.PushAsync(new DetailsPage());
        }
    }
}
