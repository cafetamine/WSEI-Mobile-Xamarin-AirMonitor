using System;
using AirMonitor.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AirMonitor
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // TODO HomePage
            MainPage = new DetailsPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
