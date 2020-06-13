using AirMonitor.Infrastructure;
using AirMonitor.Profile;
using AirMonitor.Views;
using Xamarin.Forms;

namespace AirMonitor
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            InitializeApp();
        }

        private async void InitializeApp()
        {
            var _appProfile = await AppProfile.Load();
            AppDIContainer.Instance.InitializeWithAppProfile(_appProfile);
            // TODO Async view display before profile is loaded
            MainPage = new NavigationTab();
        }

        protected override void OnStart() { }

        protected override void OnSleep() { }

        protected override void OnResume() { }
    }
}
