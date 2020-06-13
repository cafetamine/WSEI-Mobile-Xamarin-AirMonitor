using System;
using AirMonitor.Views;
using Xamarin.Forms;

namespace AirMonitor
{
    public partial class App : Application
    {
        private AppProfile _appProfile;

        public AppProfile AppProfile => _appProfile;

        
        public App()
        {
            InitializeComponent();
            InitializeApp();
        }

        private async void InitializeApp()
        {
            MainPage = new NavigationTab();
            _appProfile = await AppProfile.Load();
            // TODO log profile
            // TODO encrypt key
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
