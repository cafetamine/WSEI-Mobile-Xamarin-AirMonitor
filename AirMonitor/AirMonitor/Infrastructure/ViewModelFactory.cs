using AirMonitor.Client.Airly;
using AirMonitor.ViewModels;
using Xamarin.Forms;

namespace AirMonitor.Infrastructure
{
    // TODO refactor <T> MakeFromType(<T>)
    public class ViewModelFactory
    {
        public static HomeViewModel MakeHomeViewModel(INavigation navigation)
            => new HomeViewModel(navigation:  navigation,
                                 airlyClient: AppDIContainer.Instance.Resolve<IAirlyClient>());

        public static DetailsViewModel MakeDetailsViewModel() => new DetailsViewModel();
    }
}
