using AirMonitor.Infrastructure.DI;
using AirMonitor.Persistence.Utility;
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
            AppDIContainer.Instance.Resolve<IDbInitializer>().Execute();
            // TODO Async view display before profile is loaded
            MainPage = new NavigationTab();
        }

        protected override void OnStart() { }

        private void OnSleep()
        {
            AppDIContainer.Instance.Resolve<IDbConnection>().Connect();
        }

        private void OnResume()
        {
            AppDIContainer.Instance.Resolve<IDbConnection>().Disconnect();
        }
    }
}
