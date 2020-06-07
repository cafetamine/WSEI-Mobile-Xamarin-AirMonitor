using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AirMonitor.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
        
        private async void OnNavigationButtonTapped(object sender, EventArgs e)  
        {
            await Navigation.PushAsync(new DetailsPage());
        }
    }
}
