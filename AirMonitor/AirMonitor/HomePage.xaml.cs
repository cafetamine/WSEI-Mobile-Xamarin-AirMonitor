using System;
using AirMonitor.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AirMonitor
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
